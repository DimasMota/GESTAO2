using BLL;
using Models;

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

                            try
                            {
                                Usuario usuario = new Usuario();
                                UsuarioBLL usuarioBLL = new UsuarioBLL();
                                string sim_nao;
                                do
                                {

                                    Console.WriteLine("CADASTRO DE USUÁRIO\n\n");
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


                                    Console.WriteLine("Deseja Salvar Usuário?");
                                    sim_nao = Console.ReadLine().ToUpper();
                                    if (sim_nao == "S")
                                    {
                                        usuarioBLL.Inserir(usuario);

                                    }

                                    Console.WriteLine("Deseja cadastrar outro Usuário?: [S]SIM [N]NÃO");
                                    sim_nao = Console.ReadLine().ToUpper();
                                } while (sim_nao == "S");





                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        //alterr usuario
                        else if (opc_usuario == 2) // ALTERAR USUÁRIO
                        {


                            try
                            {

                                int sim_nao;
                                int x;
                                Usuario usuario = new Usuario();
                                UsuarioBLL usuarioBLL = new UsuarioBLL();

                                Console.WriteLine("Alterar usuário: [1] SIM [2] NÃO ");
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
                                    Console.WriteLine("Digite a Id do Usuário?: ");
                                    usuario.Id = Convert.ToInt32(Console.ReadLine());
                                    usuarioBLL.Alterar(usuario);

                                    Console.WriteLine("Deseja alterar outro Usuário [1]SIM [2]NÃO");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());
                                }


                               

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                            }


                        }
                        //buscar usuario
                        else if (opc_usuario == 3)// BUSCAR USUÁRIO
                        {
                            int opc_busca_usuario;
                            Console.WriteLine("TIPOS DE BUSCAS\n\n");
                            Console.WriteLine("[1]BUSCAR TODOS\n" +
                                              "[2]BUSCAR POR NOME\n" +
                                              "[0]SAIR");
                            opc_busca_usuario = Convert.ToInt32(Console.ReadLine());
                            // buscar todos
                            if (opc_busca_usuario == 1) // BUSCAR TODOS OS USUÁRIOS
                            {

                                try
                                {
                                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                                    List<Usuario> usuarios = usuarioBLL.BuscarTodos();
                                    foreach (Usuario item in usuarios)
                                    {
                                        Console.WriteLine("TODOS OS USUÁRIOS\n\n");
                                        Console.WriteLine("ID do usuário: " + item.Id);
                                        Console.WriteLine("Nome do Usuário: " + item.Nome);
                                        Console.WriteLine("Nome e Acesso do Usuario: " + item.NomeUsuario);
                                        Console.WriteLine("Data de Nascimento: " + item.DataNascimento);
                                        Console.WriteLine("CPF: " + item.Cpf);
                                        Console.WriteLine("E-mail: " + item.Email);
                                        Console.WriteLine("Ativo: " + item.Ativo);
                                        Console.WriteLine("\n\n");

                                    }
                                    Console.WriteLine("Tecle ENTER para voltar ao MENU");
                                    Console.ReadLine();
                                }
                                catch (Exception ex)
                                {

                                    Console.WriteLine(ex.Message);
                                }

                            }
                            // BUSCAR USUARIO POR NOME
                            else if (opc_busca_usuario == 2) 
                            {

                                try
                                {

                                    

                                    
                                    UsuarioBLL usuarioBLL = new UsuarioBLL();



                                        Console.WriteLine("Pesquisa por nome\n\n");
                                        Console.WriteLine("Nome: ");
                                        string nome_busca = Console.ReadLine();

                                        Usuario usuario = usuarioBLL.BuscarUsuarioPorNome( nome_busca);
                                       
                                    
                                        Console.WriteLine("TODOS OS USUÁRIOS\n\n");
                                        Console.WriteLine("ID do usuário: " + usuario.Id);
                                        Console.WriteLine("Nome do Usuário: " + usuario.Nome);
                                        Console.WriteLine("Nome e Acesso do Usuario: " + usuario.NomeUsuario);
                                        Console.WriteLine("Data de Nascimento: " + usuario.DataNascimento);
                                        Console.WriteLine("CPF: " + usuario.Cpf);
                                        Console.WriteLine("E-mail: " + usuario.Email);
                                        Console.WriteLine("Ativo: " + usuario.Ativo);
                                        Console.WriteLine("\n\n");

                                    
                                    Console.WriteLine("Tecle ENTER para voltar ao MENU");
                                    Console.ReadLine();
                                }
                                catch (Exception ex)
                                {

                                    Console.WriteLine(ex.Message);
                                }

                            }


                        }
                        // excluir usuário
                        else if (opc_usuario == 4) // EXCLUIR USUÁRIO
                        {
                            try
                            {

                                int sim_nao;

                                Usuario usuario = new Usuario();
                                UsuarioBLL usuarioBLL = new UsuarioBLL();

                                Console.WriteLine("Deseja Excluir  usuário: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {



                                    Console.WriteLine("Exlusão de Usuário\n\n");
                                    Console.WriteLine("ID do Usuário que você deseja EXCLUIR: ");
                                    usuario.Id = Convert.ToInt32(Console.ReadLine());

                                    usuarioBLL.Excluir(usuario);
                                    Console.WriteLine("Excluir outro usuário: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());
                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);


                            }
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
                        if (opc_grupo == 1)// CADASTRAR GRUPO DE USUÁRIO
                        {
                            try
                            {
                                int sim_nao;

                                GrupoUsuario grupousuario = new GrupoUsuario();
                                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();

                                Console.WriteLine("Deseja Cadastrar Novo Grupo: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {


                                    Console.WriteLine("CADASTRAR GRUPO DE USUÁRIO\n\n");
                                    Console.WriteLine("Nome do Grupo: ");
                                    grupousuario.NomeGrupo = Console.ReadLine();


                                    grupousuarioBLL.Inserir(grupousuario);

                                    Console.WriteLine("\n\nCadastrar outro Grupo: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }

                        }
                        else if (opc_grupo == 2) // ALTERAR GRUPO DE USUÁRIO
                        {
                            try
                            {
                                int sim_nao;

                                GrupoUsuario grupousuario = new GrupoUsuario();
                                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();

                                Console.WriteLine("Deseja Alterar o nome do Grupo?: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {


                                    Console.WriteLine("ALTERAÇÃO DO NOME DO GRUPO\n\n");
                                    Console.WriteLine("Novo nome do Grupo: ");
                                    grupousuario.NomeGrupo = Console.ReadLine();
                                    Console.WriteLine("Em qual Id do Grupo?: ");
                                    grupousuario.Id = Convert.ToInt32(Console.ReadLine());


                                    grupousuarioBLL.Alterar(grupousuario);

                                    Console.WriteLine("\n\nDeseja ALTERAR outro Grupo?: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }

                        }
                        // BUSCAR GRUPO DE USUÁRIO
                        else if (opc_grupo == 3)  // A FAZER
                        {

                        }
                        //EXLUIR GRUPO
                        else if (opc_grupo == 4)
                        {
                            try
                            {
                                int sim_nao;

                                GrupoUsuario grupousuario = new GrupoUsuario();
                                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();

                                Console.WriteLine("Deseja Excluir Grupo?: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {
                                    grupousuario.Id = Convert.ToInt32(Console.ReadLine());


                                    grupousuarioBLL.Excluir(grupousuario);

                                    Console.WriteLine("\n\nDeseja EXCLUIR outro Grupo?: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
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
                            try
                            {

                                int sim_nao;

                                Permissao permissao = new Permissao();
                                PermissaoBLL permissaoBLL = new PermissaoBLL();

                                Console.WriteLine("Cadastrar Permissão: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {


                                    Console.WriteLine("Cadastro de Permissão\n\n");
                                    Console.WriteLine("Descrição da Permissão: ");
                                    permissao.Descricao = Console.ReadLine();


                                    permissaoBLL.Inserir(permissao);
                                    Console.WriteLine("Cadastrar outra Permissão: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        // alterar permissão
                        else if (opc_permissao == 2)
                        {
                            try
                            {
                                int sim_nao;

                                Permissao permissao = new Permissao();
                                PermissaoBLL permissaoBLL = new PermissaoBLL();

                                Console.WriteLine("Deseja Alterar a Descrição de uma Permissão?: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {


                                    Console.WriteLine("ALTERAÇÃO DO NOME DO GRUPO\n\n");
                                    Console.WriteLine("Novo nome do Grupo: ");
                                    permissao.Descricao = Console.ReadLine();
                                    Console.WriteLine("Em qual Id do Grupo?: ");
                                    permissao.Id = Convert.ToInt32(Console.ReadLine());


                                    permissaoBLL.Alterar(permissao);

                                    Console.WriteLine("\n\nDeseja ALTERAR outra Descrição de uma Permissão?: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }

                        }
                        // buscar permissão
                        else if (opc_permissao == 3)
                        {

                        }
                        // excluir permissão
                        else if (opc_permissao == 4)
                        {
                            try
                            {
                                int sim_nao;

                                Permissao permissao = new Permissao();
                                PermissaoBLL permissaoBLL = new PermissaoBLL();

                                Console.WriteLine("Deseja EXCLUIR Uma  Permissão?: [1] SIM [2] NÃO ");
                                sim_nao = Convert.ToInt32(Console.ReadLine());

                                while (sim_nao == 1)
                                {


                                    Console.WriteLine("EXCLUIR DESCRIÇÃO DE UMA PERMISSÃO\n\n");
                                    Console.WriteLine("Id da Descrição da permissão: ");
                                    permissao.Id = Convert.ToInt32(Console.ReadLine());


                                    permissaoBLL.Excluir(permissao);

                                    Console.WriteLine("\n\nDeseja ALTERAR outra Descrição de uma Permissão?: [1] SIM [2] NÃO ");
                                    sim_nao = Convert.ToInt32(Console.ReadLine());

                                }


                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }

                         Console.WriteLine("RETORNAR À MENU PERMISSÃO [1]SIM [0]NÃO");
                        retorno_menu_permissao = Convert.ToInt32(Console.ReadLine());

                    } while (retorno_menu_permissao != 0);


            }
               

                









            } while (opc_menu != 0);

        }
    }
}