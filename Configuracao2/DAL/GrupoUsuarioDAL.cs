using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO GrupoUsuario(NomeGrupo)" +
                                  "VALUES (@nomegrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomegrupo", _grupousuario.NomeGrupo);


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

        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            List<GrupoUsuario> grupo_usuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_GrupoUsuario, NomeGrupo FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                        grupo_usuarios.Add(grupousuario);
                    }
                }
                return grupo_usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        //***********************************************************************************************************************
         public List<GrupoUsuario> BuscarTodosGrupos_PorNome(string _nome)
        {
            List<GrupoUsuario> grupo_usuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_GrupoUsuario, NomeGrupo FROM GrupoUsuario WHERE NomeGrupo like @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome","%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                        grupo_usuarios.Add(grupousuario);
                    }
                }
                return grupo_usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }


        //***********************************************************************************************************************

        public List<GrupoUsuario> BuscarTodos_GruposPorUsuario(int _id)
        {
            List<GrupoUsuario> vincular_usuario_grupos = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT  GU.id_GrupoUsuario,	GU.NomeGrupo FROM  Usuario U " +
                    "INNER JOIN Grupo_com_Usuario_N_N G ON U.id_Usuario = G.cod_usuario " +
                    "INNER JOIN GrupoUsuario GU ON G.cod_GrupoUsuario = GU.id_GrupoUsuario WHERE U.id_Usuario = @id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {

                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                        vincular_usuario_grupos.Add(grupousuario);

                    }

                }
                return vincular_usuario_grupos;
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


        //*********************************************************************************************************************
        public GrupoUsuario BuscarGrupoPorNome(string _nome)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_GrupoUsuario, NomeGrupo FROM GrupoUsuario WHERE NomeGrupo = @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return grupousuario;

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

        //****************************************************************************************************************************
        public GrupoUsuario BuscarGrupoPor_Id(int _id)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_GrupoUsuario, NomeGrupo FROM GrupoUsuario WHERE id_GrupoUsuario = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return grupousuario;

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

        //****************************************************************************************************************************


        public void Alterar(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE GrupoUsuario SET NomeGrupo = @nomegrupo WHERE id_GrupoUsuario = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomegrupo", _grupousuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@id", _grupousuario.Id);


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



        public void Excluir(GrupoUsuario _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM GrupoUsuario WHERE id_GrupoUsuario= @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _idGrupoUsuario.Id);


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