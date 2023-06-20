namespace WindowsFormsApp
{
    partial class FormCadastrarFornecedor
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
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label siteLabel;
            System.Windows.Forms.Label emailLabel;
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label_TituloCadastrar_Fornecedor = new System.Windows.Forms.Label();
            this.label2_TituloAlterar_Fornecedor = new System.Windows.Forms.Label();
            this.button_Salvar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Cancelar_Fornecedor = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            siteLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(188, 126);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(687, 126);
            foneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(41, 16);
            foneLabel.TabIndex = 3;
            foneLabel.Text = "Fone:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 122);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new System.Drawing.Point(15, 185);
            siteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new System.Drawing.Size(33, 16);
            siteLabel.TabIndex = 7;
            siteLabel.Text = "Site:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(512, 185);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(247, 122);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(411, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(740, 122);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(196, 22);
            this.foneTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(60, 118);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(99, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // siteTextBox
            // 
            this.siteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Site", true));
            this.siteTextBox.Location = new System.Drawing.Point(60, 181);
            this.siteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(427, 22);
            this.siteTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(567, 181);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(369, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // label_TituloCadastrar_Fornecedor
            // 
            this.label_TituloCadastrar_Fornecedor.AutoSize = true;
            this.label_TituloCadastrar_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloCadastrar_Fornecedor.Location = new System.Drawing.Point(392, 11);
            this.label_TituloCadastrar_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TituloCadastrar_Fornecedor.Name = "label_TituloCadastrar_Fornecedor";
            this.label_TituloCadastrar_Fornecedor.Size = new System.Drawing.Size(269, 29);
            this.label_TituloCadastrar_Fornecedor.TabIndex = 11;
            this.label_TituloCadastrar_Fornecedor.Text = "Cadastrar Fornecedor";
            // 
            // label2_TituloAlterar_Fornecedor
            // 
            this.label2_TituloAlterar_Fornecedor.AutoSize = true;
            this.label2_TituloAlterar_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_TituloAlterar_Fornecedor.Location = new System.Drawing.Point(409, 11);
            this.label2_TituloAlterar_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_TituloAlterar_Fornecedor.Name = "label2_TituloAlterar_Fornecedor";
            this.label2_TituloAlterar_Fornecedor.Size = new System.Drawing.Size(233, 29);
            this.label2_TituloAlterar_Fornecedor.TabIndex = 12;
            this.label2_TituloAlterar_Fornecedor.Text = "Alterar Fornecedor";
            // 
            // button_Salvar_Fornecedor
            // 
            this.button_Salvar_Fornecedor.Location = new System.Drawing.Point(633, 250);
            this.button_Salvar_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Salvar_Fornecedor.Name = "button_Salvar_Fornecedor";
            this.button_Salvar_Fornecedor.Size = new System.Drawing.Size(135, 28);
            this.button_Salvar_Fornecedor.TabIndex = 13;
            this.button_Salvar_Fornecedor.Text = "Salvar";
            this.button_Salvar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Salvar_Fornecedor.Click += new System.EventHandler(this.button_Salvar_Fornecedor_Click);
            // 
            // button_Cancelar_Fornecedor
            // 
            this.button_Cancelar_Fornecedor.Location = new System.Drawing.Point(807, 250);
            this.button_Cancelar_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Cancelar_Fornecedor.Name = "button_Cancelar_Fornecedor";
            this.button_Cancelar_Fornecedor.Size = new System.Drawing.Size(131, 28);
            this.button_Cancelar_Fornecedor.TabIndex = 14;
            this.button_Cancelar_Fornecedor.Text = "Cancelar";
            this.button_Cancelar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Cancelar_Fornecedor.Click += new System.EventHandler(this.button_Cancelar_Fornecedor_Click);
            // 
            // FormCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 293);
            this.Controls.Add(this.button_Cancelar_Fornecedor);
            this.Controls.Add(this.button_Salvar_Fornecedor);
            this.Controls.Add(this.label2_TituloAlterar_Fornecedor);
            this.Controls.Add(this.label_TituloCadastrar_Fornecedor);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(siteLabel);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCadastrarFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FormCadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label_TituloCadastrar_Fornecedor;
        private System.Windows.Forms.Label label2_TituloAlterar_Fornecedor;
        private System.Windows.Forms.Button button_Salvar_Fornecedor;
        private System.Windows.Forms.Button button_Cancelar_Fornecedor;
    }
}