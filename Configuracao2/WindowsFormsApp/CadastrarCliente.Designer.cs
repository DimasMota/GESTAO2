namespace WindowsFormsApp
{
    partial class CadastrarCliente
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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label idLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.label_TituloCadastrar_Cliente = new System.Windows.Forms.Label();
            this.button_Salvar_Cliente = new System.Windows.Forms.Button();
            this.button_Cancelar_Cliente = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label_TituloAlterar_Cliente = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(38, 77);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(46, 111);
            cPFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(50, 151);
            rGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "RG:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(40, 184);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(42, 215);
            foneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(34, 13);
            foneLabel.TabIndex = 9;
            foneLabel.Text = "Fone:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(57, 54);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(77, 75);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(346, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(77, 109);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(170, 20);
            this.cPFTextBox.TabIndex = 4;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(77, 149);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(170, 20);
            this.rGTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(77, 181);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(346, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(77, 213);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(125, 20);
            this.foneTextBox.TabIndex = 10;
            // 
            // label_TituloCadastrar_Cliente
            // 
            this.label_TituloCadastrar_Cliente.AutoSize = true;
            this.label_TituloCadastrar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloCadastrar_Cliente.Location = new System.Drawing.Point(118, 9);
            this.label_TituloCadastrar_Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TituloCadastrar_Cliente.Name = "label_TituloCadastrar_Cliente";
            this.label_TituloCadastrar_Cliente.Size = new System.Drawing.Size(218, 26);
            this.label_TituloCadastrar_Cliente.TabIndex = 11;
            this.label_TituloCadastrar_Cliente.Text = "Cadastro de cliente";
            // 
            // button_Salvar_Cliente
            // 
            this.button_Salvar_Cliente.Location = new System.Drawing.Point(338, 254);
            this.button_Salvar_Cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Salvar_Cliente.Name = "button_Salvar_Cliente";
            this.button_Salvar_Cliente.Size = new System.Drawing.Size(56, 19);
            this.button_Salvar_Cliente.TabIndex = 12;
            this.button_Salvar_Cliente.Text = "Salvar";
            this.button_Salvar_Cliente.UseVisualStyleBackColor = true;
            this.button_Salvar_Cliente.Click += new System.EventHandler(this.button_Salvar_Cliente_Click);
            // 
            // button_Cancelar_Cliente
            // 
            this.button_Cancelar_Cliente.Location = new System.Drawing.Point(408, 254);
            this.button_Cancelar_Cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancelar_Cliente.Name = "button_Cancelar_Cliente";
            this.button_Cancelar_Cliente.Size = new System.Drawing.Size(56, 19);
            this.button_Cancelar_Cliente.TabIndex = 13;
            this.button_Cancelar_Cliente.Text = "Cancelar";
            this.button_Cancelar_Cliente.UseVisualStyleBackColor = true;
            this.button_Cancelar_Cliente.Click += new System.EventHandler(this.button_Cancelar_Cliente_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(77, 52);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(76, 20);
            this.idTextBox.TabIndex = 14;
            // 
            // label_TituloAlterar_Cliente
            // 
            this.label_TituloAlterar_Cliente.AutoSize = true;
            this.label_TituloAlterar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloAlterar_Cliente.Location = new System.Drawing.Point(146, 9);
            this.label_TituloAlterar_Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TituloAlterar_Cliente.Name = "label_TituloAlterar_Cliente";
            this.label_TituloAlterar_Cliente.Size = new System.Drawing.Size(160, 26);
            this.label_TituloAlterar_Cliente.TabIndex = 15;
            this.label_TituloAlterar_Cliente.Text = "Alterar cliente";
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 298);
            this.Controls.Add(this.label_TituloAlterar_Cliente);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button_Cancelar_Cliente);
            this.Controls.Add(this.button_Salvar_Cliente);
            this.Controls.Add(this.label_TituloCadastrar_Cliente);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CadastrarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.Label label_TituloCadastrar_Cliente;
        private System.Windows.Forms.Button button_Salvar_Cliente;
        private System.Windows.Forms.Button button_Cancelar_Cliente;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label_TituloAlterar_Cliente;
    }
}