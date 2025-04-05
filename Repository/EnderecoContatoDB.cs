using Interfaces;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EnderecoContatoDB : IEnderecoContatoDB
    {
        public List<EnderecoContato> GetEnderecosContato(int id)
        {
            List<EnderecoContato> lista = new List<EnderecoContato>();
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "SELECT idEnderecoContato, valor, observacao, idTipoContato FROM  enderecocontato WHERE idContato = @idContato;";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idContato", id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new EnderecoContato 
                                {
                                    IdEnderecoContato = reader.GetInt32("idEnderecoContato"),
                                    Valor = reader.GetString("valor"),
                                    Observacao = reader.GetString("observacao"),
                                    IdTipoContato = reader.GetInt32("idTipoContato")
                                });
                            }
                            return lista;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public bool NovoEnderecoContato(EnderecoContato enderecoContato)
        {
            throw new NotImplementedException();
        }
    }
}
