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
            if (textBox1.Text == "")
            {

            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
            }
            else
            {

              //  GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
              //  grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox1.Text);



            }
        }

    }
}
