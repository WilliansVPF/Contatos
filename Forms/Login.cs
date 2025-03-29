using Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
        private bool _estaAutenticado = false;

        public Login(IServiceProvider serviceProvider, IUsuarioDB usuarioDB)
        {
            _usuarioDB = usuarioDB;
            InitializeComponent();            
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text.Equals("willians", StringComparison.OrdinalIgnoreCase) && txbSenha.Text == "123")
            {
                _estaAutenticado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Falha");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaAutenticado)
            {
                Application.Exit();
            }
        }

        private void lbRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var registrar = _serviceProvider.GetRequiredService<Registrar>();
            var registrar = new Registrar(_usuarioDB);
            registrar.ShowDialog();
        }
    }
}
