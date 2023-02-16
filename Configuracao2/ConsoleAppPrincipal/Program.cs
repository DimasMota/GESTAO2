using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
        
            try 
	        {
                int sim_nao;

                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
               
                Console.WriteLine("Cadastrar outro usuário: [1] SIM [2] NÃO ");
                sim_nao = Convert.ToInt32(Console.ReadLine());

                while (sim_nao == 1)
                {

                    Console.WriteLine("Cadastro de Usuário\n\n");
                    Console.WriteLine("Nome Completo: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Nome de acesso do Usuário");
                    usuario.NomeUsuario = Console.ReadLine();
                    Console.WriteLine("Data de Nascimento");
                    usuario.DataNascimento = Console.ReadLine();
                    Console.WriteLine("CPF do Usuário: ");
                    usuario.Cpf = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    usuario.Senha = Console.ReadLine();
                    Console.WriteLine("Digite seu E_mail");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Usuario Ativo [S]SIM  [N]NÃO :");
                    usuario.Ativo = Console.ReadLine().ToUpper() == "S";

                    usuarioBLL.Inserir(usuario);
                    Console.WriteLine("Cadastrar outro usuário: [1] SIM [2] NÃO ");
                    sim_nao = Convert.ToInt32(Console.ReadLine());

                } 

	        }
	        catch (Exception ex )
	        {

                Console.WriteLine(ex.Message);
	        }
        }
    }
}