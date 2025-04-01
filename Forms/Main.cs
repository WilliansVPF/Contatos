using Microsoft.Extensions.DependencyInjection;
using Models;
using Servicos;

namespace Forms
{
    public partial class Main : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            var login = _serviceProvider.GetRequiredService<Login>();
            login.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var sessao = UsuarioLogado.ObterInstancia();
            MessageBox.Show(sessao.Usuario);
            gvContatos.Columns.Add("teste","teste1");
            gvContatos.Rows[0].Cells["teste"].Value = "qlq coisa";
            int linhas = gvContatos.RowCount;
            MessageBox.Show(linhas.ToString());
        }
    }
}
