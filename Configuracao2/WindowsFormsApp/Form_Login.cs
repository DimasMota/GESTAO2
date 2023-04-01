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
    public partial class Form_Login : Form
    {
        public bool Logou;
        public int Id;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            BindingSource usuarioBindingSource = new BindingSource();
            usuario = usuarioBLL.BuscarPorNomeAcesso(textBox_NomeUsuario.Text);
            string login;
            string senha;
            login = usuario.NomeUsuario;
                senha = usuario.Senha;
            if (login !="")
            {
                
                if (login == textBox_NomeUsuario.Text && textBox_Senha.Text == senha)
                {
                    Logou = true;
                    Id = ((Usuario)usuarioBindingSource.Current).Id;
                    
                    Close();

                }
                else
                {
                    MessageBox.Show("Login e/ou Senha incorreto");
                    textBox_Senha.Text = "";
                    textBox_Senha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Login e/ou Senha incorreto");
                textBox_Senha.Text = "";
                textBox_Senha.Focus();
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
