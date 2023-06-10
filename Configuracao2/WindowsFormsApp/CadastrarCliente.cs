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
        private bool alterar;
        public CadastrarCliente(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(_id);
                
            }
        }

        private void button_Salvar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
               clienteBindingSource.EndEdit();
                ClienteBLL clienteBLL = new ClienteBLL();
                if (!alterar)
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
    }
}
