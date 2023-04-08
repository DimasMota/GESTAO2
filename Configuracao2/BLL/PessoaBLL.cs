using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PessoaBLL
    {
        public Pessoa BuscarPessoaPor_CPF(string _CPFPessoa)
        {
            PessoaDAL pessoaDAL = new PessoaDAL();
            return pessoaDAL.BuscarPessoaPor_CPF(_CPFPessoa);
        }

        public Pessoa BuscarPessoaPor_ID(int _idPessoa)
        {
            PessoaDAL pessoaDAL = new PessoaDAL();
            return pessoaDAL.BuscarPessoaPor_ID(_idPessoa);
        }

        public List<Pessoa> BuscarTodos()

        {
           PessoaDAL pessoaDAL = new PessoaDAL();
            return pessoaDAL.BuscarTodos();
        }

        public List<Pessoa> BuscarTodosPessoaPor_Nome(string _nomePessoa)
        {
            PessoaDAL pessoaDAL = new PessoaDAL();
            return pessoaDAL.BuscarTodosPessoaPor_Nome(_nomePessoa);
        }
    }
}
