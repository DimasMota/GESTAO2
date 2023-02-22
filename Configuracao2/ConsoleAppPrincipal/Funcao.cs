using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrincipal
{
    public class Funcao
    {
        public void CadastrarUsuario() 
        {
            try
            {

                int sim_nao;

                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Console.WriteLine("Cadastrar  usuário: [1] SIM [2] NÃO ");
                sim_nao = Convert.ToInt32(Console.ReadLine());

                while (sim_nao == 1)
                {

                    Usuario cadastraUsuario = new Usuario();

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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void CadastrarPermissao()
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

        public void CadastrarGrupo()
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


                    Console.WriteLine("Cadastro de Grupo de Usuários\n\n");
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

        public void AlterarGrupo()
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

        public void AlterarPermissao()
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

        public void AlterarUsuario()
        {

            try
            {

                int sim_nao;
                int x;
                Usuario usuario2 = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Console.WriteLine("Alterar usuário: [1] SIM [2] NÃO ");
                sim_nao = Convert.ToInt32(Console.ReadLine());

                while (sim_nao == 1)
                {
                    //            Console.WriteLine("Qual dado você deseja alterar:\n[1]Nome \n[2] Nome de acesso do Usuário\n" +
                    //                "[3] Data de Nacimento\n [4] CPF \n [5] Senha\n [6] E-mail\n [7]Usuario Ativo?\n\n");
                    //           x = Convert.ToInt32(Console.ReadLine());


                    //            if (x == 1)
                    //           {
                    Console.WriteLine("Cadastro de Usuário\n\n");
                    Console.WriteLine("Nome Completo: ");
                    usuario2.Nome = Console.ReadLine();

                    //           }

                    //            if (x == 2)
                    //           {
                    Console.WriteLine("Nome de acesso do Usuário");
                    usuario2.NomeUsuario = Console.ReadLine();

                    //           }
                    //           if (x == 3)
                    //         {
                    Console.WriteLine("Data de Nascimento");
                    usuario2.DataNascimento = Console.ReadLine();

                    //       }
                    //     if (x == 4)
                    //   {
                    Console.WriteLine("CPF do Usuário: ");
                    usuario2.Cpf = Console.ReadLine();

                    //   }
                    //   if (x == 5)
                    //  {
                    Console.WriteLine("Senha:");
                    usuario2.Senha = Console.ReadLine();

                    //}
                    //    if (x == 6)
                    //   {
                    Console.WriteLine("Digite seu E_mail");
                    usuario2.Email = Console.ReadLine();

                    //                            }
                    //                            if (x == 7)
                    //                            {

                    Console.WriteLine("Usuario Ativo [S]SIM  [N]NÃO :");
                    usuario2.Ativo = Console.ReadLine().ToUpper() == "S";
                    //
                    //                           }
                    Console.WriteLine("Digite a Id do Usuário?: ");
                    usuario2.Id = Convert.ToInt32(Console.ReadLine());

                    usuarioBLL.Alterar(usuario2);

                    Console.WriteLine("Cadastrar outra alteração em Usuário: [1] SIM [2] NÃO ");
                    sim_nao = Convert.ToInt32(Console.ReadLine());

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
