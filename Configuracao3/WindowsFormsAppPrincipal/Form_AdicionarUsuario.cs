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

namespace WindowsFormsAppPrincipal
{
    public partial class Form_AdicionarUsuario : Form
    {
        private bool alterar;
        public Form_AdicionarUsuario(bool _alterar = false, int _id_Usuario = 0)
        {
            InitializeComponent();
            alterar = _alterar;
            if (alterar)
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarUsuarioPorId(_id_Usuario);
                textBox_ConfirmacaoSenha.Text = ((Usuario)usuarioBindingSource.Current).Senha;
            }
        }

        private void button_Salvar_AdicionarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.EndEdit();

                if (!alterar)
                {
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, textBox_ConfirmacaoSenha.Text);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, textBox_ConfirmacaoSenha.Text);
                    MessageBox.Show("Alteração realizado com sucesso!");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form_AdicionarUsuario_Load(object sender, EventArgs e)// esse metodo foi criado na tela p/ quanddo abri pelo acionar o valor da variavel alterar seja falso
        {
            if (!alterar)// quando clikc adicionar o alterar por regra é falso. para que ele acione o novo registro ele tem que entrar no corpo do if,mas como por padrão
            {              //o alterar é falso não seria possivel ele fazer é procedimento, logo foi inserido uma função NOT (!) para converter o false para true
                usuarioBindingSource.AddNew();//Use o AddNew método para criar e inicializar um novo registro.
            }
        }

        private void button_Cancelar_AdicionarUsuario_Click(object sender, EventArgs e)
        {
            if (alterar)
            {
                MessageBox.Show("Alteração cancelada!");
                Close();
            }
            else
            {
                MessageBox.Show("Cadastro cancelado!");
                Close();
            }
        }
    }
}
