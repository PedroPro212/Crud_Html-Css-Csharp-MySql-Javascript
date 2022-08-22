using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Empresa.Negocio
{
    public  class Produto
    {
        private MySqlConnection connection;
        public Produto()
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
        }

        public Classes.Produto Read(string id)
        {
            return this.Read(id, "", "", "").FirstOrDefault();
        }
        public List<Classes.Produto> Read(string id, string descricao, string estoque, string valor)
        {
            var produtos = new List<Classes.Produto>();

            try
            {
                connection.Open();
                var comando = new MySqlCommand($"SELECT descricao, estoque, valor, id FROM produto WHERE (1=1)", connection);
                if(descricao.Equals("") == false)
                {
                    comando.CommandText += $" AND descricao like @descricao";
                    comando.Parameters.Add(new MySqlParameter("descricao", $"%{descricao}%"));
                }
                if(estoque.Equals("") == false)
                {
                    comando.CommandText += $" AND estoque = @estoque";
                    comando.Parameters.Add(new MySqlParameter("estoque", estoque));
                }
                if(valor.Equals("") == false)
                {
                    comando.CommandText += $" AND valor = @valor";
                    valor = 0.ToString("C");
                    comando.Parameters.Add(new MySqlParameter("valor", valor));
                }
                if(id.Equals("") == false)
                {
                    comando.CommandText += $" AND id = @id";
                    comando.Parameters.Add(new MySqlParameter("id", id));
                }
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var temp = valor;
                    produtos.Add(new Classes.Produto
                    {
                        Descricao = reader.GetString("descricao"),
                        Estoque = reader.GetInt32("estoque"),
                        Valor = reader.GetFloat("valor"),
                        Id = reader.GetInt32("id"),
                    });
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return produtos;
        }

        public bool Create(Classes.Produto produto)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($"INSERT INTO produto(descricao, estoque, valor) VALUE (@descricao, @estoque, @valor)", connection);
                comando.Parameters.Add(new MySqlParameter("descricao", produto.Descricao));
                comando.Parameters.Add(new MySqlParameter("estoque", produto.Estoque));
                comando.Parameters.Add(new MySqlParameter("valor", produto.Valor));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool UPDATE(Classes.Produto produto)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($"UPDATE produto SET Descricao = @descricao, Estoque = @estoque, Valor = @valor WHERE Id = @id", connection);
                comando.Parameters.Add(new MySqlParameter("descricao", produto.Descricao));
                comando.Parameters.Add(new MySqlParameter("estoque", produto.Estoque));
                comando.Parameters.Add(new MySqlParameter("valor", produto.Valor));
                comando.Parameters.Add(new MySqlParameter("Id", produto.Id));
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                connection.Open();
                var comando = new MySqlCommand($"DELETE FROM produto WHERE Id = " + id, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

    }

}