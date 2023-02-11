
using Models;
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
                cmd.CommandText = "INSERT INTO Usuario(nome, nome_Usuario, data_Nascimento, cpf_Usuario,senha,email, ativo) " +
                                  "VALUES (@nome, @nome_Usuario, @data_Nascimento, @cpf_Usuario, @senha, @email, @ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@nome_Usuario", _usuario.Nome);
                cmd.Parameters.AddWithValue("@data_Nascimento", _usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf_Usuario", _usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", _usuario.Nome);
                cmd.Parameters.AddWithValue("@email", _usuario.Nome);
                cmd.Parameters.AddWithValue("@ativo", _usuario.Nome);

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message );

               
            }
            finally
            {
                cn.Close();
            }


        }
        
        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

        }

        public void Excluir(int _id)
        {

        }

    }
}
