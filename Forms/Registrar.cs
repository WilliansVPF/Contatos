using Interfaces;
using Models;
using Repository;
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
    public partial class Registrar : Form
    {
        private readonly IUsuarioDB _usuarioDB;
        private bool _estaOK;

        public Registrar(IUsuarioDB usuarioDB)
        {
            _usuarioDB = usuarioDB;
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            _estaOK = true;

            ValidaCampoBranco();

            if (!_estaOK) return;

            string salt = GeraHash.Salt;
            string senha = GeraHash.Hash(txbSenha.Text);
            senha = GeraHash.Hash(salt +  senha);

            Usuario usuario = new Usuario
            {
                Nome = txbNome.Text,
                Login = txbUsuario.Text,
                Senha = senha,
                Salt = salt
            };

            if (!_usuarioDB.RegistraUsuario(usuario))
            {
                MessageBox.Show("Erro inesperado ao registrar usuario");
                return;
            }

            MessageBox.Show("Registro realizado com sucesso!");
            this.Close();

        }

        private void ValidaCampoBranco()
        {
            if (txbNome.Text == "")
            {
                lblNome.Text = "* Este campo é obrigatorio";
                lblNome.Visible = true;
                _estaOK = false;
            }
            else
            {
                lblNome.Visible = false;
            }

            if (txbUsuario.Text == "")
            {
                lblUsuario.Text = "* Este campo é obrigatorio";
                lblUsuario.Visible = true;
                _estaOK = false;
            }
            else
            {
                lblUsuario.Visible = false;
            }

            if (txbSenha.Text == "")
            {
                lblSenha.Text = "* Este campo é obrigatorio";
                lblSenha.Visible = true;
                _estaOK = false;
            }
            else
            {
                lblSenha.Visible = false;
            }

            if (txbRepitaSenha.Text == "")
            {
                lblConfirmaSenha.Text = "* Este campo é obrigatorio";
                lblConfirmaSenha.Visible = true;
                _estaOK = false;
            }
            else
            {
                lblConfirmaSenha.Visible = false;
            }

            if (!_estaOK) return;

            ValidaNomeUsuario();
        }

        private void ValidaNomeUsuario()
        {
            if (_usuarioDB.GetLogin(txbUsuario.Text))
            {
                lblUsuario.Text = "* Nome de usuario já esta sendo usado";
                lblUsuario.Visible = true;
                _estaOK = false;
                return;
            }

            ValidaTamanhoSenha();
        }

        private void ValidaTamanhoSenha()
        {
            if (txbSenha.Text.Length < 8)
            {
                lblSenha.Text = "* Senha precisa ter no minímo 8 caracteres";
                lblSenha.Visible = true;
                _estaOK = false;
                return;
            }

            ValidaConfirmacaoSenha();
        }

        private void ValidaConfirmacaoSenha()
        {
            if (txbSenha.Text != txbRepitaSenha.Text)
            {
                lblConfirmaSenha.Text = "* Senhas não conferem";
                lblConfirmaSenha.Visible = true;
                _estaOK = false;                
            }            
        }
    }
}
