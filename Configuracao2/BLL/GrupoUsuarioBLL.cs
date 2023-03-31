using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {

        public void Inserir(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length < 4 || _grupousuario.NomeGrupo.Length > 46)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 46 caracteres ");
            }

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Inserir(_grupousuario);
        }

        public GrupoUsuario Buscar(string _grupo)
        {
            return new GrupoUsuario();
        }

        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarTodosGrupos();
            

        }
        public List<GrupoUsuario> BuscarTodosGrupos_PorNome(string _nome)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarTodosGrupos_PorNome(_nome);

        }

        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
          //  if (String.IsNullOrEmpty(_nome))
          //  {
          //      throw new Exception("Informe o nome do usuário");
          //  }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPorNome(_nomeGrupo);

        }

        //**************************************************************************************

        public List<GrupoUsuario> BuscarTodos_GruposPorUsuario(int _id)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarTodos_GruposPorUsuario(_id);
        }


        //**************************************************************************************


        public GrupoUsuario BuscarGrupoPor_Id(int _id)
        {

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPor_Id(_id);

        }



        public void Alterar(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length < 4 || _grupousuario.NomeGrupo.Length > 46)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 46 caracteres ");
            }

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Alterar(_grupousuario);



        }
        public void Excluir(GrupoUsuario _id)
        {
         //   if (new GrupoUsuarioDAL().ExisteVinculo_GrupoComUsuario(_id))
         //   {
        //        throw new Exception("Não é possível EXCLUIR este grupo \nTem Usuário com vínculo com este grupo.");
        //    }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Excluir(_id);
        }

        public void RemoverVinculoGrupoPermissao(int _id_grupo, int _id_permissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.RemoverVinculoGrupoPermissao( _id_grupo, _id_permissao);
        }

        public void VincularPermissaoGrupo(int _idGrupo, int _idPemrissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.VincularPermissaoGrupo( _idGrupo, _idPemrissao);
        }
    }
}