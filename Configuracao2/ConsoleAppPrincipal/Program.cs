using BLL;
using Models;
using System.Net.Http.Headers;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opc_menu;
            do
            {
                Console.WriteLine("CADASTRO DE USUÁRIO\n\n");
                Console.WriteLine("[1]USUÁRIO\n" +
                                  "[2]GRUPO DE USUÁRIO\n" +
                                  "[3]PERMISSÕES\n" +
                                  "[0]SAIR");
                Console.WriteLine("Olá Mundo");

                Funcao funcao = new Funcao();
                opc_menu = Convert.ToInt32(Console.ReadLine());

                // USUÁRIOS
                if (opc_menu == 1) // USUÁRIOS
                {
                    int retorno_menu_usuario;
                    do
                    {

                        int opc_usuario;
                        Console.WriteLine("[1]CADASTRAR USUÁRIO\n" +
                                          "[2]ALTERAR USUÁRIO\n" +
                                          "[3]BUSCAR USUÁRIO\n" +
                                          "[4]EXCLUIR USUÁRIO\n" +
                                          "[0]SAIR\n");

                        opc_usuario = Convert.ToInt32(Console.ReadLine());
                        // cadastrar usuario
                        if (opc_usuario == 1) // CADASTRAR USUÁRIO
                        {
                            funcao.CadastrarUsuario();
              
                        }
                        //alterar usuario
                        else if (opc_usuario == 2) // ALTERAR USUÁRIO
                        {
                            funcao.AlterarUsuario();


                        }
                        //buscar usuario
                        else if (opc_usuario == 3)// BUSCAR USUÁRIO
                        {
                            int opc_busca_usuario;
                            Console.WriteLine("TIPOS DE BUSCAS\n\n");
                            Console.WriteLine("[1]BUSCAR TODOS\n" +
                                              "[2]BUSCAR POR NOME\n" +
                                              "[3]BUSCAR NOME DE USUÁRIO\n" +
                                              "[0]SAIR");
                            opc_busca_usuario = Convert.ToInt32(Console.ReadLine());
                            // buscar todos
                            if (opc_busca_usuario == 1) // BUSCAR TODOS OS USUÁRIOS
                            {
                                funcao.BuscarTodosUsuario();
                               
                            }
                            // BUSCAR USUARIO POR NOME
                            else if (opc_busca_usuario == 2)
                            {
                                funcao.Buscar_Usuario_Nome();
                  
                            }
                            // BUSCAR NOME DE USUÁRIO
                            else if (opc_busca_usuario == 3)
                            {
                                funcao.Buscar_NomeUsuario(); // nome de acesso
                            }


                        }
                        // excluir usuário
                        else if (opc_usuario == 4) // EXCLUIR USUÁRIO
                        {
                            funcao.ExcluirUsuario();
                 
                        }

                        Console.WriteLine("RETORNAR À USUÁRIOS [1]SIM [0]NÃO");
                        retorno_menu_usuario = Convert.ToInt32(Console.ReadLine());

                    } while (retorno_menu_usuario != 0);

                }
                //GRUPOS
                else if (opc_menu == 2)
                {
                    int retorno_menu_grupo;
                    do
                    {
                        int opc_grupo;
                        Console.WriteLine("GRUPO DE USUÁRIO \n\n");
                        Console.WriteLine("[1]CADASTRAR GRUPO DE USUÁRIO\n" +
                                          "[2]ALTERAR GRUPO DE USUÁRIO\n" +
                                          "[3]BUSCAR GRUPO DE USUÁRIO\n" +
                                          "[4]EXCLUIR GRUPO DE USUÁRIO\n" +
                                          "[0]SAIR\n");

                        opc_grupo = Convert.ToInt32(Console.ReadLine());
                        //cadastrar
                        if (opc_grupo == 1)// CADASTRAR GRUPO DE USUÁRIO
                        {
                            funcao.CadastrarGrupo();
                 
                        }
                        // alterar
                        else if (opc_grupo == 2) // ALTERAR GRUPO DE USUÁRIO
                        {
                            funcao.AlterarGrupo();
                   
                        }
                        // BUSCAR GRUPO DE USUÁRIO
                        else if (opc_grupo == 3)  // A FAZER
                        {
                            funcao.BuscarGrupo();
                           
                        }
                        //EXLUIR GRUPO
                        else if (opc_grupo == 4)
                        {
                            funcao.ExcluirGrupo();
                         
                        }

                        Console.WriteLine("RETORNAR À MENU GRUPO DE USUÁRIO [1]SIM [0]NÃO");
                        retorno_menu_grupo = Convert.ToInt32(Console.ReadLine());

                    } while (retorno_menu_grupo != 0);

                }
                //PERMISSÕES
                else if (opc_menu == 3)
                {

                    int retorno_menu_permissao;
                    do
                    {


                        int opc_permissao;
                        Console.WriteLine("PERMISSÕES \n\n");
                        Console.WriteLine("[1]CADASTRAR PERMISSÃO\n" +
                                          "[2]ALTERAR PERMISSÃO\n" +
                                          "[3]BUSCAR PERMISSAO\n" +
                                          "[4]EXCLUIR PERMISSAO\n" +
                                          "[0]SAIR\n");

                        opc_permissao = Convert.ToInt32(Console.ReadLine());
                        // cadastrar permissão
                        if (opc_permissao == 1)
                        {
                            funcao.CadastrarPermissao();
                
                        }
                        // alterar permissão
                        else if (opc_permissao == 2)
                        {
                            funcao.AlterarPermissao();
          
                        }
                        // buscar permissão
                        else if (opc_permissao == 3)
                        {
                            int opc_per;
                            Console.WriteLine("GRUPO DE USUÁRIO \n\n");
                            Console.WriteLine("[1]BUSCAR TODOS\n" +
                                              "[2]BUSCAR POR NOME\n" +
                                              "[0]SAIR\n");
                            opc_per = Convert.ToInt32(Console.ReadLine());

                            if (opc_per == 1)
                            {
                                funcao.BuscarTodasPermissao();
                  

                            }
                            else if (opc_per == 2)
                            {

                            }


                        }
                        // excluir permissão
                        else if (opc_permissao == 4)
                        {
                            funcao.ExcluirPermissão();
                        }

                        Console.WriteLine("RETORNAR À MENU PERMISSÃO [1]SIM [0]NÃO");
                        retorno_menu_permissao = Convert.ToInt32(Console.ReadLine());

                    } while (retorno_menu_permissao != 0);


                }












            } while (opc_menu != 0);

        }
    }
}