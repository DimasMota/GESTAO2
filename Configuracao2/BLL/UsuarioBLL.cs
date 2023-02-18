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
           
            if(_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
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
        public void Excluir(int _id)
        {

        }

    }
}