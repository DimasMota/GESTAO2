using System;
using System.Collections.Generic;
namespace Models
{
    public class Usuario
    {
    
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int Id { get; set; }
        public string Funcao { get; set; }
        public string Cargo { get; set; }
        public int Cod_Pessoa { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }
        public List<Pessoa> Pessoas { get; set; }



    }
}