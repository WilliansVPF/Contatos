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
    public class UsuarioDB : IUsuarioDB
    {
        public bool GetLogin(string login)
        {
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "SELECT EXISTS (SELECT 1 FROM Usuario WHERE login = @login);";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        int i = Convert.ToInt32(command.ExecuteScalar());
                        if (i == 0)
                        {
                            return false;
                        }
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RegistraUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = Conexao.GetConnection)
                {
                    connection.Open();
                    string sql = "INSERT INTO usuario VALUES(0, @login,  @nome, @senha, @salt)";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@login", usuario.Login);
                        command.Parameters.AddWithValue("@nome", usuario.Nome);
                        command.Parameters.AddWithValue("@senha", usuario.Senha);
                        command.Parameters.AddWithValue("@salt", usuario.Salt);
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
