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


        public Usuario()
        {
            Console.WriteLine("Cadastro de Usuário\n\n");
            Console.WriteLine("Nome Completo: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Nome de acesso do Usuário");
            NomeUsuario = Console.ReadLine();
            Console.WriteLine("Data de Nascimento");
            DataNascimento = Console.ReadLine();
            Console.WriteLine("CPF do Usuário: ");
            Cpf = Console.ReadLine();
            Console.WriteLine("Senha:");
            Senha= Console.ReadLine();
            Console.WriteLine("Digite seu E_mail");
            Email = Console.ReadLine();
            Console.WriteLine("Usuario Ativo [S]SIM  [N]NÃO :");
            Ativo = Console.ReadLine().ToUpper() == "S";

        }
    }
}