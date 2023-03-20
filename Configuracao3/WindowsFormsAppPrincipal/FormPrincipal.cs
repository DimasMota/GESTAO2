using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_BuscarUsuario frm = new Form_BuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void grupoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Form_BuscarGrupo frm = new Form_BuscarGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void permissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_BuscarPermissao frm = new Form_BuscarPermissao())
            {
                frm.ShowDialog();
            }
        }
    }
}
