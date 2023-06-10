using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public int Id;
        public FormPrincipal()
        {
            InitializeComponent();
            using (Form_Login frm = new Form_Login())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                {
                    Application.Exit();
                }
                else
                {
                   Id = frm.Id;
                    Constantes.IdUsuarioLogado = Id;
                }
            }
        }

      

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupo frm = new FormBuscarGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void permissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarPermissao frm = new FormBuscarPermissao()) { frm.ShowDialog(); }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente()) { frm.ShowDialog(); }
        }
    }
}
