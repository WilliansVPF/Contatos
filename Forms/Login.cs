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
        private bool _estaAutenticado = false;

        public Login()
        {
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
            Registrar registrar = new Registrar();
            registrar.ShowDialog();
        }
    }
}
