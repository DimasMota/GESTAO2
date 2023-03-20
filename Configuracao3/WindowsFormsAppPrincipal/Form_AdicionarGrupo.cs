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
    public partial class Form_AdicionarGrupo : Form
    {
        private bool alterar;
        public Form_AdicionarGrupo(bool _alterar, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPor_Id(_id);
            }
        }

        private void button_Salvar_AdicionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (!alterar)
                {
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                    MessageBox.Show("Grupo adicionado com sucesso");
                    Close();
                }
                else
                {
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);
                    MessageBox.Show("Grupo alterado com sucesso");
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_AdicionarGrupo_Load(object sender, EventArgs e)
        {
            if(!alterar)
            grupoUsuarioBindingSource.AddNew();
        }

        private void button_Cancelar_AdicaoGrupo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
