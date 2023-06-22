using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedorBLL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            List<Fornecedor> fornecedor = new FornecedorDAL().BuscarPorNome(_fornecedor.Nome);

           if(fornecedor.Count != 0)
            {
                throw new Exception("Fornecedor cadastrado com esse nome");
            }
            
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            fornecedorDAL.Inserir(_fornecedor);

        }
        public List<Fornecedor> BuscarTodos()
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            List<Fornecedor> fornecedor = fornecedorDAL.BuscarTodos();
            if(fornecedor.Count == 0)
            {
                throw new Exception("Fornecedor não encontrado!");
            }
            return fornecedor;

        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            List<Fornecedor> fornecedor = fornecedorDAL.BuscarPorNome(_nome);
            if (fornecedor.Count == 0)
            {
                throw new Exception("Fornecedor não encontrado");
            }
            return fornecedor;
        }
        public Fornecedor BuscarPorId(int _id)
        {
           FornecedorDAL fornecedorDAL = new FornecedorDAL();
           Fornecedor fornecedor =  fornecedorDAL.BuscarPorId(_id);
            if(fornecedor.Id == 0)
            {
                throw new Exception("Fornecedor não encontrado");
            }
            return fornecedor;
        }
        public List<Fornecedor> BuscarPorSite(string _site)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            List<Fornecedor> fornecedor = fornecedorDAL.BuscarPorSite(_site);
            if(fornecedor.Count == 0)
            {
                throw new Exception("Fornecedor não encontrado");
            }
            return fornecedor;
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alterar(_fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
      
    }
}
