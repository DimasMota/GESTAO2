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
    public partial class BuscarPessoa : Form
    {
        public BuscarPessoa()
        {
            InitializeComponent();


        }

        private void button_BuscarPessoa_Click(object sender, EventArgs e)
        {
            try
            {

                PessoaBLL pessoaBLL = new PessoaBLL();
                if (radioButton_BuscarTodasPessoas.Checked)
                {
                    

                    pessoaBindingSource.DataSource = pessoaBLL.BuscarTodos();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
