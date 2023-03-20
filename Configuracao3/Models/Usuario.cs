using System.Collections.Generic;
namespace Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int Id { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }


    }
}