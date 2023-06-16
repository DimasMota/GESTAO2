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
    public partial class FormCadastrarFornecedor : Form
    {
        int id;
        public FormCadastrarFornecedor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void button_Salvar_Fornecedor_Click(object sender, EventArgs e)
        {
            try
            { 
                fornecedorBindingSource.EndEdit();
                FornecedorBLL fornecedorBLL = new FornecedorBLL();



                if (id == 0)
                {
                  /*  if (new FornecedorDAL().Existe_Fornecedor(_fornecedor))
                    {
                       ("Usuário já existente");

                       
                    }
                  */
                    fornecedorBLL.Inserir((Fornecedor)fornecedorBindingSource.Current);
                    MessageBox.Show("Cadastrado com sucesso!");
                    Close();
                }
                else
                {
                    fornecedorBLL.Alterar((Fornecedor)fornecedorBindingSource.Current);
                    MessageBox.Show("Alterado com sucesso!");
                    Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastrarFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                idTextBox.Enabled = false;
                if (id == 0)
                {
                    label_TituloCadastrar_Fornecedor.Visible = true;
                    label2_TituloAlterar_Fornecedor.Visible = false;
                    fornecedorBindingSource.AddNew();
                }
                else
                {
                    label_TituloCadastrar_Fornecedor.Visible = false;
                    label2_TituloAlterar_Fornecedor.Visible = true;
                    fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(id);
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
