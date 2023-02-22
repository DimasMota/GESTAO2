using BLL;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Programa GESTÂO\n\n");
            Console.WriteLine("Opções de Cadastro\n");
            Console.WriteLine("[1] Cadastrar Usuário\n" +
                              "[2]Cadastrar Permissões \n" +
                              "[3]Cadastrar Grupo\n" +
                              "[4]Alterar Nome do grupo \n" +
                              "[5] Alterar Descrição da Permissão\n" +
                              "[6]Alterar Usuário\n" +
                              "[0]Sair");
            opc = Convert.ToInt32(Console.ReadLine());

            Funcao funcao = new Funcao();
            switch (opc)
            {
                case 1: //Cadastrar usuario


                    funcao.CadastrarUsuario();

                    break;

                case 2: // Cadastrar Permissões

                    funcao.CadastrarPermissao();
                   
                    break;

                case 3: // Cadatrar Grupo de Usuário

                    funcao.CadastrarGrupo();

                   
                    break;

                case 4: // Alterar O nome do Grupo

                    funcao.AlterarGrupo();

       
                    break;

                case 5:// Alterar Permissão

                    funcao.AlterarPermissao();

                    break;

                case 6://Alterar Usuário

                    funcao.AlterarUsuario();

                    break;

            }

        }
    }
}