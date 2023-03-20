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

namespace WindowsFormsAppPrincipal
{
    public partial class Form_VincularGrupoPermissao : Form
    {
        public int id;
        public string nomegrupo;
        public Form_VincularGrupoPermissao(string _nomeGrupo)
        {
            InitializeComponent();
            nomegrupo = _nomeGrupo;
            nomeGrupoTextBox.Text = nomegrupo;
        }
        private void button_BuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                permissoesBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_SelecionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissoesBindingSource.Count > 0)
                {
                    id = ((Permissao)permissoesBindingSource.Current).Id;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não tem permissão selecionada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_CancelarVinculoPermissao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
