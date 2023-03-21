﻿using BLL;
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
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                if (radioButton_BuscarTodasPermissoes.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes();
                }
                else if (radioButton_BuscarPorNome.Checked)
                {
                    permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissao_PorNome(textBox1.Text);
                }
                else if (radioButton_BuscarPorId.Checked)
                {
                   permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes_PorId(Convert.ToInt32(textBox1.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
