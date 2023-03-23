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
    public partial class FormBuscarGrupo : Form
    {
        public FormBuscarGrupo()
        {
            InitializeComponent();
        }
        private void buttonBuscarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(5);
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (radioButtonBuscarTodos.Checked)
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
                }
                else if (radioButtonBuscarNome.Checked)
                {

                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox1.Text);
                }
                else if (radioButtonBuscarID.Checked)
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPor_Id(Convert.ToInt32(textBox1.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(6);
                buttonBuscarGrupo_Click(sender, e);
                using (FormCadastrarGrupo frm = new FormCadastrarGrupo())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(7);
                if (grupoUsuarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não tem grupo selecionado");
                    return;
                }
                int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                using (FormCadastrarGrupo frm = new FormCadastrarGrupo(true, id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(8);
                if (grupoUsuarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado grupo para ser excluído!");
                    return;
                }
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                grupoUsuarioBLL.Excluir(((GrupoUsuario)grupoUsuarioBindingSource.Current));
                MessageBox.Show("Grupo excluído com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(9);
                using (FormConsultarPermissoesGrupo frm = new FormConsultarPermissoesGrupo())
                {
                    try
                    {
                        frm.ShowDialog();
                        if (frm.id == 0)//Id permissao selecionada na consulta
                        {
                            return;
                        }
                        GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                        int idGrupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                        grupoUsuarioBLL.VincularPermissaoGrupo(idGrupo, frm.id);
                        MessageBox.Show("Permissão adicionada com sucesso!");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao vincular Usuário em um grupo\n" + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(12);
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (grupoUsuarioBindingSource.Count > 0 && permissoesBindingSource.Count > 0)
                {
                    int id_grupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    int id_permissao = ((Permissao)permissoesBindingSource.Current).Id;
                    if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    grupoUsuarioBLL.RemoverVinculoGrupoPermissao(id_grupo, id_permissao);
                    MessageBox.Show("Permissão removida com sucesso.");
                }
                else
                {
                    MessageBox.Show("Grupo de Usuário ou Permissão não selecionado");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


