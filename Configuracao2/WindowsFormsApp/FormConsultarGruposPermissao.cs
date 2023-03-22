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
    public partial class FormConsultarGruposPermissao : Form
    {
        public int id;
        public FormConsultarGruposPermissao()
        {
            InitializeComponent();
        }

        private void button_BuscarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (textBox1.Text == "")
                {
                    grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();

                }
                else
                {
                    grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox1.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_SelecionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (grupoUsuariosBindingSource.Count > 0)
                {
                    id = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não existe um grupo selecionado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
