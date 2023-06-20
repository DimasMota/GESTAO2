namespace WindowsFormsApp
{
    partial class FormCadastrarPermissao
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.button_SalvarCadastroPermissao = new System.Windows.Forms.Button();
            this.button_CancelarCadastroPermissao = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(60, 123);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(155, 16);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição da permissão";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(194, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(221, 120);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(319, 22);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(221, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(127, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // button_SalvarCadastroPermissao
            // 
            this.button_SalvarCadastroPermissao.Location = new System.Drawing.Point(438, 200);
            this.button_SalvarCadastroPermissao.Name = "button_SalvarCadastroPermissao";
            this.button_SalvarCadastroPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_SalvarCadastroPermissao.TabIndex = 5;
            this.button_SalvarCadastroPermissao.Text = "Salvar";
            this.button_SalvarCadastroPermissao.UseVisualStyleBackColor = true;
            this.button_SalvarCadastroPermissao.Click += new System.EventHandler(this.button_SalvarCadastroPermissao_Click);
            // 
            // button_CancelarCadastroPermissao
            // 
            this.button_CancelarCadastroPermissao.Location = new System.Drawing.Point(538, 200);
            this.button_CancelarCadastroPermissao.Name = "button_CancelarCadastroPermissao";
            this.button_CancelarCadastroPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarCadastroPermissao.TabIndex = 6;
            this.button_CancelarCadastroPermissao.Text = "Cancelar";
            this.button_CancelarCadastroPermissao.UseVisualStyleBackColor = true;
            this.button_CancelarCadastroPermissao.Click += new System.EventHandler(this.button_CancelarCadastroPermissao_Click);
            // 
            // FormCadastrarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 235);
            this.Controls.Add(this.button_CancelarCadastroPermissao);
            this.Controls.Add(this.button_SalvarCadastroPermissao);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Name = "FormCadastrarPermissao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Permissão";
            this.Load += new System.EventHandler(this.FormCadastrarPermissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button button_SalvarCadastroPermissao;
        private System.Windows.Forms.Button button_CancelarCadastroPermissao;
    }
}