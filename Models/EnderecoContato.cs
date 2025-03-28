using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EnderecoContato
    {
        public int IdEnderecoContato { get; set; }
        public string Valor { get; set; }
        public bool Principal { get; set; }
        public string Observacao { get; set; }
        public int IdTipoContato { get; set; }
        public int IdContato { get; set; }
    }
}
