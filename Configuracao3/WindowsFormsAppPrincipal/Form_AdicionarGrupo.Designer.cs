namespace WindowsFormsAppPrincipal
{
    partial class Form_AdicionarGrupo
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
            this.button_Salvar_AdicionarGrupo = new System.Windows.Forms.Button();
            this.button_Cancelar_AdicaoGrupo = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(78, 81);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(85, 13);
            nomeGrupoLabel.TabIndex = 0;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(169, 78);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(291, 20);
            this.nomeGrupoTextBox.TabIndex = 1;
            // 
            // button_Salvar_AdicionarGrupo
            // 
            this.button_Salvar_AdicionarGrupo.Location = new System.Drawing.Point(369, 193);
            this.button_Salvar_AdicionarGrupo.Name = "button_Salvar_AdicionarGrupo";
            this.button_Salvar_AdicionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar_AdicionarGrupo.TabIndex = 2;
            this.button_Salvar_AdicionarGrupo.Text = "Salvar";
            this.button_Salvar_AdicionarGrupo.UseVisualStyleBackColor = true;
            this.button_Salvar_AdicionarGrupo.Click += new System.EventHandler(this.button_Salvar_AdicionarGrupo_Click);
            // 
            // button_Cancelar_AdicaoGrupo
            // 
            this.button_Cancelar_AdicaoGrupo.Location = new System.Drawing.Point(450, 193);
            this.button_Cancelar_AdicaoGrupo.Name = "button_Cancelar_AdicaoGrupo";
            this.button_Cancelar_AdicaoGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_AdicaoGrupo.TabIndex = 3;
            this.button_Cancelar_AdicaoGrupo.Text = "Cancelar";
            this.button_Cancelar_AdicaoGrupo.UseVisualStyleBackColor = true;
            this.button_Cancelar_AdicaoGrupo.Click += new System.EventHandler(this.button_Cancelar_AdicaoGrupo_Click);
            // 
            // Form_AdicionarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 228);
            this.Controls.Add(this.button_Cancelar_AdicaoGrupo);
            this.Controls.Add(this.button_Salvar_AdicionarGrupo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AdicionarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Grupo";
            this.Load += new System.EventHandler(this.Form_AdicionarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button button_Salvar_AdicionarGrupo;
        private System.Windows.Forms.Button button_Cancelar_AdicaoGrupo;
    }
}