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
    public partial class FormCadastrarGrupo : Form
    {
        public FormCadastrarGrupo()
        {
            InitializeComponent();
        }

        private void button_Salvar_CadastrarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.EndEdit();
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                       
               
                grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
