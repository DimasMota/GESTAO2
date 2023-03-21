
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length < 4 || _permissao.Descricao.Length > 145)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 145 caracteres ");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }

        public List<Permissao> BuscarTodasPermissoes()
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarTodasPermissoes();
        }

        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Descricao.Length < 4 || _permissao.Descricao.Length > 145)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 145 caracteres ");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);

        }
        public void Excluir(Permissao _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_id);
        }

        public List<Permissao> BuscarPermissao_PorNome(string _nomePermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPermissao_PorNome(_nomePermissao);
        }

        public List<Permissao> BuscarTodasPermissoes_PorId(int _idPermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarTodasPermissoes_PorId(_idPermissao);
        }
    }
}