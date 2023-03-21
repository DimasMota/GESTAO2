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
    public partial class FormCadastrarGrupo : Form
    {
        private bool alterar;
        public FormCadastrarGrupo(bool _alterar = false, int _idGrupo = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPor_Id(_idGrupo);
            }
        }

        private void button_Salvar_CadastrarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.EndEdit();
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (!alterar)
                {
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                    MessageBox.Show("Grupo adicionado com sucesso!");
                }
                else
                {
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);
                    MessageBox.Show("Grupo alterado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastrarGrupo_Load(object sender, EventArgs e)
        {
            if (!alterar)
            {
                grupoUsuarioBindingSource.AddNew();
            }
        }
    }
}
