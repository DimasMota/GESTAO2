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
    public partial class Form_BuscarGrupo : Form
    {
        public Form_BuscarGrupo()
        {
            InitializeComponent();
        }

        private void button_BuscarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (radioButton_BuscarTodos.Checked)
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
                }
                else if (radioButton_BuscarPorNome.Checked)
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos_PorNome(textBox1.Text);
                }
                else if (radioButton_BuscarId.Checked)
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPor_Id(Convert.ToInt32(textBox1.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_AdicionarGrupo_Click(object sender, EventArgs e)
        {
            using (Form_AdicionarGrupo frm = new Form_AdicionarGrupo(false))
            {
                frm.ShowDialog();
            }
        }

        private void button_AlterarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count == 0)
                {
                    MessageBox.Show("Não tem grupo selecionado");
                    return;
                }
                int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                using (Form_AdicionarGrupo frm = new Form_AdicionarGrupo(true, id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(grupoUsuarioBindingSource.Count == 0)
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

        private void button_Adicionar_VincularPermissao_Click(object sender, EventArgs e)
        {
            string nomegrupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).NomeGrupo;
            using (Form_VincularGrupoPermissao frm = new Form_VincularGrupoPermissao(nomegrupo))
            {
                try
                {

                    frm.ShowDialog();
                    if (frm.id == 0)//Id permissao
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

        private void button_Excluir_VinculoPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if(grupoUsuarioBindingSource.Count > 0 && permissoesBindingSource.Count > 0)
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
