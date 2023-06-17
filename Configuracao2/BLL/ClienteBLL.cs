using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.Inserir(_cliente);

        }
        public List<Cliente> BuscarTodos()
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.BuscarTodos();
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.BuscarPorNome(_nome);
        }
        public Cliente BuscarPorId(int _id)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.BuscarPorId(_id);
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.BuscarPorCPF(_CPF);
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }

        public bool Existe_Cliente()
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.Existe_Cliente();
        }
    }
}
