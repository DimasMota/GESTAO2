using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    
    public partial class FormConsultarGrupoUsuario : Form
    {
        public int id;
        public FormConsultarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();



                grupoUsuarioBindingSource.DataSource = grupousuarioBLL.BuscarTodosGrupos_PorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
