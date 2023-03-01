using Models;
using DAL;


namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length > 50) // length conta o numero de caracteres
            {
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
                //TODO:verificar se ja existe um usuário com este nome
            }

            if (_usuario.NomeUsuario.Contains(" ")) // Contains verifica se tem o caracteres dentro do parenteses no caso foi space
            {
                throw new Exception("O nome do usuário não pode ter espaços");

            }

            if (_usuario.Senha.Contains("1234567"))
            {
                throw new Exception("Não é permitido números em sequência");
            }

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

      
          public Usuario BuscarUsuarioPorNome(string _nome_busca)
          {
            if (String.IsNullOrEmpty(_nome_busca))
            {
                throw new Exception("Informe o nome do usuário");
            }
              UsuarioDAL usuarioDAL = new UsuarioDAL();
              return usuarioDAL.BuscarUsuarioPorNome(_nome_busca);

          }
          

        public List<Usuario> BuscarTodos()

        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }

        public void Alterar(Usuario _alterarUsuario)
        {
            if (_alterarUsuario.NomeUsuario.Length <= 3 || _alterarUsuario.NomeUsuario.Length > 50) // length conta o numero de caracteres
            {
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");
                //TODO:verificar se ja existe um usuário com este nome
            }

            if (_alterarUsuario.NomeUsuario.Contains(" ")) // Contains verifica se tem o caracteres dentro do parenteses no caso foi space
            {
                throw new Exception("O nome do usuário não pode ter espaços");

            }

            if (_alterarUsuario.Senha.Contains("1234567"))
            {
                throw new Exception("Não é permitido números em sequência");
            }

            if (_alterarUsuario.Senha.Length < 7 || _alterarUsuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            }


            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_alterarUsuario);
        }
        public void Excluir(Usuario _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }

    }
}