﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Alterar(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length < 4 || _grupousuario.NomeGrupo.Length > 46)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 46 caracteres ");
            }

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Inserir(_grupousuario);



        }
        public void Excluir(int _idGrupoUsuario)
        {

        }
    }
}
