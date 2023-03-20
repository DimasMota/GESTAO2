namespace WindowsFormsAppPrincipal
{
    partial class Form_BuscarUsuario
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
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton_BuscarTodos = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarNome = new System.Windows.Forms.RadioButton();
            this.radioButton_Buscar_NomeUsuario = new System.Windows.Forms.RadioButton();
            this.radioButton_Buscar_Id = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_BuscarUsuario = new System.Windows.Forms.Button();
            this.button_AlterarUsuario = new System.Windows.Forms.Button();
            this.button_AdicionarUsuario = new System.Windows.Forms.Button();
            this.button_ExcluirUsuario = new System.Windows.Forms.Button();
            this.button_Vincular_Grupo = new System.Windows.Forms.Button();
            this.button_ExcluirGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AllowUserToResizeRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 157);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.Size = new System.Drawing.Size(798, 335);
            this.usuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeUsuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data/Nasc.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cpf";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cpf";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(828, 157);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersVisible = false;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(300, 335);
            this.grupoUsuariosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.usuarioBindingSource;
            // 
            // radioButton_BuscarTodos
            // 
            this.radioButton_BuscarTodos.AutoSize = true;
            this.radioButton_BuscarTodos.Checked = true;
            this.radioButton_BuscarTodos.Location = new System.Drawing.Point(25, 98);
            this.radioButton_BuscarTodos.Name = "radioButton_BuscarTodos";
            this.radioButton_BuscarTodos.Size = new System.Drawing.Size(87, 17);
            this.radioButton_BuscarTodos.TabIndex = 3;
            this.radioButton_BuscarTodos.TabStop = true;
            this.radioButton_BuscarTodos.Text = "Buscar todos";
            this.radioButton_BuscarTodos.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarNome
            // 
            this.radioButton_BuscarNome.AutoSize = true;
            this.radioButton_BuscarNome.Location = new System.Drawing.Point(118, 98);
            this.radioButton_BuscarNome.Name = "radioButton_BuscarNome";
            this.radioButton_BuscarNome.Size = new System.Drawing.Size(91, 17);
            this.radioButton_BuscarNome.TabIndex = 4;
            this.radioButton_BuscarNome.Text = "Buscar/Nome";
            this.radioButton_BuscarNome.UseVisualStyleBackColor = true;
            // 
            // radioButton_Buscar_NomeUsuario
            // 
            this.radioButton_Buscar_NomeUsuario.AutoSize = true;
            this.radioButton_Buscar_NomeUsuario.Location = new System.Drawing.Point(215, 98);
            this.radioButton_Buscar_NomeUsuario.Name = "radioButton_Buscar_NomeUsuario";
            this.radioButton_Buscar_NomeUsuario.Size = new System.Drawing.Size(145, 17);
            this.radioButton_Buscar_NomeUsuario.TabIndex = 5;
            this.radioButton_Buscar_NomeUsuario.Text = "Buscar/Nome de Usuário";
            this.radioButton_Buscar_NomeUsuario.UseVisualStyleBackColor = true;
            // 
            // radioButton_Buscar_Id
            // 
            this.radioButton_Buscar_Id.AutoSize = true;
            this.radioButton_Buscar_Id.Location = new System.Drawing.Point(366, 98);
            this.radioButton_Buscar_Id.Name = "radioButton_Buscar_Id";
            this.radioButton_Buscar_Id.Size = new System.Drawing.Size(80, 17);
            this.radioButton_Buscar_Id.TabIndex = 6;
            this.radioButton_Buscar_Id.Text = "Buscar / ID";
            this.radioButton_Buscar_Id.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button_BuscarUsuario
            // 
            this.button_BuscarUsuario.Location = new System.Drawing.Point(461, 119);
            this.button_BuscarUsuario.Name = "button_BuscarUsuario";
            this.button_BuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarUsuario.TabIndex = 8;
            this.button_BuscarUsuario.Text = "Buscar";
            this.button_BuscarUsuario.UseVisualStyleBackColor = true;
            this.button_BuscarUsuario.Click += new System.EventHandler(this.button_BuscarUsuario_Click);
            // 
            // button_AlterarUsuario
            // 
            this.button_AlterarUsuario.Location = new System.Drawing.Point(542, 118);
            this.button_AlterarUsuario.Name = "button_AlterarUsuario";
            this.button_AlterarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarUsuario.TabIndex = 9;
            this.button_AlterarUsuario.Text = "Alterar";
            this.button_AlterarUsuario.UseVisualStyleBackColor = true;
            this.button_AlterarUsuario.Click += new System.EventHandler(this.button_AlterarUsuario_Click);
            // 
            // button_AdicionarUsuario
            // 
            this.button_AdicionarUsuario.Location = new System.Drawing.Point(623, 118);
            this.button_AdicionarUsuario.Name = "button_AdicionarUsuario";
            this.button_AdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_AdicionarUsuario.TabIndex = 10;
            this.button_AdicionarUsuario.Text = "Adicionar";
            this.button_AdicionarUsuario.UseVisualStyleBackColor = true;
            this.button_AdicionarUsuario.Click += new System.EventHandler(this.button_AdicionarUsuario_Click);
            // 
            // button_ExcluirUsuario
            // 
            this.button_ExcluirUsuario.Location = new System.Drawing.Point(704, 118);
            this.button_ExcluirUsuario.Name = "button_ExcluirUsuario";
            this.button_ExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.button_ExcluirUsuario.TabIndex = 11;
            this.button_ExcluirUsuario.Text = "Excluir";
            this.button_ExcluirUsuario.UseVisualStyleBackColor = true;
            this.button_ExcluirUsuario.Click += new System.EventHandler(this.button_ExcluirUsuario_Click);
            // 
            // button_Vincular_Grupo
            // 
            this.button_Vincular_Grupo.Location = new System.Drawing.Point(955, 121);
            this.button_Vincular_Grupo.Name = "button_Vincular_Grupo";
            this.button_Vincular_Grupo.Size = new System.Drawing.Size(75, 23);
            this.button_Vincular_Grupo.TabIndex = 12;
            this.button_Vincular_Grupo.Text = "Adicionar";
            this.button_Vincular_Grupo.UseVisualStyleBackColor = true;
            this.button_Vincular_Grupo.Click += new System.EventHandler(this.button_Vincular_Grupo_Click);
            // 
            // button_ExcluirGrupo
            // 
            this.button_ExcluirGrupo.Location = new System.Drawing.Point(1036, 121);
            this.button_ExcluirGrupo.Name = "button_ExcluirGrupo";
            this.button_ExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.button_ExcluirGrupo.TabIndex = 13;
            this.button_ExcluirGrupo.Text = "Remover";
            this.button_ExcluirGrupo.UseVisualStyleBackColor = true;
            this.button_ExcluirGrupo.Click += new System.EventHandler(this.button_ExcluirGrupo_Click);
            // 
            // Form_BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1140, 512);
            this.Controls.Add(this.button_ExcluirGrupo);
            this.Controls.Add(this.button_Vincular_Grupo);
            this.Controls.Add(this.button_ExcluirUsuario);
            this.Controls.Add(this.button_AdicionarUsuario);
            this.Controls.Add(this.button_AlterarUsuario);
            this.Controls.Add(this.button_BuscarUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton_Buscar_Id);
            this.Controls.Add(this.radioButton_Buscar_NomeUsuario);
            this.Controls.Add(this.radioButton_BuscarNome);
            this.Controls.Add(this.radioButton_BuscarTodos);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.usuarioDataGridView);
            this.Name = "Form_BuscarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestão - Buscar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodos;
        private System.Windows.Forms.RadioButton radioButton_BuscarNome;
        private System.Windows.Forms.RadioButton radioButton_Buscar_NomeUsuario;
        private System.Windows.Forms.RadioButton radioButton_Buscar_Id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_BuscarUsuario;
        private System.Windows.Forms.Button button_AlterarUsuario;
        private System.Windows.Forms.Button button_AdicionarUsuario;
        private System.Windows.Forms.Button button_ExcluirUsuario;
        private System.Windows.Forms.Button button_Vincular_Grupo;
        private System.Windows.Forms.Button button_ExcluirGrupo;
    }
}