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
                    case 1:
                        {
                            if (textBox_Buscar_Fornecedor.Text == "")
                            {
                                MessageBox.Show("Insira o Nome para buscar.");
                                return;
                            }
                           
                                fornecedorBindingSource.DataSource = fornecedorBLL.BuscarPorNome(textBox_Buscar_Fornecedor.Text);
                         
                            break;
                        }
                    case 2:
                        {
                            if (textBox_Buscar_Fornecedor.Text == "")
                            {
                                MessageBox.Show("Insira o ID para buscar.");
                                return;
                            }
                                fornecedorBindingSource.DataSource = fornecedorBLL.BuscarPorId(Convert.ToInt32(textBox_Buscar_Fornecedor.Text));

                            break;
                        }
                    case 3:
                        {
                            if (textBox_Buscar_Fornecedor.Text == "")
                            {
                                MessageBox.Show("Insira o Site para buscar.");
                                return;
                            }
                                fornecedorBindingSource.DataSource = fornecedorBLL.BuscarPorSite(textBox_Buscar_Fornecedor.Text);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Insirir_Fornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastrarFornecedor frm = new FormCadastrarFornecedor())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Alterar_Fornecedor_Click(object sender, EventArgs e)
        {
            try
            {


                if (fornecedorBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe FORNECEDOR para ser alterado.");
                    return;
                }
                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;

                using (FormCadastrarFornecedor frm = new FormCadastrarFornecedor(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Excluir_Fornecedor_Click(object sender, EventArgs e)
        {
            try
            {

                if (fornecedorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                string menssagem = "Deseja realmente EXCLUIR este FORNECEDOR?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                string caption = "Error Detected in Input";
                result = MessageBox.Show(menssagem, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = ((Fornecedor)fornecedorBindingSource.Current).Id;
                    FornecedorBLL fornecedorBLL = new FornecedorBLL();
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Id = Convert.ToInt32(id);
                    fornecedorBLL.Excluir(id);
                    MessageBox.Show("Fornecedor excluido com sucesso!");
                    button_Buscar_Fornecedor_Click(null, null);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancelar_Fornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
