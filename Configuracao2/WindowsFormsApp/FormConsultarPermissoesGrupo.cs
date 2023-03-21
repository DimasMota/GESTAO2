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
    public partial class FormConsultarPermissoesGrupo : Form
    {
        public int id;
        public FormConsultarPermissoesGrupo()
        {
            InitializeComponent();
        }

        private void button_BuscarPermissoes_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permisssaoBLL = new PermissaoBLL();
                if (textBox1.Text == "")
                {
                    permissaoBindingSource.DataSource = permisssaoBLL.BuscarTodasPermissoes();

                }
                else 
                {
                    permissaoBindingSource.DataSource = permisssaoBLL.BuscarPermissao_PorNome(textBox1.Text);
                }

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
                if (permissaoBindingSource.Count > 0)
                {
                    id = ((Permissao)permissaoBindingSource.Current).Id;
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

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
