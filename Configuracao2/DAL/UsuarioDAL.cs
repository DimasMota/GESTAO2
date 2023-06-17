
using Models;
using System;
using System.Collections.Generic;
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
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message) { Data = { { "Id", 01 } } };


            }
            finally
            {
                cn.Close();
            }


        }
        //*******************************************************************************************************************
        //*******************************************************************************************************************

        public bool ExisteRelacionamento(int _idUsuario, int _idGrupo)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM Grupo_com_Usuario_N_N  WHERE cod_usuario = @codUsuario AND cod_GrupoUsuario = @codGrupo ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@codUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@codGrupo", _idGrupo);
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

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message) { Data = { { "Id", 02 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        //*******************************************************************************************************************
        public void AdicionarGrupo(int _id_usuario, int _id_grupo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Grupo_com_Usuario_N_N (cod_usuario, cod_GrupoUsuario)" +
                                  "VALUES (@cod_usuario, @cod_grupousuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cod_usuario", _id_usuario);
                cmd.Parameters.AddWithValue("@cod_grupousuario", _id_grupo);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message) { Data = { { "Id", 03 } } };


            }
            finally
            {
                cn.Close();
            }

        }

        //*******************************************************************************************************************


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
                        GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupousuarioDAL.BuscarTodos_GruposPorUsuario(usuario.Id);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message) { Data = { { "Id", 04 } } };
            }
            finally
            {
                cn.Close();
            }

        }




        public Usuario BuscarUsuarioPorNome(string _nome)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id_Usuario, nome, nome_Usuario, data_Nascimento, cpf_Usuario, email, ativo FROM Usuario  WHERE UPPER (nome) LIKE UPPER (@nome)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", "%"+_nome+"%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id_Usuario"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["nome_Usuario"].ToString();
                        usuario.DataNascimento = rd["data_Nascimento"].ToString();
                        usuario.Cpf = rd["cpf_Usuario"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ativo"]);
                        GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupousuarioDAL.BuscarTodos_GruposPorUsuario(usuario.Id);


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.") ;
                    }
                    return usuario;

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message) { Data = { { "Id", 05 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        //******************************************************************************************************

        public Usuario BuscarUsuarioPorId(int _id)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id_Usuario, nome, nome_Usuario, data_Nascimento, cpf_Usuario, email,senha, ativo FROM Usuario  WHERE id_Usuario = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id_Usuario"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["nome_Usuario"].ToString();
                        usuario.DataNascimento = rd["data_Nascimento"].ToString();
                        usuario.Cpf = rd["cpf_Usuario"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Senha = rd["senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ativo"]);
                        GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupousuarioDAL.BuscarTodos_GruposPorUsuario(usuario.Id);
                        ;

                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.") ;
                    }
                    return usuario;

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message) { Data = { { "Id", 06 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        //******************************************************************************************************

        public Usuario BuscarPorNomeAcesso(string _nome)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id_Usuario, nome, nome_Usuario, data_Nascimento, cpf_Usuario, email, ativo, senha FROM Usuario  WHERE nome_Usuario = @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["id_Usuario"]);
                        usuario.Nome = rd["nome"].ToString();
                        usuario.NomeUsuario = rd["nome_Usuario"].ToString();
                        usuario.DataNascimento = rd["data_Nascimento"].ToString();
                        usuario.Cpf = rd["cpf_Usuario"].ToString();
                        usuario.Email = rd["email"].ToString();
                        usuario.Senha = rd["senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["ativo"]);
                        GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
                        usuario.GrupoUsuarios = grupousuarioDAL.BuscarTodos_GruposPorUsuario(usuario.Id);


                    }
                    else
                    {
                        throw new Exception("Usuario não encontrado.");
                    }
                    return usuario;

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários: " + ex.Message) { Data = { { "Id", 07 } } };
            }
            finally
            {
                cn.Close();
            }
        }


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
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message) { Data = { { "Id", 08 } } };


            }
            finally
            {
                cn.Close();
            }

        }
/*
        public void Excluir(Usuario _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {


                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id_Usuario= @id", cn))
                {


                    cmd.Connection = cn;

                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", _id.Id);

                    try
                    {
                        if (_transaction == null)
                        {

                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverTodasPermissoes(_idGrupoUsuario)
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    cmd.ExecuteScalar();

                }
            }



        }
*/
       
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
                        throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message) { Data = { { "Id", 09 } } };


                    }
                    finally
                    {
                        cn.Close();
                    }

                }
        

        public void RemoverGrupoUsuario(int _id_usuario, int _id_grupo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Grupo_com_Usuario_N_N WHERE  cod_usuario = @cod_usuario AND cod_GrupoUsuario = @cod_grupousuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cod_usuario", _id_usuario);
                cmd.Parameters.AddWithValue("@cod_grupousuario", _id_grupo);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message) { Data = { { "Id", 10 } } };


            }
            finally
            {
                cn.Close();
            }
        }
        public bool ValidarPermissao(int _idUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT TOP 1 1 AS Resultado FROM Grupo_com_Usuario_N_N " +
                                  "INNER JOIN Permissao_com_Grupo ON Grupo_com_Usuario_N_N.cod_GrupoUsuario = Permissao_com_Grupo.cod_GrupoUsuario " +
                                  "WHERE Grupo_com_Usuario_N_N.cod_Usuario = @Id_Usuario AND Permissao_com_Grupo.cod_Permissao = @Id_Permissao";

                cmd.Parameters.AddWithValue("@Id_Usuario", _idUsuario);
                cmd.Parameters.AddWithValue("@Id_Permissao", _idPermissao);

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
                throw new Exception("Ocorreu um erro ao tentar validar permissão do usuário: " + ex.Message) { Data = { { "Id", 11 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public bool NomeUsuario_Existe(string _nomeUsuario)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT TOP 1 1 AS Resultado FROM Usuario WHERE nome_Usuario = @nome";

                cmd.Parameters.AddWithValue("@nome", _nomeUsuario);
             

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
                throw new Exception("Ocorreu um erro ao tentar validar permissão do usuário: " + ex.Message) { Data = { { "Id", 12 } } };
            }
            finally
            {
                cn.Close();
            }
        }

    }


}