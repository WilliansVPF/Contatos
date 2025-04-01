using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class GeraHash
    {
        public static string Salt => BCrypt.Net.BCrypt.GenerateSalt();
        public static string Hash(string valor, string salt) => BCrypt.Net.BCrypt.HashPassword(valor, salt);
    }
}
