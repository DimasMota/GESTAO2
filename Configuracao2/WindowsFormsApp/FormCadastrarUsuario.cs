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
        private bool alterar;
        public FormCadastrarUsuario(bool _alterar = false, int _id = 0) // Construtor
        {
            InitializeComponent();
            
            alterar = _alterar;
            if (alterar)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarUsuarioPorId(_id);
                textBoxConfirmarSenha.Text = ((Usuario)usuarioBindingSource.Current).Senha;
            }
            
        }


        private void buttonSalvarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                usuarioBindingSource.EndEdit();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
               if (!alterar)
               {
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);
                    MessageBox.Show("Cadastrado com sucesso!");
                    Close();
               }
                else
                {
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);
                    MessageBox.Show("Alterado com sucesso!");
                    Close();

                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {
            if (!alterar)
            {
                usuarioBindingSource.AddNew();

            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            if (alterar)
            {
                MessageBox.Show("Alteração cancelada!");
                Close();
            }
            else
            {
                MessageBox.Show("Cadastro cancelado!");
                Close();
            }
        }

    }
}
