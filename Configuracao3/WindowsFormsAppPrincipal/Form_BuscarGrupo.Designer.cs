namespace WindowsFormsAppPrincipal
{
    partial class Form_BuscarGrupo
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
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_BuscarGrupo = new System.Windows.Forms.Button();
            this.button_AlterarGrupo = new System.Windows.Forms.Button();
            this.button_AdicionarGrupo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Adicionar_VincularPermissao = new System.Windows.Forms.Button();
            this.button_Excluir_VinculoPermissao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_BuscarTodos = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarId = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(12, 140);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(569, 341);
            this.grupoUsuarioDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(603, 140);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.Size = new System.Drawing.Size(429, 341);
            this.permissoesDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // button_BuscarGrupo
            // 
            this.button_BuscarGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.button_BuscarGrupo.Location = new System.Drawing.Point(263, 85);
            this.button_BuscarGrupo.Name = "button_BuscarGrupo";
            this.button_BuscarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarGrupo.TabIndex = 2;
            this.button_BuscarGrupo.Text = "Buscar";
            this.button_BuscarGrupo.UseVisualStyleBackColor = false;
            this.button_BuscarGrupo.Click += new System.EventHandler(this.button_BuscarGrupo_Click);
            // 
            // button_AlterarGrupo
            // 
            this.button_AlterarGrupo.Location = new System.Drawing.Point(344, 85);
            this.button_AlterarGrupo.Name = "button_AlterarGrupo";
            this.button_AlterarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarGrupo.TabIndex = 3;
            this.button_AlterarGrupo.Text = "Alterar";
            this.button_AlterarGrupo.UseVisualStyleBackColor = true;
            this.button_AlterarGrupo.Click += new System.EventHandler(this.button_AlterarGrupo_Click);
            // 
            // button_AdicionarGrupo
            // 
            this.button_AdicionarGrupo.Location = new System.Drawing.Point(425, 85);
            this.button_AdicionarGrupo.Name = "button_AdicionarGrupo";
            this.button_AdicionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_AdicionarGrupo.TabIndex = 4;
            this.button_AdicionarGrupo.Text = "Adicionar";
            this.button_AdicionarGrupo.UseVisualStyleBackColor = true;
            this.button_AdicionarGrupo.Click += new System.EventHandler(this.button_AdicionarGrupo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(506, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_Adicionar_VincularPermissao
            // 
            this.button_Adicionar_VincularPermissao.Location = new System.Drawing.Point(876, 111);
            this.button_Adicionar_VincularPermissao.Name = "button_Adicionar_VincularPermissao";
            this.button_Adicionar_VincularPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_Adicionar_VincularPermissao.TabIndex = 6;
            this.button_Adicionar_VincularPermissao.Text = "Adicionar";
            this.button_Adicionar_VincularPermissao.UseVisualStyleBackColor = true;
            this.button_Adicionar_VincularPermissao.Click += new System.EventHandler(this.button_Adicionar_VincularPermissao_Click);
            // 
            // button_Excluir_VinculoPermissao
            // 
            this.button_Excluir_VinculoPermissao.Location = new System.Drawing.Point(957, 111);
            this.button_Excluir_VinculoPermissao.Name = "button_Excluir_VinculoPermissao";
            this.button_Excluir_VinculoPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_VinculoPermissao.TabIndex = 7;
            this.button_Excluir_VinculoPermissao.Text = "Excluir";
            this.button_Excluir_VinculoPermissao.UseVisualStyleBackColor = true;
            this.button_Excluir_VinculoPermissao.Click += new System.EventHandler(this.button_Excluir_VinculoPermissao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 8;
            // 
            // radioButton_BuscarTodos
            // 
            this.radioButton_BuscarTodos.AutoSize = true;
            this.radioButton_BuscarTodos.Checked = true;
            this.radioButton_BuscarTodos.Location = new System.Drawing.Point(13, 63);
            this.radioButton_BuscarTodos.Name = "radioButton_BuscarTodos";
            this.radioButton_BuscarTodos.Size = new System.Drawing.Size(87, 17);
            this.radioButton_BuscarTodos.TabIndex = 9;
            this.radioButton_BuscarTodos.TabStop = true;
            this.radioButton_BuscarTodos.Text = "Buscar todos";
            this.radioButton_BuscarTodos.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome
            // 
            this.radioButton_BuscarPorNome.AutoSize = true;
            this.radioButton_BuscarPorNome.Location = new System.Drawing.Point(104, 63);
            this.radioButton_BuscarPorNome.Name = "radioButton_BuscarPorNome";
            this.radioButton_BuscarPorNome.Size = new System.Drawing.Size(91, 17);
            this.radioButton_BuscarPorNome.TabIndex = 10;
            this.radioButton_BuscarPorNome.Text = "Buscar/Nome";
            this.radioButton_BuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarId
            // 
            this.radioButton_BuscarId.AutoSize = true;
            this.radioButton_BuscarId.Location = new System.Drawing.Point(195, 63);
            this.radioButton_BuscarId.Name = "radioButton_BuscarId";
            this.radioButton_BuscarId.Size = new System.Drawing.Size(74, 17);
            this.radioButton_BuscarId.TabIndex = 11;
            this.radioButton_BuscarId.Text = "Buscar/ID";
            this.radioButton_BuscarId.UseVisualStyleBackColor = true;
            // 
            // Form_BuscarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 493);
            this.Controls.Add(this.radioButton_BuscarId);
            this.Controls.Add(this.radioButton_BuscarPorNome);
            this.Controls.Add(this.radioButton_BuscarTodos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Excluir_VinculoPermissao);
            this.Controls.Add(this.button_Adicionar_VincularPermissao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_AdicionarGrupo);
            this.Controls.Add(this.button_AlterarGrupo);
            this.Controls.Add(this.button_BuscarGrupo);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Name = "Form_BuscarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button_BuscarGrupo;
        private System.Windows.Forms.Button button_AlterarGrupo;
        private System.Windows.Forms.Button button_AdicionarGrupo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Adicionar_VincularPermissao;
        private System.Windows.Forms.Button button_Excluir_VinculoPermissao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodos;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome;
        private System.Windows.Forms.RadioButton radioButton_BuscarId;
    }
}