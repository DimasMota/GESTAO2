namespace WindowsFormsApp
{
    partial class FormAdicionarGrupo
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
            this.buttonSalvarCadastroGrupo = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroGrupo = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(50, 112);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(87, 16);
            nomeGrupoLabel.TabIndex = 3;
            nomeGrupoLabel.Text = "Nome Grupo:";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(143, 109);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(295, 22);
            this.nomeGrupoTextBox.TabIndex = 4;
            // 
            // buttonSalvarCadastroGrupo
            // 
            this.buttonSalvarCadastroGrupo.Location = new System.Drawing.Point(119, 181);
            this.buttonSalvarCadastroGrupo.Name = "buttonSalvarCadastroGrupo";
            this.buttonSalvarCadastroGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarCadastroGrupo.TabIndex = 5;
            this.buttonSalvarCadastroGrupo.Text = "Salvar";
            this.buttonSalvarCadastroGrupo.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroGrupo.Click += new System.EventHandler(this.buttonSalvarCadastroGrupo_Click);
            // 
            // buttonCancelarCadastroGrupo
            // 
            this.buttonCancelarCadastroGrupo.Location = new System.Drawing.Point(266, 181);
            this.buttonCancelarCadastroGrupo.Name = "buttonCancelarCadastroGrupo";
            this.buttonCancelarCadastroGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCadastroGrupo.TabIndex = 6;
            this.buttonCancelarCadastroGrupo.Text = "Cancelar";
            this.buttonCancelarCadastroGrupo.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 279);
            this.Controls.Add(this.buttonCancelarCadastroGrupo);
            this.Controls.Add(this.buttonSalvarCadastroGrupo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Name = "FormAdicionarGrupo";
            this.Text = "Gestão - Cadastrar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonSalvarCadastroGrupo;
        private System.Windows.Forms.Button buttonCancelarCadastroGrupo;
    }
}