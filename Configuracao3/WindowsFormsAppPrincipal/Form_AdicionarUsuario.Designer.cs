namespace WindowsFormsAppPrincipal
{
    partial class Form_AdicionarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label ativoLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.button_Salvar_AdicionarUsuario = new System.Windows.Forms.Button();
            this.button_Cancelar_AdicionarUsuario = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 44);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(496, 40);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 4;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(8, 93);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(26, 13);
            cpfLabel.TabIndex = 6;
            cpfLabel.Text = "Cpf:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(235, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(512, 96);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel.TabIndex = 10;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(35, 132);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 12;
            senhaLabel.Text = "Senha:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(475, 132);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 16;
            ativoLabel.Text = "Ativo:";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(50, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(425, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // dataNascimentoTextBox
            // 
            this.dataNascimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "DataNascimento", true));
            this.dataNascimentoTextBox.Location = new System.Drawing.Point(594, 37);
            this.dataNascimentoTextBox.Name = "dataNascimentoTextBox";
            this.dataNascimentoTextBox.Size = new System.Drawing.Size(101, 20);
            this.dataNascimentoTextBox.TabIndex = 5;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(40, 90);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(183, 20);
            this.cpfTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(274, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(595, 93);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeUsuarioTextBox.TabIndex = 11;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(82, 129);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 13;
            // 
            // textBox_ConfirmacaoSenha
            // 
            this.textBox_ConfirmacaoSenha.Location = new System.Drawing.Point(300, 129);
            this.textBox_ConfirmacaoSenha.Name = "textBox_ConfirmacaoSenha";
            this.textBox_ConfirmacaoSenha.Size = new System.Drawing.Size(100, 20);
            this.textBox_ConfirmacaoSenha.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirmar senha";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(515, 122);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(33, 34);
            this.ativoCheckBox.TabIndex = 17;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // button_Salvar_AdicionarUsuario
            // 
            this.button_Salvar_AdicionarUsuario.Location = new System.Drawing.Point(539, 202);
            this.button_Salvar_AdicionarUsuario.Name = "button_Salvar_AdicionarUsuario";
            this.button_Salvar_AdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar_AdicionarUsuario.TabIndex = 18;
            this.button_Salvar_AdicionarUsuario.Text = "Salvar";
            this.button_Salvar_AdicionarUsuario.UseVisualStyleBackColor = true;
            this.button_Salvar_AdicionarUsuario.Click += new System.EventHandler(this.button_Salvar_AdicionarUsuario_Click);
            // 
            // button_Cancelar_AdicionarUsuario
            // 
            this.button_Cancelar_AdicionarUsuario.Location = new System.Drawing.Point(620, 202);
            this.button_Cancelar_AdicionarUsuario.Name = "button_Cancelar_AdicionarUsuario";
            this.button_Cancelar_AdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_AdicionarUsuario.TabIndex = 19;
            this.button_Cancelar_AdicionarUsuario.Text = "Cancelar";
            this.button_Cancelar_AdicionarUsuario.UseVisualStyleBackColor = true;
            this.button_Cancelar_AdicionarUsuario.Click += new System.EventHandler(this.button_Cancelar_AdicionarUsuario_Click);
            // 
            // Form_AdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 237);
            this.Controls.Add(this.button_Cancelar_AdicionarUsuario);
            this.Controls.Add(this.button_Salvar_AdicionarUsuario);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ConfirmacaoSenha);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "Form_AdicionarUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.Form_AdicionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox dataNascimentoTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox textBox_ConfirmacaoSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Button button_Salvar_AdicionarUsuario;
        private System.Windows.Forms.Button button_Cancelar_AdicionarUsuario;
    }
}