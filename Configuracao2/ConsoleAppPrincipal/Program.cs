using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    public class Program
    {
        static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Dimas Martins";
            usuario.NomeUsuario = "dimasmota";
            usuario.DataNascimento = "20-12-1986";
            usuario.Cpf = "000.000.000-00";
            usuario.Senha = "1Dimas@";
            usuario.Email = "dimasmartinsmota@hotmail.com";
            usuario.Ativo = true;
            usuarioBLL.Inserir(usuario);
        }
    }
}