using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco
    {
        public int Id_Endereco { get; set; }
        public string TipoLogradouro { get; set; }
        public string NomeLogradouro { get; set; }
        public string NumeroCasa { get; set; }
        public string Quadra { get; set; }
        public string Lote { get; set; }
        public string CEP { get; set; }
        public int Cod_Cidade { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}
