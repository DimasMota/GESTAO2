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
            
		
                Usuario usuario = new Usuario();
                usuario.Nome = "Dimas Martins";
                usuario.NomeUsuario = "dimasmota";
                usuario.DataNascimento = "20-12-1986";
                usuario.Cpf = "000.000.000-00";
                usuario.Senha = "1Dimas@";
                usuario.Email = "dimasmartinsmota@hotmail.com";
                usuario.Ativo = true;

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBLL.Inserir(usuario);
	        }
	        catch (Exception ex )
	        {

                Console.WriteLine(ex.Message);
	        }
        }
    }
}