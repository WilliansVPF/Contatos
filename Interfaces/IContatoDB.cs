using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IContatoDB
    {
        List<Contato> GetContato(int id);

        bool NovoContato(Contato contato, int idUsuario);
    }
}
