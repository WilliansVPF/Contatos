using Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class Login : Form
    {
        private readonly IUsuarioDB _usuarioDB;

        public Login(IUsuarioDB usuarioDB)
        {
            _usuarioDB = usuarioDB;
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = _usuarioDB.GetUsuario(txbLogin.Text);

            if (usuario == null)
            {
                lblErro1.Visible = true;
                lblErro2.Visible = true;
                return;
            }

            string senha = GeraHash.Hash(txbSenha.Text, usuario.Salt);
            //senha = usuario.Salt + senha;
            //senha  = GeraHash.Hash(senha);

            if (senha != usuario.Senha)
            {
                lblErro1.Visible = true;
                lblErro2.Visible = true;
                return;
            }

            var sessao = UsuarioLogado.ObterInstancia();
            sessao.Login(usuario.IdUsuario, usuario.Login);

            this.Close();
                        
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sessao = UsuarioLogado.ObterInstancia();
            if (!sessao.EstaLogado) Application.Exit();
        }

        private void lbRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var registrar = _serviceProvider.GetRequiredService<Registrar>();
            var registrar = new Registrar(_usuarioDB);
            registrar.ShowDialog();
        }
    }
}
