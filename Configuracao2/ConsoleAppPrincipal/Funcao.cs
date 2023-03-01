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

        public void AlterarUsuario()
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

        public void BuscarTodosUsuario()
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

        public void Buscar_Usuario_Nome()
        {
            try
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();



                Console.WriteLine("Pesquisa por nome\n\n");
                Console.WriteLine("Nome: ");
                string nome_busca = Console.ReadLine();

                Usuario usuario = usuarioBLL.BuscarUsuarioPorNome(nome_busca);


                Console.WriteLine("RESULTADO DA BUSCA\n\n");
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

        public void Buscar_NomeUsuario()
        {

            try
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Console.WriteLine("Pesquisar nome de Usuário(LOGIN)\n\n");
                Console.WriteLine("Nome: ");
                string nome_busca = Console.ReadLine();

                Usuario usuario = usuarioBLL.BuscarPorNomeAcesso(nome_busca);

                Console.WriteLine("RESULTADO DA BUSCAR DO USUÁRIO(LOGIN)\n\n");
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

        public void ExcluirUsuario()
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

        public void BuscarGrupo()
        {
            try
            {
                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
                List<GrupoUsuario> grupo_usuarios = grupousuarioBLL.BuscarTodosGrupos();

                foreach (GrupoUsuario item in grupo_usuarios)
                {

                    Console.WriteLine("ID do Grupo Usuario: " + item.Id);
                    Console.WriteLine("Nome do Grupo: " + item.NomeGrupo);

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

        public void ExcluirGrupo()
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

        public void BuscarTodasPermissao()
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                List<Permissao> permissoes = permissaoBLL.BuscarTodasPermissoes();

                foreach (Permissao item in permissoes)
                {

                    Console.WriteLine("ID da Permissão: " + item.Id);
                    Console.WriteLine("Descrição da Permissão: " + item.Descricao);

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

        public void ExcluirPermissão()
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

    }
}
