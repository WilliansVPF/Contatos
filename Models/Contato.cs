using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public int idUsuario { get; set; }

        public List<EnderecoContato> EnderecosContato { get;}
    }
}
