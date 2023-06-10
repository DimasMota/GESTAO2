using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaisDAL
    {
        public void Inserir(string _nomepais)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Pais(NomePais)" +
                                  "VALUES (@nomepais)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomepais", _nomepais);
               


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Cliente no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }


        }
        public List<Pais> BuscarTodos_Pais()
        {
            List<Pais> paises = new List<Pais>();
           Pais pais;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pais, NomePais FROM Pais";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                   while (rd.Read())
                    {
                        pais = new Pais();
                        pais.Id_Pais = Convert.ToInt32(rd["Id_Pais"]);
                        pais.NomePais = rd["NomePais"].ToString();
                       


                        paises.Add(pais);
                    }
                   
                }
                return paises;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public List<Pais> BuscarPorNome_Pais(string _nomepais)
        {
            List<Pais> paises = new List<Pais>();
            Pais pais;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pais, NomePais FROM Pais WHERE UPPER (NomePais) LIKE UPPER (@nomepais)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomepais", "%" + _nomepais + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        pais = new Pais();
                        pais.Id_Pais = Convert.ToInt32(rd["Id_Pais"]);
                        pais.NomePais = rd["NomePais"].ToString();



                        paises.Add(pais);
                    }
                    else
                    {
                        throw new Exception("Cliente não encontrado.");
                    }
                }
                return paises;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Cliente: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Pais BuscarPorId_Pais(int _idpais)
        {
            Pais pais = new Pais();
           
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id_Pais, NomePais FROM Pais WHERE Id_Pais = @idpais";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idpais", _idpais);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        pais = new Pais();
                        pais.Id_Pais = Convert.ToInt32(rd["Id_Pais"]);
                        pais.NomePais = rd["NomePais"].ToString();



                       
                    }
                    else
                    {
                        throw new Exception("Cliente não encontrado.");
                    }
                }
                return pais;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool NomePais_Existe(string _nomePais)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT TOP 1 1 AS Resultado FROM Pais WHERE UPPER (NomePais) LIKE UPPER(@nome)";

                cmd.Parameters.AddWithValue("@nome", _nomePais);


                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissão do usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
