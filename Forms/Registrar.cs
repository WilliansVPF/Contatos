using Interfaces;
using Models;
using Repository;
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

        public Registrar(IUsuarioDB usuarioDB)
        {
            _usuarioDB = usuarioDB;
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != txbRepitaSenha.Text)
            {
                MessageBox.Show("Repita a mesma senha!");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nome = txbNome.Text,
                Login = txbUsuario.Text,
                Senha = txbSenha.Text,
                Salt = "123"
            };

            if (!_usuarioDB.RegistraUsuario(usuario))
            {
                MessageBox.Show("Erro inesperado ao registrar usuario");
                return;
            }

            this.Close();            

        }
    }
}
