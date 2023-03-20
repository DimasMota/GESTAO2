﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Permissao(Descricao)" +
                                  "VALUES (@descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);


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

        public List<Permissao> BuscarTodasPermissoes()
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_Permissao, Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["id_Permissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        int _id = permissao.Id;
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarGrupoPor_IdPermissao(_id);

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
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

        public List<Permissao> BuscarTodasPermissoes_PorId(int _idGrupoUsuario)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT P.id_Permissao, P.Descricao FROM GrupoUsuario GU INNER JOIN Permissao_com_Grupo PG ON GU.id_GrupoUsuario = cod_GrupoUsuario INNER JOIN Permissao P ON PG.cod_Permissao = id_Permissao WHERE id_GrupoUsuario = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _idGrupoUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["id_Permissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();


                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
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
        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Permissao SET Descricao = @descricao WHERE id_Permissao = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@id", _permissao.Id);


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

        public void Excluir(Permissao _idPermissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Permissao WHERE id_Permissao= @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@id", _idPermissao.Id);


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

        public List<Permissao> BuscarPermissoes_PorNome(string _nomePermissao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id_Permissao, Descricao FROM Permissao WHERE Descricao = @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", "%" + _nomePermissao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["id_Permissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarGrupoPor_IdPermissao(permissao.Id);

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
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
    }
}