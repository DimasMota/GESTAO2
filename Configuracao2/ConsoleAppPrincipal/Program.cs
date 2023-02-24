using BLL;
using Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opc;
            do
            {

                Console.WriteLine("Programa GESTÂO\n\n");
                Console.WriteLine("Opções de Cadastro\n");
                Console.WriteLine("[1] Cadastrar Usuário\n" +
                                  "[2]Cadastrar Permissões \n" +
                                  "[3]Cadastrar Grupo\n" +
                                  "[4]Alterar Nome do grupo \n" +
                                  "[5] Alterar Descrição da Permissão\n" +
                                  "[6]Alterar Usuário\n" +
                                  "[7]Excluir Usuário\n" +
                                  "[8]Excluir Permissão\n" +
                                  "[9]Excluir Grupo\n" +
                                  "[10] Buscar todos os usuários\n"+
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

                    case 7:

                        funcao.ExcluirUsuario();

                        break;

                    case 8:// Excluir Permissao(descricao)

                        funcao.ExcluirPermissao();

                        break;

                    case 9: // Excluir Grupo

                        funcao.ExcluirGrupo();

                        break;

                    case 10:

                        
                           

                            
                            UsuarioBLL usuarioBLL = new UsuarioBLL();
                            List<Usuario> usuarios = usuarioBLL.BuscarTodos();
                            foreach (Usuario item in usuarios)
                            {
                                Console.WriteLine("Id do Usuário: "+item.Id);
                                Console.WriteLine("Nome do usuário: "+ item.Nome);
                            }
                          


                                              
                        break;

                }









            } while (opc != 0);


        }
    }
}