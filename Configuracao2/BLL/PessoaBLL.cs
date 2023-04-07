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
        public List<Pessoa> BuscarTodos()

        {
           PessoaDAL pessoaDAL = new PessoaDAL();
            return pessoaDAL.BuscarTodos();
        }
    }
}
