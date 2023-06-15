using BLL;
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
    public partial class FormConsultarFornecedor : Form
    {
        public FormConsultarFornecedor()
        {
            InitializeComponent();
        }

        private void button_Buscar_Fornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorBLL fornecedorBLL = new FornecedorBLL();

                switch (comboBox_BuscarPor_Fornecedor.SelectedIndex)
                {
                    case 0:
                        {
                            fornecedorBindingSource.DataSource = fornecedorBLL.BuscarTodos();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
