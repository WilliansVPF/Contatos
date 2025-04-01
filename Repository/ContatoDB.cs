using Interfaces;
using Microsoft.VisualBasic;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContatoDB : IContatoDB
    {
        public List<Contato> GetContato(int id)
        {
            List<Contato> listaContato = new List<Contato>();
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "SELECT idContato, nome, idUsuario FROM contato WHERE idUsuario = @idUsuario;";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Contato contato = new Contato
                                {
                                    IdContato = reader.GetInt32("idContato"),
                                    Nome = reader.GetString("nome"),
                                    Sobrenome = reader.GetString("sobrenome"),
                                    idUsuario = reader.GetInt32("idUsuario")
                                };
                                listaContato.Add(contato);
                            }                            
                            return listaContato;
                        }
                    }
                }
            }
            catch 
            {
                return null;
            }
        }

        public bool NovoContato(Contato contato, int idUsuario)
        {
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "INSERT INTO contato VALUES(0, @nome, @sobrenome, @idUsuairo);";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", contato.Nome);
                        command.Parameters.AddWithValue("@sobrenome", contato.Sobrenome);
                        command.Parameters.AddWithValue("@idUsuario", contato.idUsuario);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        
    }
}
