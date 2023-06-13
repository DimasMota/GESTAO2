namespace WindowsFormsApp
{
    partial class FormConsultaCliente
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
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Buscar_Cliente = new System.Windows.Forms.TextBox();
            this.button_Buscar_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_BuscarTodos_Cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome_Cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorID_Cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorCPF_Cliente = new System.Windows.Forms.RadioButton();
            this.button_Selecionar_Cliente = new System.Windows.Forms.Button();
            this.button_Cancelar_Cliente = new System.Windows.Forms.Button();
            this.button_Inserir_Cliente = new System.Windows.Forms.Button();
            this.button_Alterar_Cliente = new System.Windows.Forms.Button();
            this.button_Excluir_Cliente = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 151);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersVisible = false;
            this.clienteDataGridView.RowHeadersWidth = 51;
            this.clienteDataGridView.RowTemplate.Height = 24;
            this.clienteDataGridView.Size = new System.Drawing.Size(976, 244);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // textBox_Buscar_Cliente
            // 
            this.textBox_Buscar_Cliente.Location = new System.Drawing.Point(12, 111);
            this.textBox_Buscar_Cliente.Name = "textBox_Buscar_Cliente";
            this.textBox_Buscar_Cliente.Size = new System.Drawing.Size(540, 22);
            this.textBox_Buscar_Cliente.TabIndex = 2;
            // 
            // button_Buscar_Cliente
            // 
            this.button_Buscar_Cliente.Location = new System.Drawing.Point(577, 110);
            this.button_Buscar_Cliente.Name = "button_Buscar_Cliente";
            this.button_Buscar_Cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Cliente.TabIndex = 3;
            this.button_Buscar_Cliente.Text = "Buscar";
            this.button_Buscar_Cliente.UseVisualStyleBackColor = true;
            this.button_Buscar_Cliente.Click += new System.EventHandler(this.button_Buscar_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por";
            // 
            // radioButton_BuscarTodos_Cliente
            // 
            this.radioButton_BuscarTodos_Cliente.AutoSize = true;
            this.radioButton_BuscarTodos_Cliente.Checked = true;
            this.radioButton_BuscarTodos_Cliente.Location = new System.Drawing.Point(30, 84);
            this.radioButton_BuscarTodos_Cliente.Name = "radioButton_BuscarTodos_Cliente";
            this.radioButton_BuscarTodos_Cliente.Size = new System.Drawing.Size(113, 20);
            this.radioButton_BuscarTodos_Cliente.TabIndex = 5;
            this.radioButton_BuscarTodos_Cliente.TabStop = true;
            this.radioButton_BuscarTodos_Cliente.Text = "Buscar Todos";
            this.radioButton_BuscarTodos_Cliente.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome_Cliente
            // 
            this.radioButton_BuscarPorNome_Cliente.AutoSize = true;
            this.radioButton_BuscarPorNome_Cliente.Location = new System.Drawing.Point(149, 85);
            this.radioButton_BuscarPorNome_Cliente.Name = "radioButton_BuscarPorNome_Cliente";
            this.radioButton_BuscarPorNome_Cliente.Size = new System.Drawing.Size(134, 20);
            this.radioButton_BuscarPorNome_Cliente.TabIndex = 6;
            this.radioButton_BuscarPorNome_Cliente.Text = "Buscar Por Nome";
            this.radioButton_BuscarPorNome_Cliente.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorID_Cliente
            // 
            this.radioButton_BuscarPorID_Cliente.AutoSize = true;
            this.radioButton_BuscarPorID_Cliente.Location = new System.Drawing.Point(289, 85);
            this.radioButton_BuscarPorID_Cliente.Name = "radioButton_BuscarPorID_Cliente";
            this.radioButton_BuscarPorID_Cliente.Size = new System.Drawing.Size(110, 20);
            this.radioButton_BuscarPorID_Cliente.TabIndex = 7;
            this.radioButton_BuscarPorID_Cliente.Text = "Buscar Por ID";
            this.radioButton_BuscarPorID_Cliente.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorCPF_Cliente
            // 
            this.radioButton_BuscarPorCPF_Cliente.AutoSize = true;
            this.radioButton_BuscarPorCPF_Cliente.Location = new System.Drawing.Point(405, 84);
            this.radioButton_BuscarPorCPF_Cliente.Name = "radioButton_BuscarPorCPF_Cliente";
            this.radioButton_BuscarPorCPF_Cliente.Size = new System.Drawing.Size(122, 20);
            this.radioButton_BuscarPorCPF_Cliente.TabIndex = 8;
            this.radioButton_BuscarPorCPF_Cliente.Text = "Buscar por CPF";
            this.radioButton_BuscarPorCPF_Cliente.UseVisualStyleBackColor = true;
            // 
            // button_Selecionar_Cliente
            // 
            this.button_Selecionar_Cliente.Location = new System.Drawing.Point(792, 415);
            this.button_Selecionar_Cliente.Name = "button_Selecionar_Cliente";
            this.button_Selecionar_Cliente.Size = new System.Drawing.Size(99, 23);
            this.button_Selecionar_Cliente.TabIndex = 9;
            this.button_Selecionar_Cliente.Text = "Selecionar";
            this.button_Selecionar_Cliente.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar_Cliente
            // 
            this.button_Cancelar_Cliente.Location = new System.Drawing.Point(897, 415);
            this.button_Cancelar_Cliente.Name = "button_Cancelar_Cliente";
            this.button_Cancelar_Cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Cliente.TabIndex = 10;
            this.button_Cancelar_Cliente.Text = "Cancelar";
            this.button_Cancelar_Cliente.UseVisualStyleBackColor = true;
            this.button_Cancelar_Cliente.Click += new System.EventHandler(this.button_Cancelar_Cliente_Click);
            // 
            // button_Inserir_Cliente
            // 
            this.button_Inserir_Cliente.Location = new System.Drawing.Point(658, 110);
            this.button_Inserir_Cliente.Name = "button_Inserir_Cliente";
            this.button_Inserir_Cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Inserir_Cliente.TabIndex = 11;
            this.button_Inserir_Cliente.Text = "Inserir";
            this.button_Inserir_Cliente.UseVisualStyleBackColor = true;
            this.button_Inserir_Cliente.Click += new System.EventHandler(this.button_Inserir_Cliente_Click);
            // 
            // button_Alterar_Cliente
            // 
            this.button_Alterar_Cliente.Location = new System.Drawing.Point(739, 110);
            this.button_Alterar_Cliente.Name = "button_Alterar_Cliente";
            this.button_Alterar_Cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Alterar_Cliente.TabIndex = 12;
            this.button_Alterar_Cliente.Text = "Alterar";
            this.button_Alterar_Cliente.UseVisualStyleBackColor = true;
            this.button_Alterar_Cliente.Click += new System.EventHandler(this.button_Alterar_Cliente_Click);
            // 
            // button_Excluir_Cliente
            // 
            this.button_Excluir_Cliente.Location = new System.Drawing.Point(820, 110);
            this.button_Excluir_Cliente.Name = "button_Excluir_Cliente";
            this.button_Excluir_Cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_Cliente.TabIndex = 13;
            this.button_Excluir_Cliente.Text = "Excluir";
            this.button_Excluir_Cliente.UseVisualStyleBackColor = true;
            this.button_Excluir_Cliente.Click += new System.EventHandler(this.button_Excluir_Cliente_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn4.HeaderText = "RG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consulta de Cliente";
            // 
            // FormConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Excluir_Cliente);
            this.Controls.Add(this.button_Alterar_Cliente);
            this.Controls.Add(this.button_Inserir_Cliente);
            this.Controls.Add(this.button_Cancelar_Cliente);
            this.Controls.Add(this.button_Selecionar_Cliente);
            this.Controls.Add(this.radioButton_BuscarPorCPF_Cliente);
            this.Controls.Add(this.radioButton_BuscarPorID_Cliente);
            this.Controls.Add(this.radioButton_BuscarPorNome_Cliente);
            this.Controls.Add(this.radioButton_BuscarTodos_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Buscar_Cliente);
            this.Controls.Add(this.textBox_Buscar_Cliente);
            this.Controls.Add(this.clienteDataGridView);
            this.Name = "FormConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.TextBox textBox_Buscar_Cliente;
        private System.Windows.Forms.Button button_Buscar_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodos_Cliente;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome_Cliente;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorID_Cliente;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorCPF_Cliente;
        private System.Windows.Forms.Button button_Selecionar_Cliente;
        private System.Windows.Forms.Button button_Cancelar_Cliente;
        private System.Windows.Forms.Button button_Inserir_Cliente;
        private System.Windows.Forms.Button button_Alterar_Cliente;
        private System.Windows.Forms.Button button_Excluir_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
    }
}