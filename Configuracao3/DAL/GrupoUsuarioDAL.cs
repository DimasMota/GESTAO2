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
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = permissaoDAL.BuscarTodasPermissoes_PorId(grupousuario.Id);

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
                cmd.CommandText = "SELECT id_GrupoUsuario, NomeGrupo FROM GrupoUsuario WHERE UPPER(NomeGrupo) like UPPER(@nome)";
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
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = permissaoDAL.BuscarTodasPermissoes_PorId(grupousuario.Id);

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
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = permissaoDAL.BuscarTodasPermissoes_PorId(grupousuario.Id);

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
                        PermissaoDAL permissaoDAL = new PermissaoDAL();
                        grupousuario.Permissoes = permissaoDAL.BuscarTodasPermissoes_PorId(grupousuario.Id);

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
        public List<GrupoUsuario> BuscarGrupoPor_Id(int _id)
        {
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
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

                        grupousuarios.Add(grupousuario);
                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return grupousuarios;

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

        public List<GrupoUsuario> BuscarGrupoPor_IdPermissao(int _idPermissao)
        {
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT GU.id_GrupoUsuario, GU.NomeGrupo FROM Permissao P INNER JOIN Permissao_com_Grupo PG ON P.id_Permissao = PG.cod_Permissao " +
                                  "INNER JOIN GrupoUsuario GU ON PG.cod_GrupoUsuario = GU.id_GrupoUsuario WHERE id_Permissao = @idpermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idpermissao", _idPermissao);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                        while (rd.Read())
                        {
                            grupousuario = new GrupoUsuario();
                            grupousuario.Id = Convert.ToInt32(rd["id_GrupoUsuario"]);
                            grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                            grupousuarios.Add(grupousuario);
                        }
                    return grupousuarios;
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

        public bool Existe_VinculoPermissao(GrupoUsuario _id)
        {
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM Permissao_com_Grupo  WHERE cod_GrupoUsuario = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id.Id);
             
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
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

        public void VincularPermissaoGrupo(int _idGrupo, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Permissao_com_Grupo (cod_Permissao, cod_GrupoUsuario)" +
                                  "VALUES (@cod_permissao, @cod_grupousuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cod_permissao", _idPermissao);
                cmd.Parameters.AddWithValue("@cod_grupousuario", _idGrupo);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir Permissão em Grupo no banco " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void RemoverVinculoGrupoPermissao(int _id_Grupo, int _id_Permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Permissao_com_Grupo WHERE  cod_Permissao = @cod_permissao AND cod_GrupoUsuario=@cod_grupousuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cod_permissao", _id_Permissao);
                cmd.Parameters.AddWithValue("@cod_grupousuario", _id_Grupo);
                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir Permissão em Grupo no banco " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}