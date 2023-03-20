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

namespace WindowsFormsAppPrincipal
{
    public partial class Form_BuscarUsuario : Form
    {
        public Form_BuscarUsuario()
        {
            InitializeComponent();
        }

        private void button_BuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                if (radioButton_BuscarTodos.Checked)
                {

                    usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
                }
                else if (radioButton_BuscarNome.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
                }
                else if (radioButton_Buscar_NomeUsuario.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);
                }
                else if (radioButton_Buscar_Id.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(textBox1.Text));
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_AdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (Form_AdicionarUsuario frm = new Form_AdicionarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void button_AlterarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (usuarioBindingSource.Count == 0)// verifica se tem algum relação na visualização de usuarios, 
                {
                    MessageBox.Show("Não existe grupo de usuário para ser excluido.");
                    return;
                }

                int id = ((Usuario)usuarioBindingSource.Current).Id;// pega o ID do usuário selecionado

                using (Form_AdicionarUsuario frm = new Form_AdicionarUsuario(true, id))// usa a mesma form do cadastro de usuário, ele envia os parâmetro "true" e "id" para
                {// onde alterar o valor do parâmetro do metodo lá inserido para verdadeiro (true) e o Id do usuarios que será alterardo.
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_ExcluirUsuario_Click(object sender, EventArgs e)
        {

            try
            {

                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }


                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {

                    int id = ((Usuario)usuarioBindingSource.Current).Id;
                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(id);
                    usuarioBLL.Excluir(usuario);
                    MessageBox.Show("Usuario excluida com sucesso!");
                    button_BuscarUsuario_Click(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button_Vincular_Grupo_Click(object sender, EventArgs e)
        {
            using (Form_VincularUsuarioGrupo frm = new Form_VincularUsuarioGrupo())
            {
                try
                {

                    frm.ShowDialog();
                    if (frm.id == 0)
                    {
                        return;
                    }
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

        private void button_ExcluirGrupo_Click(object sender, EventArgs e) // remover usuário de um determinado grupo
        {
            try
            {
                if (usuarioBindingSource.Count == 0 || grupoUsuariosBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe grupo de usuário para ser excluido.");
                    return;
                }
                int id_grupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                int id_usuario = ((Usuario)usuarioBindingSource.Current).Id;

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                new UsuarioBLL().RemoverGrupoUsuario(id_usuario, id_grupo);
                MessageBox.Show("Usuário removido do grupo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao remover um usuário do grupo.\n" + ex.Message);
            }

        }
    }
}
