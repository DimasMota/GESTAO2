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
    public partial class FormCadastrarPermissao : Form
    {
        private bool alterar;
        public FormCadastrarPermissao(bool _alterar = false, int _idPermissao = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes_PorId(_idPermissao);
            }
        }

        private void button_SalvarCadastroPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (!alterar)
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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_CancelarCadastroPermissao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastrarPermissao_Load(object sender, EventArgs e)
        {
            if (!alterar)
            {
                permissaoBindingSource.AddNew();
            }
        }
    }
}
