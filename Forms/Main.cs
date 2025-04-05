using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Models;
using Org.BouncyCastle.Asn1.Esf;
using Servicos;

namespace Forms
{
    public partial class Main : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IContatoDB _contatoDB;
        IEnderecoContatoDB _enderecoContatoDB;

        private readonly UsuarioLogado _sessao = UsuarioLogado.ObterInstancia();

        public Main(IServiceProvider serviceProvider, IContatoDB contatoDB, IEnderecoContatoDB enderecoContatoDB)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _contatoDB = contatoDB;
            var login = _serviceProvider.GetRequiredService<Login>();
            login.ShowDialog();
            _enderecoContatoDB = enderecoContatoDB;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            gvContatos.Rows.Clear();

            List<Contato> contatos = _contatoDB.GetContato(_sessao.Id);

            int indice = 0;

            foreach (var contato in contatos)
            {
                indice = gvContatos.Rows.Add();
                gvContatos.Rows[indice].Cells["Id"].Value = contato.IdContato;
                gvContatos.Rows[indice].Cells["Nome"].Value = contato.Nome;
                gvContatos.Rows[indice].Cells["Sobrenome"].Value = contato.Sobrenome;

            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            var cadastroContato = new CadastroContato(_contatoDB, null);

            if (cadastroContato.ShowDialog() == DialogResult.OK) CarregaGrid();

            //cadastroContato.ShowDialog();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (gvContatos.CurrentRow != null) id = (int)gvContatos.SelectedRows[0].Cells["Id"].Value;
            else
            {
                MessageBox.Show("Selecione um Contato");
                return;
            }

            var contato = _contatoDB.GetContato(_sessao.Id).FirstOrDefault(c => c.IdContato == id);

            var cadastroContato = new CadastroContato(_contatoDB, contato);
            if (cadastroContato.ShowDialog() == DialogResult.OK) CarregaGrid();

        }

        private void gvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (e.RowIndex >= 0) id = (int)gvContatos.SelectedRows[0].Cells["Id"].Value;
            else return;

            var contato = _contatoDB.GetContato(_sessao.Id).FirstOrDefault(c => c.IdContato == id);

            
            var enderecoContato = new EnderecosContato(contato, _enderecoContatoDB);
            enderecoContato.ShowDialog();
        }
    }
}
