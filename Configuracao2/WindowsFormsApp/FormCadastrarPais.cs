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
    public partial class FormCadastrarPais : Form
    {
        public FormCadastrarPais()
        {
            InitializeComponent();
        }

        private void button_Buscar_Pais_Click(object sender, EventArgs e)
        {
            try
            {
                PaisBLL paisBLL = new PaisBLL();
                if (radioButton_BuscarTodos_Pais.Checked)
                {
                    paisBindingSource.DataSource = paisBLL.BuscarTodos_Pais();
                }
                else if (radioButton_BuscarPorNome_Pais.Checked)
                {
                    string _nomepais = textBox_Nome_Pais.Text;
                    paisBindingSource.DataSource = paisBLL.BuscarPorNome_Pais(_nomepais);
                }
                else if (radioButton_BuscarPorID_Pais.Checked)
                {
                    int _idpais = Convert.ToInt32(textBox_Nome_Pais.Text);
                    paisBindingSource.DataSource = paisBLL.BuscarPorId_Pais(_idpais);
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cadastrar_Pais_Click(object sender, EventArgs e)
        {
           

            try
            {
                PaisBLL paisBLL = new PaisBLL();
                string _nomepais = textBox_Cadastrar_Pais.Text;
                paisBLL.Inserir(_nomepais);
                MessageBox.Show("Cadastrado com Sucesso!");
               
                /*if (!alterar)
                {
                    permissaoBLL.Inserir(descricaoTextBox.Text, Convert.ToInt32(idTextBox.Text));
                    MessageBox.Show("Permissão cadastrada com sucesso!");
                    Close();
                }
                else
                {
                    permissaoBLL.Alterar((Permissao)permissaoBindingSource.Current);
                    MessageBox.Show("Permissão alterada com sucesso!");
                    Close();
                }
                */

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
