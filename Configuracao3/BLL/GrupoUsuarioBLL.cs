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

        //**************************************************************************************


        public List<GrupoUsuario> BuscarGrupoPor_Id(int _id)
        {

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPor_Id(_id);

        }

        public List<GrupoUsuario> BuscarGrupoPor_IdPermissao(int _idPermissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPor_Id(_idPermissao);
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
            if (new GrupoUsuarioDAL().Existe_VinculoPermissao(_id))
            {
                throw new Exception("Exclua primeiro as Permissões do grupo.");
            }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Excluir(_id);
        }

        public void VincularPermissaoGrupo(int _idGrupo, int _idPermissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.VincularPermissaoGrupo(_idGrupo, _idPermissao);
        }

        public void RemoverVinculoGrupoPermissao(int _id_Grupo, int _id_Permissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.RemoverVinculoGrupoPermissao(_id_Grupo, _id_Permissao);
        }
    }
}