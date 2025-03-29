using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUsuarioDB
    {
        bool RegistraUsuario(Usuario usuario);

        bool GetLogin(string login);
    }
}
