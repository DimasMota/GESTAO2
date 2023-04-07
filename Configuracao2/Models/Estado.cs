using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Estado
    {
        public int Id_Estado { get; set; }
        public string NomeEstado { get; set; }
        public string Sigla { get; set; }
        public int Cod_Pais { get; set; }
        public List<Pais> Paises { get; set; }
        public List<Cidade> Cidades { get; set;}
    }
}
