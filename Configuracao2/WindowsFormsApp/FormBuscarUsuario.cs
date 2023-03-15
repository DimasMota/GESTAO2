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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        
        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormCadastrarUsuario frm = new FormCadastrarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;

            using (FormCadastrarUsuario frm = new FormCadastrarUsuario(true,id))
            {
                frm.ShowDialog();
            }

        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;

            string menssagem = "Deseja realmente EXCLUIR este usuário?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string caption = "Error Detected in Input";
            result = MessageBox.Show(menssagem, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(id);
                usuarioBLL.Excluir(usuario);
                MessageBox.Show("Usuario excluida com sucesso!");
                Close();
            }
            else
            {
                Close();

            }
        }
    }
}
