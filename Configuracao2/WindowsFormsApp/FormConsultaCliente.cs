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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class FormConsultaCliente : Form
    {
        public FormConsultaCliente()
        {
            InitializeComponent();
        }

        private void button_Buscar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteBLL clienteBLL = new ClienteBLL();
              

                if (radioButton_BuscarTodos_Cliente.Checked)
                {
                    clienteBindingSource.DataSource = clienteBLL.BuscarTodos();
                }
                else if (radioButton_BuscarPorNome_Cliente.Checked)
                {
                    clienteBindingSource.DataSource = clienteBLL.BuscarPorNome(textBox_Buscar_Cliente.Text);

                }
                else if (radioButton_BuscarPorID_Cliente.Checked)
                {
                    clienteBindingSource.DataSource = clienteBLL.BuscarPorId(Convert.ToInt32(textBox_Buscar_Cliente.Text));
                }
                else if (radioButton_BuscarPorCPF_Cliente.Checked)
                {
                    clienteBindingSource.DataSource = clienteBLL.BuscarPorCPF(textBox_Buscar_Cliente.Text);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe registro para ser excluido!");
                    return;
                }
                int id = ((Cliente)clienteBindingSource.Current).Id;
                new ClienteBLL().Excluir(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Inserir_Cliente_Click(object sender, EventArgs e)
        {
            using (CadastrarCliente frm = new CadastrarCliente()) { frm.ShowDialog(); }
        }
    }
}
