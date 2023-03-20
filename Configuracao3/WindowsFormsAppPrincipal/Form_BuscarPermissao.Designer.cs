namespace WindowsFormsAppPrincipal
{
    partial class Form_BuscarPermissao
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
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_BuscarPemissoes = new System.Windows.Forms.Button();
            this.button_AlterarPemissoes = new System.Windows.Forms.Button();
            this.button_AdicionarPermissoes = new System.Windows.Forms.Button();
            this.button_ExcluirPermissoes = new System.Windows.Forms.Button();
            this.button_AdicionarGrupo_EmPermissoes = new System.Windows.Forms.Button();
            this.button_ExcluirGrupo_DePermissoes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton_BuscarTodasPermissoes = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorId = new System.Windows.Forms.RadioButton();
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // button_BuscarPemissoes
            // 
            this.button_BuscarPemissoes.Location = new System.Drawing.Point(356, 113);
            this.button_BuscarPemissoes.Name = "button_BuscarPemissoes";
            this.button_BuscarPemissoes.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarPemissoes.TabIndex = 0;
            this.button_BuscarPemissoes.Text = "Buscar";
            this.button_BuscarPemissoes.UseVisualStyleBackColor = true;
            this.button_BuscarPemissoes.Click += new System.EventHandler(this.button_BuscarPemissoes_Click);
            // 
            // button_AlterarPemissoes
            // 
            this.button_AlterarPemissoes.Location = new System.Drawing.Point(437, 113);
            this.button_AlterarPemissoes.Name = "button_AlterarPemissoes";
            this.button_AlterarPemissoes.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarPemissoes.TabIndex = 1;
            this.button_AlterarPemissoes.Text = "Alterar";
            this.button_AlterarPemissoes.UseVisualStyleBackColor = true;
            // 
            // button_AdicionarPermissoes
            // 
            this.button_AdicionarPermissoes.Location = new System.Drawing.Point(518, 113);
            this.button_AdicionarPermissoes.Name = "button_AdicionarPermissoes";
            this.button_AdicionarPermissoes.Size = new System.Drawing.Size(75, 23);
            this.button_AdicionarPermissoes.TabIndex = 2;
            this.button_AdicionarPermissoes.Text = "Adicionar";
            this.button_AdicionarPermissoes.UseVisualStyleBackColor = true;
            // 
            // button_ExcluirPermissoes
            // 
            this.button_ExcluirPermissoes.Location = new System.Drawing.Point(599, 113);
            this.button_ExcluirPermissoes.Name = "button_ExcluirPermissoes";
            this.button_ExcluirPermissoes.Size = new System.Drawing.Size(75, 23);
            this.button_ExcluirPermissoes.TabIndex = 3;
            this.button_ExcluirPermissoes.Text = "Excluir";
            this.button_ExcluirPermissoes.UseVisualStyleBackColor = true;
            // 
            // button_AdicionarGrupo_EmPermissoes
            // 
            this.button_AdicionarGrupo_EmPermissoes.Location = new System.Drawing.Point(898, 113);
            this.button_AdicionarGrupo_EmPermissoes.Name = "button_AdicionarGrupo_EmPermissoes";
            this.button_AdicionarGrupo_EmPermissoes.Size = new System.Drawing.Size(75, 23);
            this.button_AdicionarGrupo_EmPermissoes.TabIndex = 4;
            this.button_AdicionarGrupo_EmPermissoes.Text = "Adicionar";
            this.button_AdicionarGrupo_EmPermissoes.UseVisualStyleBackColor = true;
            // 
            // button_ExcluirGrupo_DePermissoes
            // 
            this.button_ExcluirGrupo_DePermissoes.Location = new System.Drawing.Point(979, 113);
            this.button_ExcluirGrupo_DePermissoes.Name = "button_ExcluirGrupo_DePermissoes";
            this.button_ExcluirGrupo_DePermissoes.Size = new System.Drawing.Size(75, 23);
            this.button_ExcluirGrupo_DePermissoes.TabIndex = 5;
            this.button_ExcluirGrupo_DePermissoes.Text = "Excluir";
            this.button_ExcluirGrupo_DePermissoes.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 6;
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(10, 160);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.Size = new System.Drawing.Size(664, 300);
            this.permissaoDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Permissão(Descrição)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.permissaoBindingSource;
            // 
            // radioButton_BuscarTodasPermissoes
            // 
            this.radioButton_BuscarTodasPermissoes.AutoSize = true;
            this.radioButton_BuscarTodasPermissoes.Checked = true;
            this.radioButton_BuscarTodasPermissoes.Location = new System.Drawing.Point(12, 93);
            this.radioButton_BuscarTodasPermissoes.Name = "radioButton_BuscarTodasPermissoes";
            this.radioButton_BuscarTodasPermissoes.Size = new System.Drawing.Size(87, 17);
            this.radioButton_BuscarTodasPermissoes.TabIndex = 9;
            this.radioButton_BuscarTodasPermissoes.TabStop = true;
            this.radioButton_BuscarTodasPermissoes.Text = "Buscar todas";
            this.radioButton_BuscarTodasPermissoes.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome
            // 
            this.radioButton_BuscarPorNome.AutoSize = true;
            this.radioButton_BuscarPorNome.Location = new System.Drawing.Point(131, 93);
            this.radioButton_BuscarPorNome.Name = "radioButton_BuscarPorNome";
            this.radioButton_BuscarPorNome.Size = new System.Drawing.Size(97, 17);
            this.radioButton_BuscarPorNome.TabIndex = 10;
            this.radioButton_BuscarPorNome.Text = "Buscar / Nome";
            this.radioButton_BuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorId
            // 
            this.radioButton_BuscarPorId.AutoSize = true;
            this.radioButton_BuscarPorId.Location = new System.Drawing.Point(255, 93);
            this.radioButton_BuscarPorId.Name = "radioButton_BuscarPorId";
            this.radioButton_BuscarPorId.Size = new System.Drawing.Size(80, 17);
            this.radioButton_BuscarPorId.TabIndex = 11;
            this.radioButton_BuscarPorId.Text = "Buscar / ID";
            this.radioButton_BuscarPorId.UseVisualStyleBackColor = true;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(695, 160);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersVisible = false;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(389, 300);
            this.grupoUsuariosDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Form_BuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 480);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.radioButton_BuscarPorId);
            this.Controls.Add(this.radioButton_BuscarPorNome);
            this.Controls.Add(this.radioButton_BuscarTodasPermissoes);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ExcluirGrupo_DePermissoes);
            this.Controls.Add(this.button_AdicionarGrupo_EmPermissoes);
            this.Controls.Add(this.button_ExcluirPermissoes);
            this.Controls.Add(this.button_AdicionarPermissoes);
            this.Controls.Add(this.button_AlterarPemissoes);
            this.Controls.Add(this.button_BuscarPemissoes);
            this.Name = "Form_BuscarPermissao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.Button button_BuscarPemissoes;
        private System.Windows.Forms.Button button_AlterarPemissoes;
        private System.Windows.Forms.Button button_AdicionarPermissoes;
        private System.Windows.Forms.Button button_ExcluirPermissoes;
        private System.Windows.Forms.Button button_AdicionarGrupo_EmPermissoes;
        private System.Windows.Forms.Button button_ExcluirGrupo_DePermissoes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodasPermissoes;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorId;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}