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
        public bool AtualizaContato(Contato contato)
        {
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "UPDATE contato SET nome = @nome, sobrenome = @sobrenome WHERE idCOntato = @idContato;";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", contato.Nome);
                        command.Parameters.AddWithValue("@sobrenome", contato.Sobrenome);
                        command.Parameters.AddWithValue("@idContato", contato.IdContato);
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

        public List<Contato> GetContato(int id)
        {
            List<Contato> listaContato = new List<Contato>();
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "SELECT idContato, nome, sobrenome, idUsuario FROM contato WHERE idUsuario = @idUsuario;";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaContato.Add(new Contato
                                {
                                    IdContato = reader.GetInt32("idContato"),
                                    Nome = reader.GetString("nome"),
                                    Sobrenome = reader.GetString("sobrenome"),
                                    idUsuario = reader.GetInt32("idUsuario")
                                });
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

        public bool NovoContato(Contato contato)
        {
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "INSERT INTO contato VALUES(0, @nome, @sobrenome, @idUsuario);";

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
