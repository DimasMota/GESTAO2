using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int Id_Pessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public  string OrgaoExpedidorRG { get; set; }
        public int cod_EstadoRG { get; set; }
        public string DataExpedicaoRG { get; set; }
        public int cod_Endereco { get; set; }
        public string Email { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
