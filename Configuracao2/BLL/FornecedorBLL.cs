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
            


            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            fornecedorDAL.Inserir(_fornecedor);

        }
        public List<Fornecedor> BuscarTodos()
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.BuscarTodos();
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.BuscarPorNome(_nome);
        }
        public Fornecedor BuscarPorId(int _id)
        {
           FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.BuscarPorId(_id);
        }
        public List<Fornecedor> BuscarPorSite(string _site)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.BuscarPorSite(_site);
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alterar(_fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
        public bool Existe_Fornecedor(Fornecedor _fornecedor)
        {
            FornecedorDAL fornecedorDAL = new FornecedorDAL();
            return fornecedorDAL.Existe_Fornecedor(_fornecedor);
        }
            

}
}
