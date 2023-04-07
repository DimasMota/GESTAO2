using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cidade
    {
        public int Id_Cidade { get; set; }
        public string NomeCidade { get; set; }
        public int Cod_Estado { get; set; }
        public List<Estado> Estados { get; set; }
    }
}
