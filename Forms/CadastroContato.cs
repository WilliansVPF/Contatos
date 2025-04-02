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
    public partial class CadastroContato : Form
    {
        //private bool _estaOk;
        private readonly IContatoDB _contatoDB;
        private Contato _contato;

        public CadastroContato(IContatoDB contatoDB, Contato? contato)
        {
            _contatoDB = contatoDB;
            _contato = contato;
            InitializeComponent();
        }

        private void CadastroContato_Load(object sender, EventArgs e)
        {
            if (_contato != null) CarregaCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            if (!ValidaCampos()) return;

            var sessao = UsuarioLogado.ObterInstancia();
            var contato = new Contato
            {
                IdContato = int.Parse(txbId.Text),
                Nome = txbNome.Text,
                Sobrenome = txbSobrenome.Text,
                idUsuario = sessao.Id
            };

            if (contato.IdContato == 0) CadastraContato(contato);
            else AtualizaContato(contato);            

        }

        private void CadastraContato(Contato contato)
        {
            if (!_contatoDB.NovoContato(contato))
            {
                MessageBox.Show("Erro inesperado ao cadastrar contato");
                return;
            }

            MessageBox.Show("Contato Salvo!");
            this.DialogResult = DialogResult.OK;
            this.Close();
            //return;
        }

        private void AtualizaContato(Contato contato)
        {
            if (!_contatoDB.AtualizaContato(contato))
            {
                MessageBox.Show("Erro inesperado ao atualizar contato");
                return;
            }

            MessageBox.Show("Contato atualizado!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CarregaCampos()
        {
            txbNome.Text = _contato.Nome;
            txbSobrenome.Text = _contato.Sobrenome;
            txbId.Text = _contato.IdContato.ToString();

        }

        private bool ValidaCampos()
        {
            bool estaOk = true;

            if (txbNome.Text == "")
            {
                lblNome.Visible = true;
                estaOk = false;
            }
            else lblNome.Visible = false;

            if (txbSobrenome.Text == "")
            {
                lblSobrenome.Visible = true;
                estaOk = false;
            }
            else lblSobrenome.Visible = false;

            return estaOk;
        }

        
    }
}
