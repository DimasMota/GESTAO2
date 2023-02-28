
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Usuario(nome, nome_Usuario, data_Nascimento, cpf_Usuario,senha,email, ativo)" +
                                  "VALUES (@nome, @nome_Usuario, @data_Nascimento, @cpf_Usuario, @senha, @email, @ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@nome_Usuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@data_Nascimento", _usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@cpf_Usuario", _usuario.Cpf);
                cmd.Parameters.AddWithValue("@senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@email", _usuario.Email);
                cmd.Parameters.AddWithValue("@ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }


        }


        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_Usuario, nome, nome_Usuario, data_Nascimento, cpf_Usuario, email, ativo FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id_Usuario"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["nome_Usuario"].ToString();
                        usuario.DataNascimento = rd["data_Nascimento"].ToString();
                        usuario.Cpf = rd["cpf_Usuario"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ativo"]);

                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }


        /*

        public List<Usuario> BuscarUsuarioPorNome(string _nome, Usuario _usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id_Usuario, nome, nome_Usuario, data_Nascimento, cpf_Usuario, email, ativo FROM Usuario  WHERE UPPER(nome) LIKE'@nome %@nome%'";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id_Usuario"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["nome_Usuario"].ToString();
                        usuario.DataNascimento = rd["data_Nascimento"].ToString();
                        usuario.Cpf = rd["cpf_Usuario"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ativo"]);

                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        */

        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Usuario SET nome = @nome,nome_Usuario = @nome_Usuario,data_Nascimento = @data_Nascimento," +
                    "cpf_Usuario = @cpf_Usuario,senha = @senha,email = @email,ativo = @ativo WHERE id_Usuario = @id";


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@nome_Usuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@data_Nascimento", _usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@cpf_Usuario", _usuario.Cpf);
                cmd.Parameters.AddWithValue("@senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@email", _usuario.Email);
                cmd.Parameters.AddWithValue("@ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@id", _usuario.Id);

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }

        }

        public void Excluir(Usuario _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Usuario WHERE id_Usuario= @id";


                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@id", _id.Id);

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }

        }


    }


}