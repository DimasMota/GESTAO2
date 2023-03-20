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
    public partial class Form_VincularUsuarioGrupo : Form
    {
        public int id;
        public Form_VincularUsuarioGrupo()
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
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
                }
                else
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos_PorNome(textBox1.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_CancelarVinculacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vinculação de Usuário com o Grupo cancelada!");
            Close();
        }

        private void button_SelecionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {

                if (grupoUsuarioBindingSource.Count > 0)
                {
                    id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não existe um grupo de usuário selecionado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no selecionar grupo " + ex.Message);
            }

        }
    }
}
