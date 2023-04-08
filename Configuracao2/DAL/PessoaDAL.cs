using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PessoaDAL
    {
        public Pessoa BuscarPessoaPor_CPF(string _cpfPessoa)
        {
            Pessoa pessoa = new Pessoa();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pessoa, Nome, Sobrenome, DataDeNascimento, CPF, RG, OrgaoExpedidorRG, cod_EstadoRG,DataExpedicaoRG, Email FROM Pessoa WHERE CPF = @cpf";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cpf", _cpfPessoa);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.Id_Pessoa = Convert.ToInt32(rd["Id_Pessoa"]);
                        pessoa.Nome = rd["Nome"].ToString();
                        pessoa.Sobrenome = rd["Sobrenome"].ToString();
                        pessoa.DataDeNascimento = rd["DataDeNascimento"].ToString();
                        pessoa.CPF = rd["CPF"].ToString();
                        pessoa.RG = rd["RG"].ToString();
                        if (pessoa.RG == null)
                        {
                            pessoa.RG = "";
                        }
                        pessoa.OrgaoExpedidorRG = rd["OrgaoExpedidorRG"].ToString();
                        if (pessoa.OrgaoExpedidorRG == null)
                        {
                            pessoa.OrgaoExpedidorRG = "";
                        }

                        if (Convert.ToString(rd["cod_EstadoRG"]) == "")
                        {
                            pessoa.cod_EstadoRG = 0;
                        }
                        else
                        {
                            pessoa.cod_EstadoRG = Convert.ToInt32(rd["cod_EstadoRG"]);
                        }
                        pessoa.DataExpedicaoRG = rd["DataExpedicaoRG"].ToString();
                        if (pessoa.DataExpedicaoRG == null)
                        {
                            pessoa.DataExpedicaoRG = "";
                        }
                        pessoa.Email = rd["Email"].ToString();
                        if (pessoa.Email == null)
                        {
                            pessoa.Email = "";
                        }
                        UsuarioDAL usuarioDAL = new UsuarioDAL();
                        pessoa.Usuarios = usuarioDAL.BuscarTodos_PorId(pessoa.Id_Pessoa);


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return pessoa;

                }
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

        public Pessoa BuscarPessoaPor_ID(int _idPessoa)
        {
            Pessoa pessoa = new Pessoa();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pessoa, Nome, Sobrenome, DataDeNascimento, CPF, RG, OrgaoExpedidorRG, cod_EstadoRG,DataExpedicaoRG, Email FROM Pessoa WHERE Id_Pessoa = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _idPessoa);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.Id_Pessoa = Convert.ToInt32(rd["Id_Pessoa"]);
                        pessoa.Nome = rd["Nome"].ToString();
                        pessoa.Sobrenome = rd["Sobrenome"].ToString();
                        pessoa.DataDeNascimento = rd["DataDeNascimento"].ToString();
                        pessoa.CPF = rd["CPF"].ToString();
                        pessoa.RG = rd["RG"].ToString();
                        if (pessoa.RG == null)
                        {
                            pessoa.RG = "";
                        }
                        pessoa.OrgaoExpedidorRG = rd["OrgaoExpedidorRG"].ToString();
                        if (pessoa.OrgaoExpedidorRG == null)
                        {
                            pessoa.OrgaoExpedidorRG = "";
                        }

                        if (Convert.ToString(rd["cod_EstadoRG"]) == "")
                        {
                            pessoa.cod_EstadoRG = 0;
                        }
                        else
                        {
                            pessoa.cod_EstadoRG = Convert.ToInt32(rd["cod_EstadoRG"]);
                        }
                        pessoa.DataExpedicaoRG = rd["DataExpedicaoRG"].ToString();
                        if (pessoa.DataExpedicaoRG == null)
                        {
                            pessoa.DataExpedicaoRG = "";
                        }
                        pessoa.Email = rd["Email"].ToString();
                        if (pessoa.Email == null)
                        {
                            pessoa.Email = "";
                        }
                        UsuarioDAL usuarioDAL = new UsuarioDAL();
                        pessoa.Usuarios = usuarioDAL.BuscarTodos_PorId(pessoa.Id_Pessoa);


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return pessoa;

                }
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

        public List<Pessoa> BuscarTodos()

        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa pessoa;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pessoa, Nome, Sobrenome, DataDeNascimento, CPF, RG, OrgaoExpedidorRG, cod_EstadoRG,DataExpedicaoRG, Email FROM Pessoa";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.Id_Pessoa = Convert.ToInt32(rd["Id_Pessoa"]);
                        pessoa.Nome = rd["Nome"].ToString();
                        pessoa.Sobrenome = rd["Sobrenome"].ToString();
                        pessoa.DataDeNascimento = rd["DataDeNascimento"].ToString();
                        pessoa.CPF = rd["CPF"].ToString();
                        pessoa.RG = rd["RG"].ToString();
                        if (pessoa.RG == null)
                        {
                            pessoa.RG = "";
                        }
                        pessoa.OrgaoExpedidorRG = rd["OrgaoExpedidorRG"].ToString();
                        if (pessoa.OrgaoExpedidorRG == null)
                        {
                            pessoa.OrgaoExpedidorRG = "";
                        }

                        if (Convert.ToString(rd["cod_EstadoRG"]) == "")
                        {
                            pessoa.cod_EstadoRG = 0;
                        }
                        else
                        {
                            pessoa.cod_EstadoRG = Convert.ToInt32(rd["cod_EstadoRG"]);
                        }
                        pessoa.DataExpedicaoRG = rd["DataExpedicaoRG"].ToString();
                        if (pessoa.DataExpedicaoRG == null)
                        {
                            pessoa.DataExpedicaoRG = "";
                        }
                        pessoa.Email = rd["Email"].ToString();
                        if (pessoa.Email == null)
                        {
                            pessoa.Email = "";
                        }
                        UsuarioDAL usuarioDAL = new UsuarioDAL();
                        pessoa.Usuarios = usuarioDAL.BuscarTodos_PorId(pessoa.Id_Pessoa);

                        pessoas.Add(pessoa);
                    }
                }
                return pessoas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todas as pessoas no Banco de Dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Pessoa> BuscarTodosPessoaPor_Nome(string _nomePessoa)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa pessoa;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pessoa, Nome, Sobrenome, DataDeNascimento, CPF, RG, OrgaoExpedidorRG, cod_EstadoRG,DataExpedicaoRG, Email FROM Pessoa WHERE UPPER (Nome) LIKE UPPER(@nome) OR UPPER(Sobrenome) LIKE UPPER(@nome)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome","%"+ _nomePessoa+"%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.Id_Pessoa = Convert.ToInt32(rd["Id_Pessoa"]);
                        pessoa.Nome = rd["Nome"].ToString();
                        pessoa.Sobrenome = rd["Sobrenome"].ToString();
                        pessoa.DataDeNascimento = rd["DataDeNascimento"].ToString();
                        pessoa.CPF = rd["CPF"].ToString();
                        pessoa.RG = rd["RG"].ToString();
                        if (pessoa.RG == null)
                        {
                            pessoa.RG = "";
                        }
                        pessoa.OrgaoExpedidorRG = rd["OrgaoExpedidorRG"].ToString();
                        if (pessoa.OrgaoExpedidorRG == null)
                        {
                            pessoa.OrgaoExpedidorRG = "";
                        }

                        if (Convert.ToString(rd["cod_EstadoRG"]) == "")
                        {
                            pessoa.cod_EstadoRG = 0;
                        }
                        else
                        {
                            pessoa.cod_EstadoRG = Convert.ToInt32(rd["cod_EstadoRG"]);
                        }
                        pessoa.DataExpedicaoRG = rd["DataExpedicaoRG"].ToString();
                        if (pessoa.DataExpedicaoRG == null)
                        {
                            pessoa.DataExpedicaoRG = "";
                        }
                        pessoa.Email = rd["Email"].ToString();
                        if (pessoa.Email == null)
                        {
                            pessoa.Email = "";
                        }
                        UsuarioDAL usuarioDAL = new UsuarioDAL();
                        pessoa.Usuarios = usuarioDAL.BuscarTodos_PorId(pessoa.Id_Pessoa);

                        pessoas.Add(pessoa);
                    }
                }
                return pessoas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todas as pessoas no Banco de Dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
