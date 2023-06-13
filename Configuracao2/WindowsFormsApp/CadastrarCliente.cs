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
    public partial class CadastrarCliente : Form
    {
        int id;
        public CadastrarCliente(int _id = 0)
        {
            InitializeComponent();
            
          
           id = _id;   
            
        }

        private void button_Salvar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
               clienteBindingSource.EndEdit();
                ClienteBLL clienteBLL = new ClienteBLL();

               

                if (id == 0)
                {
                   clienteBLL.Inserir((Cliente)clienteBindingSource.Current);
                MessageBox.Show("Cadastrado com sucesso!");
                Close(); 
                }
                else
                {
                    clienteBLL.Alterar((Cliente)clienteBindingSource.Current);
                    MessageBox.Show("Alterado com sucesso!");
                    Close();

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    clienteBindingSource.AddNew();
                }
                else
                {
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(id);
                }
                
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancelar_Cliente_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
               MessageBox.Show("Cadastro Cancelado!");
               Close();
            }
            else
            {
                MessageBox.Show("Alteração do Cadastro Cancelado!");
                Close();

            }
            
        }
    }
}
