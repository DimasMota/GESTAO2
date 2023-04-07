using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pais
    {
        public int Id_Pais { get; set; }
        public string NomePais { get; set; }
        public List<Estado> Estados { get; set; }
    }
}
