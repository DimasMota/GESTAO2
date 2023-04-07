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
                        if(pessoa.RG == null)
                        {
                            pessoa.RG = "";
                        }
                        pessoa.OrgaoExpedidorRG = rd["OrgaoExpedidorRG"].ToString();
                        if(pessoa.OrgaoExpedidorRG == null)
                        {
                            pessoa.OrgaoExpedidorRG = "";
                        }
                        pessoa.cod_EstadoRG = Convert.ToInt32(rd["cod_EstadoRG"]);
                        if(pessoa.cod_EstadoRG == null)
                        {
                            pessoa.cod_EstadoRG = 0;
                        }
                        pessoa.DataExpedicaoRG = rd["DataExpedicaoRG"].ToString();
                        if(pessoa.DataExpedicaoRG == null)
                        {
                            pessoa.DataExpedicaoRG = "";
                        }
                        pessoa.Email = rd["Email"].ToString();
                        if(pessoa.Email == null)
                        {
                            pessoa.Email = "";
                        }
                       
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
