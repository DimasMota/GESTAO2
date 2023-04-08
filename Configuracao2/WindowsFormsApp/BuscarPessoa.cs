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
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario usuario = new Usuario();
                if (radioButton_BuscarTodasPessoas.Checked)
                {
                    pessoaBindingSource.DataSource = pessoaBLL.BuscarTodos();
                }
                else if (radioButton_BuscarPor_Nome.Checked)
                {
                    pessoaBindingSource.DataSource = pessoaBLL.BuscarTodosPessoaPor_Nome(textBox_BuscaPessoa.Text);
                }
                else if(radioButton_BuscarPor_CPF.Checked)
                {
                    pessoaBindingSource.DataSource = pessoaBLL.BuscarPessoaPor_CPF(textBox_BuscaPessoa.Text);
                }
                else if (radioButton_BuscarPor_ID.Checked)
                {
                    pessoaBindingSource.DataSource = pessoaBLL.BuscarPessoaPor_ID(Convert.ToInt32(textBox_BuscaPessoa.Text));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
