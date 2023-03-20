namespace WindowsFormsAppPrincipal
{
    partial class Form_VincularUsuarioGrupo
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
            this.button_BuscarGrupos = new System.Windows.Forms.Button();
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_SelecionarGrupo = new System.Windows.Forms.Button();
            this.button_CancelarVinculacao = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(19, 100);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(85, 13);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // button_BuscarGrupos
            // 
            this.button_BuscarGrupos.Location = new System.Drawing.Point(458, 94);
            this.button_BuscarGrupos.Name = "button_BuscarGrupos";
            this.button_BuscarGrupos.Size = new System.Drawing.Size(65, 23);
            this.button_BuscarGrupos.TabIndex = 3;
            this.button_BuscarGrupos.Text = "Buscar";
            this.button_BuscarGrupos.UseVisualStyleBackColor = true;
            this.button_BuscarGrupos.Click += new System.EventHandler(this.button_BuscarGrupos_Click);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(22, 123);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(501, 325);
            this.grupoUsuarioDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button_SelecionarGrupo
            // 
            this.button_SelecionarGrupo.Location = new System.Drawing.Point(380, 469);
            this.button_SelecionarGrupo.Name = "button_SelecionarGrupo";
            this.button_SelecionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_SelecionarGrupo.TabIndex = 5;
            this.button_SelecionarGrupo.Text = "Selecionar";
            this.button_SelecionarGrupo.UseVisualStyleBackColor = true;
            this.button_SelecionarGrupo.Click += new System.EventHandler(this.button_SelecionarGrupo_Click);
            // 
            // button_CancelarVinculacao
            // 
            this.button_CancelarVinculacao.Location = new System.Drawing.Point(476, 469);
            this.button_CancelarVinculacao.Name = "button_CancelarVinculacao";
            this.button_CancelarVinculacao.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarVinculacao.TabIndex = 6;
            this.button_CancelarVinculacao.Text = "Cancelar";
            this.button_CancelarVinculacao.UseVisualStyleBackColor = true;
            this.button_CancelarVinculacao.Click += new System.EventHandler(this.button_CancelarVinculacao_Click);
            // 
            // Form_VincularUsuarioGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 504);
            this.Controls.Add(this.button_CancelarVinculacao);
            this.Controls.Add(this.button_SelecionarGrupo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Controls.Add(this.button_BuscarGrupos);
            this.Controls.Add(nomeGrupoLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_VincularUsuarioGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vincular Usuário/Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.Button button_BuscarGrupos;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_SelecionarGrupo;
        private System.Windows.Forms.Button button_CancelarVinculacao;
    }
}