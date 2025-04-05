using Interfaces;
using Models;
using Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class EnderecosContato : Form
    {
        private readonly Contato _contato;
        private readonly IEnderecoContatoDB _enderecoContatoDB;


        public EnderecosContato(Contato contanto, IEnderecoContatoDB enderecoContatoDB)
        {
            _contato = contanto;
            _enderecoContatoDB = enderecoContatoDB;
            InitializeComponent();
        }

        private void EnderecosContato_Load(object sender, EventArgs e)
        {
            CarregaCampos();
            CarregaGrid();
        }

        private void CarregaCampos()
        {
            txbIdContato.Text = _contato.IdContato.ToString();
            txbNome.Text = _contato.Nome;
            txbSobrenome.Text = _contato.Sobrenome;
        }

        private void CarregaGrid()
        {
            gvEnderecoContato.Rows.Clear();

            var sessao = UsuarioLogado.ObterInstancia();

            List<EnderecoContato> enderecosContatos = _enderecoContatoDB.GetEnderecosContato(_contato.IdContato);

            if (enderecosContatos == null)
            {
                MessageBox.Show("Erro inesperado ao buscar endereços de contato");
                return;
            }

            int indice = 0;

            foreach (var item in enderecosContatos)
            {
                indice = gvEnderecoContato.Rows.Add();
                gvEnderecoContato.Rows[indice].Cells["Id"].Value = item.IdEnderecoContato;
                gvEnderecoContato.Rows[indice].Cells["Tipo"].Value = item.IdTipoContato;
                gvEnderecoContato.Rows[indice].Cells["Valor"].Value = item.Valor;
                gvEnderecoContato.Rows[indice].Cells["Observacao"].Value = item.Observacao;             
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            string tipo = EnderecoContato.getTipoContato(1);
            MessageBox.Show(tipo);
        }
    }
}
