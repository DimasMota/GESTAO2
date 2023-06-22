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
            List<Cliente> cliente = clienteDAL.BuscarTodos();
            if(cliente.Count == 0)
            {
                throw new Exception("Cliente não encontrado");
            }
            return cliente;
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            List<Cliente> cliente = clienteDAL.BuscarPorNome(_nome);
            if (cliente.Count == 0)
            {
                throw new Exception("Cliente não encontrado-BLL ");
            }
            return cliente;
        }
        public Cliente BuscarPorId(int _id)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            Cliente cliente = clienteDAL.BuscarPorId(_id);
            if (cliente.Id == 0)
                throw new Exception("Cliente não encontrado");
            return cliente;
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            Cliente cliente = clienteDAL.BuscarPorCPF(_CPF);
            if (cliente.Id == 0)
                throw new Exception("Cliente não encontrado");
            return cliente;
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }
    }
}
