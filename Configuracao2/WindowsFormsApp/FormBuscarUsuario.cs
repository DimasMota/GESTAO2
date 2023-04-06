﻿using BLL;
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

            try
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                new UsuarioBLL().ValidarPermissao(1);

                if (radioButtonBuscarTodos.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
                }
                else if (radioButtonBuscarNomeUsuario.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);

                }
                else if (radioButtonBuscarPorNome.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
                }
                else if (radioButtonBuscarPorId.Checked)
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e) // cadastrar usuario
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(2);
                 buttonBuscar_Click(sender, e);

                using (FormCadastrarUsuario frm = new FormCadastrarUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // alterar usuario
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(3);

                if (usuarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe grupo de usuário para ser excluido.");
                    return;
                }
                int id = ((Usuario)usuarioBindingSource.Current).Id;
               
                using (FormCadastrarUsuario frm = new FormCadastrarUsuario(true, id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(4);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e) // adicionar grupo a usuario
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                try
                {
                    new UsuarioBLL().ValidarPermissao(10);
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

        private void button_RemoverGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(11);
                if (usuarioBindingSource.Count == 0 || grupoUsuariosBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe grupo de usuário para ser excluido.");
                    return;
                }
                int id_grupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                int id_usuario = ((Usuario)usuarioBindingSource.Current).Id;
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
