namespace WindowsFormsApp
{
    partial class FormCadastrarGrupo
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
            System.Windows.Forms.Label nomeGrupoLabel;
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.button_Salvar_CadastrarGrupo = new System.Windows.Forms.Button();
            this.button_CancelarCadastro = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(70, 101);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(87, 16);
            nomeGrupoLabel.TabIndex = 0;
            nomeGrupoLabel.Text = "Nome Grupo:";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(163, 98);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(295, 22);
            this.nomeGrupoTextBox.TabIndex = 1;
            // 
            // button_Salvar_CadastrarGrupo
            // 
            this.button_Salvar_CadastrarGrupo.Location = new System.Drawing.Point(163, 161);
            this.button_Salvar_CadastrarGrupo.Name = "button_Salvar_CadastrarGrupo";
            this.button_Salvar_CadastrarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar_CadastrarGrupo.TabIndex = 2;
            this.button_Salvar_CadastrarGrupo.Text = "Salvar";
            this.button_Salvar_CadastrarGrupo.UseVisualStyleBackColor = true;
            this.button_Salvar_CadastrarGrupo.Click += new System.EventHandler(this.button_Salvar_CadastrarGrupo_Click);
            // 
            // button_CancelarCadastro
            // 
            this.button_CancelarCadastro.Location = new System.Drawing.Point(327, 161);
            this.button_CancelarCadastro.Name = "button_CancelarCadastro";
            this.button_CancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarCadastro.TabIndex = 3;
            this.button_CancelarCadastro.Text = "Cancelar";
            this.button_CancelarCadastro.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 254);
            this.Controls.Add(this.button_CancelarCadastro);
            this.Controls.Add(this.button_Salvar_CadastrarGrupo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Name = "FormCadastrarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Grupo";
            this.Load += new System.EventHandler(this.FormCadastrarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button button_Salvar_CadastrarGrupo;
        private System.Windows.Forms.Button button_CancelarCadastro;
    }
}