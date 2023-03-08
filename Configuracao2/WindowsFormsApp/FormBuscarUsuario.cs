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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        
        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormCadastrarUsuario frm = new FormCadastrarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(FormAlterarUsuario frm = new FormAlterarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
