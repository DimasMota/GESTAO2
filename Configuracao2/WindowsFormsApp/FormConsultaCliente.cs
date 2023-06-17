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

                switch (comboBox_BuscarPor_Cliente.SelectedIndex)
                {
                    case 3:
                        {
                            if(new ClienteBLL().Existe_Cliente())
                            {
                                clienteBindingSource.DataSource = clienteBLL.BuscarTodos();
                            }
                            else
                            {
                                MessageBox.Show("Não tem clientes cadastrados");
                            }
                           
                           
                            
                            
                            break;

                        }
                    case 1:
                        {
                            if (textBox_Buscar_Cliente.Text == "")
                            {
                                MessageBox.Show("Insira o ID para buscar.");
                                return;
                            }
                            
                            
                            clienteBindingSource.DataSource = clienteBLL.BuscarPorNome(textBox_Buscar_Cliente.Text);
                          
                            
                            break;
                        }
                    case 0:
                        {
                            if (textBox_Buscar_Cliente.Text == "")
                            {
                                MessageBox.Show("Insira o ID para buscar.");
                                return;
                            }
                            clienteBindingSource.DataSource = clienteBLL.BuscarPorId(Convert.ToInt32(textBox_Buscar_Cliente.Text));
                           
                            break;
                        }
                    case 2:
                        {
                            if (textBox_Buscar_Cliente.Text == "")
                            {
                                MessageBox.Show("Insira o CPF para buscar.");
                                return;
                            }
                            clienteBindingSource.DataSource = clienteBLL.BuscarPorCPF(textBox_Buscar_Cliente.Text);
                       
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Selecione o tipo de busca");
                            break;
                        }
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

                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                string menssagem = "Deseja realmente EXCLUIR este Cliente?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                string caption = "Error Detected in Input";
                result = MessageBox.Show(menssagem, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = ((Cliente)clienteBindingSource.Current).Id;
                    ClienteBLL clienteBLL = new ClienteBLL();
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(id);
                    clienteBLL.Excluir(id);
                    MessageBox.Show("Cliente excluido com sucesso!");
                    button_Buscar_Cliente_Click(null, null);
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

        private void button_Inserir_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (CadastrarCliente frm = new CadastrarCliente()) { frm.ShowDialog(); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button_Alterar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {


                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe CLIENTE para ser alterado.");
                    return;
                }
                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (CadastrarCliente frm = new CadastrarCliente(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancelar_Cliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            comboBox_BuscarPor_Cliente.SelectedIndex = 3;
        }
    }
}
