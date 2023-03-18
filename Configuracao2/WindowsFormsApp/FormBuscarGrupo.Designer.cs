namespace WindowsFormsApp
{
    partial class FormBuscarGrupo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarGrupo = new System.Windows.Forms.Button();
            this.buttonExcluirGrupo = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupo = new System.Windows.Forms.Button();
            this.buttonAlterarGrupo = new System.Windows.Forms.Button();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.radioButtonBuscarTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarNome = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarID = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 22);
            this.textBox1.TabIndex = 0;
            // 
            // buttonBuscarGrupo
            // 
            this.buttonBuscarGrupo.Location = new System.Drawing.Point(529, 80);
            this.buttonBuscarGrupo.Name = "buttonBuscarGrupo";
            this.buttonBuscarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarGrupo.TabIndex = 1;
            this.buttonBuscarGrupo.Text = "Buscar";
            this.buttonBuscarGrupo.UseVisualStyleBackColor = true;
            this.buttonBuscarGrupo.Click += new System.EventHandler(this.buttonBuscarGrupo_Click);
            // 
            // buttonExcluirGrupo
            // 
            this.buttonExcluirGrupo.Location = new System.Drawing.Point(772, 80);
            this.buttonExcluirGrupo.Name = "buttonExcluirGrupo";
            this.buttonExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirGrupo.TabIndex = 2;
            this.buttonExcluirGrupo.Text = "Excluir";
            this.buttonExcluirGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarGrupo
            // 
            this.buttonAdicionarGrupo.Location = new System.Drawing.Point(691, 80);
            this.buttonAdicionarGrupo.Name = "buttonAdicionarGrupo";
            this.buttonAdicionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarGrupo.TabIndex = 3;
            this.buttonAdicionarGrupo.Text = "Adicionar";
            this.buttonAdicionarGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupo.Click += new System.EventHandler(this.buttonAdicionarGrupo_Click);
            // 
            // buttonAlterarGrupo
            // 
            this.buttonAlterarGrupo.Location = new System.Drawing.Point(610, 80);
            this.buttonAlterarGrupo.Name = "buttonAlterarGrupo";
            this.buttonAlterarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarGrupo.TabIndex = 4;
            this.buttonAlterarGrupo.Text = "Alterar";
            this.buttonAlterarGrupo.UseVisualStyleBackColor = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
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
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(21, 156);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(583, 404);
            this.grupoUsuarioDataGridView.TabIndex = 6;
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
            this.permissoesDataGridView.Location = new System.Drawing.Point(619, 156);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(453, 404);
            this.permissoesDataGridView.TabIndex = 7;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(916, 127);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 8;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(997, 127);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissao.TabIndex = 9;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarTodos
            // 
            this.radioButtonBuscarTodos.AutoSize = true;
            this.radioButtonBuscarTodos.Location = new System.Drawing.Point(21, 54);
            this.radioButtonBuscarTodos.Name = "radioButtonBuscarTodos";
            this.radioButtonBuscarTodos.Size = new System.Drawing.Size(113, 20);
            this.radioButtonBuscarTodos.TabIndex = 10;
            this.radioButtonBuscarTodos.TabStop = true;
            this.radioButtonBuscarTodos.Text = "Buscar Todos";
            this.radioButtonBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarNome
            // 
            this.radioButtonBuscarNome.AutoSize = true;
            this.radioButtonBuscarNome.Location = new System.Drawing.Point(140, 54);
            this.radioButtonBuscarNome.Name = "radioButtonBuscarNome";
            this.radioButtonBuscarNome.Size = new System.Drawing.Size(111, 20);
            this.radioButtonBuscarNome.TabIndex = 11;
            this.radioButtonBuscarNome.TabStop = true;
            this.radioButtonBuscarNome.Text = "Buscar/Nome";
            this.radioButtonBuscarNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarID
            // 
            this.radioButtonBuscarID.AutoSize = true;
            this.radioButtonBuscarID.Location = new System.Drawing.Point(274, 54);
            this.radioButtonBuscarID.Name = "radioButtonBuscarID";
            this.radioButtonBuscarID.Size = new System.Drawing.Size(87, 20);
            this.radioButtonBuscarID.TabIndex = 12;
            this.radioButtonBuscarID.TabStop = true;
            this.radioButtonBuscarID.Text = "Buscar/ID";
            this.radioButtonBuscarID.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Permissão(Descrição)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FormBuscarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 572);
            this.Controls.Add(this.radioButtonBuscarID);
            this.Controls.Add(this.radioButtonBuscarNome);
            this.Controls.Add(this.radioButtonBuscarTodos);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Controls.Add(this.buttonAlterarGrupo);
            this.Controls.Add(this.buttonAdicionarGrupo);
            this.Controls.Add(this.buttonExcluirGrupo);
            this.Controls.Add(this.buttonBuscarGrupo);
            this.Controls.Add(this.textBox1);
            this.Name = "FormBuscarGrupo";
            this.Text = "Gestão de Grupo de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscarGrupo;
        private System.Windows.Forms.Button buttonExcluirGrupo;
        private System.Windows.Forms.Button buttonAdicionarGrupo;
        private System.Windows.Forms.Button buttonAlterarGrupo;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.RadioButton radioButtonBuscarTodos;
        private System.Windows.Forms.RadioButton radioButtonBuscarNome;
        private System.Windows.Forms.RadioButton radioButtonBuscarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}