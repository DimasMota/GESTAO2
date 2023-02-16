﻿
using DAL;
using Models;

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

        public Permissao Buscar(string _descricao)
        {
            return new Permissao();
        }

        public void Alterar(Permissao _permissao)
        {

        }
        public void Excluir(int _id)
        {

        }
    }
}
