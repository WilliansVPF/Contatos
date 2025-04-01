using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class UsuarioLogado
    {
        private static UsuarioLogado instance;

        public int Id { get; private set; }
        public string Usuario { get; private set; }
        public bool EstaLogado { get; set; }

        public static UsuarioLogado ObterInstancia()
        {
            if (instance == null)
            {
                instance = new();
            }
            return instance;
        }

        public void Login(int id, string usuario)
        {
            Id = id;
            Usuario = usuario;
            EstaLogado = true;
        }

        public void Logout()
        {
            Id = 0;
            Usuario = string.Empty;
        }
    }
}
