using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario() // Construtor
        {
            InitializeComponent();
        }

    
        private void buttonSalvarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = nomeTextBox.Text;
            usuario.DataNascimento = dataNascimentoTextBox.Text;
            usuario.Cpf = cpfTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuarioBLL.Inserir(usuario);


        }

        
    }
}
