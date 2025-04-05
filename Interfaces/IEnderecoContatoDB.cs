using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEnderecoContatoDB
    {
        bool NovoEnderecoContato(EnderecoContato enderecoContato);

        List<EnderecoContato> GetEnderecosContato(int id);
    }
}
