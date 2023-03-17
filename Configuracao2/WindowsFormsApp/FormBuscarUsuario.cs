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

            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            try
            {
                if (radioButtonBuscarTodos.Checked)
                {
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
                }
                else if (radioButtonBuscarNomeUsuario.Checked)
                {
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);

                }
                else if (radioButtonBuscarPorNome.Checked)
                {
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
                }
                else if (radioButtonBuscarPorId.Checked)
                {
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

            using (FormCadastrarUsuario frm = new FormCadastrarUsuario(true, id))
            {
                frm.ShowDialog();
            }

        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }


            string menssagem = "Deseja realmente EXCLUIR este usuário?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string caption = "Error Detected in Input";
            result = MessageBox.Show(menssagem, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int id = ((Usuario)usuarioBindingSource.Current).Id;
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(id);
                usuarioBLL.Excluir(usuario);
                MessageBox.Show("Usuario excluida com sucesso!");
                buttonBuscar_Click(null, null);
            }
            else
            {
                return;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                try
                {

                    frm.ShowDialog();
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                    usuarioBLL.AdicionarGrupo(idUsuario, frm.id);
                    MessageBox.Show("Grupo adicionado com sucesso!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao vincular Usuário em um grupo\n" + ex.Message);
                }
            }
        }

    }
}
