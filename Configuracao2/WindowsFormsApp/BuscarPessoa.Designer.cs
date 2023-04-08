namespace WindowsFormsApp
{
    partial class BuscarPessoa
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
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgaoExpedidorRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_EstadoRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataExpedicaoRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_BuscarPessoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_BuscaPessoa = new System.Windows.Forms.TextBox();
            this.radioButton_BuscarTodasPessoas = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPor_Nome = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPor_CPF = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPor_ID = new System.Windows.Forms.RadioButton();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Models.Pessoa);
            // 
            // pessoaDataGridView
            // 
            this.pessoaDataGridView.AllowUserToAddRows = false;
            this.pessoaDataGridView.AllowUserToDeleteRows = false;
            this.pessoaDataGridView.AllowUserToOrderColumns = true;
            this.pessoaDataGridView.AutoGenerateColumns = false;
            this.pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.RG,
            this.dataGridViewTextBoxColumn5,
            this.OrgaoExpedidorRG,
            this.cod_EstadoRG,
            this.DataExpedicaoRG,
            this.dataGridViewTextBoxColumn11});
            this.pessoaDataGridView.DataSource = this.pessoaBindingSource;
            this.pessoaDataGridView.Location = new System.Drawing.Point(12, 209);
            this.pessoaDataGridView.Name = "pessoaDataGridView";
            this.pessoaDataGridView.ReadOnly = true;
            this.pessoaDataGridView.RowHeadersVisible = false;
            this.pessoaDataGridView.Size = new System.Drawing.Size(781, 446);
            this.pessoaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Pessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sobrenome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataDeNascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Nasc.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // OrgaoExpedidorRG
            // 
            this.OrgaoExpedidorRG.DataPropertyName = "OrgaoExpedidorRG";
            this.OrgaoExpedidorRG.HeaderText = "OrgaoExpedidorRG";
            this.OrgaoExpedidorRG.Name = "OrgaoExpedidorRG";
            this.OrgaoExpedidorRG.ReadOnly = true;
            // 
            // cod_EstadoRG
            // 
            this.cod_EstadoRG.DataPropertyName = "cod_EstadoRG";
            this.cod_EstadoRG.HeaderText = "cod_EstadoRG";
            this.cod_EstadoRG.Name = "cod_EstadoRG";
            this.cod_EstadoRG.ReadOnly = true;
            // 
            // DataExpedicaoRG
            // 
            this.DataExpedicaoRG.DataPropertyName = "DataExpedicaoRG";
            this.DataExpedicaoRG.HeaderText = "DataExpedicaoRG";
            this.DataExpedicaoRG.Name = "DataExpedicaoRG";
            this.DataExpedicaoRG.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn11.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // button_BuscarPessoa
            // 
            this.button_BuscarPessoa.Location = new System.Drawing.Point(475, 146);
            this.button_BuscarPessoa.Name = "button_BuscarPessoa";
            this.button_BuscarPessoa.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarPessoa.TabIndex = 2;
            this.button_BuscarPessoa.Text = "Buscar";
            this.button_BuscarPessoa.UseVisualStyleBackColor = true;
            this.button_BuscarPessoa.Click += new System.EventHandler(this.button_BuscarPessoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox_BuscaPessoa
            // 
            this.textBox_BuscaPessoa.Location = new System.Drawing.Point(12, 146);
            this.textBox_BuscaPessoa.Name = "textBox_BuscaPessoa";
            this.textBox_BuscaPessoa.Size = new System.Drawing.Size(457, 20);
            this.textBox_BuscaPessoa.TabIndex = 6;
            // 
            // radioButton_BuscarTodasPessoas
            // 
            this.radioButton_BuscarTodasPessoas.AutoSize = true;
            this.radioButton_BuscarTodasPessoas.Checked = true;
            this.radioButton_BuscarTodasPessoas.Location = new System.Drawing.Point(13, 123);
            this.radioButton_BuscarTodasPessoas.Name = "radioButton_BuscarTodasPessoas";
            this.radioButton_BuscarTodasPessoas.Size = new System.Drawing.Size(91, 17);
            this.radioButton_BuscarTodasPessoas.TabIndex = 7;
            this.radioButton_BuscarTodasPessoas.TabStop = true;
            this.radioButton_BuscarTodasPessoas.Text = "Buscar Todos";
            this.radioButton_BuscarTodasPessoas.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPor_Nome
            // 
            this.radioButton_BuscarPor_Nome.AutoSize = true;
            this.radioButton_BuscarPor_Nome.Location = new System.Drawing.Point(113, 123);
            this.radioButton_BuscarPor_Nome.Name = "radioButton_BuscarPor_Nome";
            this.radioButton_BuscarPor_Nome.Size = new System.Drawing.Size(91, 17);
            this.radioButton_BuscarPor_Nome.TabIndex = 8;
            this.radioButton_BuscarPor_Nome.Text = "Buscar/Nome";
            this.radioButton_BuscarPor_Nome.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPor_CPF
            // 
            this.radioButton_BuscarPor_CPF.AutoSize = true;
            this.radioButton_BuscarPor_CPF.Location = new System.Drawing.Point(230, 123);
            this.radioButton_BuscarPor_CPF.Name = "radioButton_BuscarPor_CPF";
            this.radioButton_BuscarPor_CPF.Size = new System.Drawing.Size(83, 17);
            this.radioButton_BuscarPor_CPF.TabIndex = 9;
            this.radioButton_BuscarPor_CPF.Text = "Buscar/CPF";
            this.radioButton_BuscarPor_CPF.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPor_ID
            // 
            this.radioButton_BuscarPor_ID.AutoSize = true;
            this.radioButton_BuscarPor_ID.Location = new System.Drawing.Point(342, 123);
            this.radioButton_BuscarPor_ID.Name = "radioButton_BuscarPor_ID";
            this.radioButton_BuscarPor_ID.Size = new System.Drawing.Size(74, 17);
            this.radioButton_BuscarPor_ID.TabIndex = 10;
            this.radioButton_BuscarPor_ID.Text = "Buscar/ID";
            this.radioButton_BuscarPor_ID.UseVisualStyleBackColor = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.pessoaBindingSource;
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AllowUserToOrderColumns = true;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(823, 209);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.RowHeadersVisible = false;
            this.usuariosDataGridView.Size = new System.Drawing.Size(411, 446);
            this.usuariosDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Funcao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Funçao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // BuscarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 675);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.radioButton_BuscarPor_ID);
            this.Controls.Add(this.radioButton_BuscarPor_CPF);
            this.Controls.Add(this.radioButton_BuscarPor_Nome);
            this.Controls.Add(this.radioButton_BuscarTodasPessoas);
            this.Controls.Add(this.textBox_BuscaPessoa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_BuscarPessoa);
            this.Controls.Add(this.pessoaDataGridView);
            this.Name = "BuscarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgaoExpedidorRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_EstadoRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataExpedicaoRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button_BuscarPessoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_BuscaPessoa;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodasPessoas;
        private System.Windows.Forms.RadioButton radioButton_BuscarPor_Nome;
        private System.Windows.Forms.RadioButton radioButton_BuscarPor_CPF;
        private System.Windows.Forms.RadioButton radioButton_BuscarPor_ID;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}