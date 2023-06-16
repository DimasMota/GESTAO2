namespace WindowsFormsApp
{
    partial class FormConsultarFornecedor
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
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox_BuscarPor_Fornecedor = new System.Windows.Forms.ComboBox();
            this.textBox_Buscar_Fornecedor = new System.Windows.Forms.TextBox();
            this.button_Buscar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Insirir_Fornecedor = new System.Windows.Forms.Button();
            this.button_Alterar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Excluir_Fornecedor = new System.Windows.Forms.Button();
            this.button_Selecionar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Cancelar_Fornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AllowUserToAddRows = false;
            this.fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.fornecedorDataGridView.AllowUserToOrderColumns = true;
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(23, 119);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.RowHeadersVisible = false;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(842, 342);
            this.fornecedorDataGridView.TabIndex = 1;
            // 
            // comboBox_BuscarPor_Fornecedor
            // 
            this.comboBox_BuscarPor_Fornecedor.FormattingEnabled = true;
            this.comboBox_BuscarPor_Fornecedor.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id",
            "Site"});
            this.comboBox_BuscarPor_Fornecedor.Location = new System.Drawing.Point(23, 85);
            this.comboBox_BuscarPor_Fornecedor.Name = "comboBox_BuscarPor_Fornecedor";
            this.comboBox_BuscarPor_Fornecedor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BuscarPor_Fornecedor.TabIndex = 2;
            this.comboBox_BuscarPor_Fornecedor.Text = "Buscar por";
            // 
            // textBox_Buscar_Fornecedor
            // 
            this.textBox_Buscar_Fornecedor.Location = new System.Drawing.Point(150, 86);
            this.textBox_Buscar_Fornecedor.Name = "textBox_Buscar_Fornecedor";
            this.textBox_Buscar_Fornecedor.Size = new System.Drawing.Size(391, 20);
            this.textBox_Buscar_Fornecedor.TabIndex = 3;
            // 
            // button_Buscar_Fornecedor
            // 
            this.button_Buscar_Fornecedor.Location = new System.Drawing.Point(547, 84);
            this.button_Buscar_Fornecedor.Name = "button_Buscar_Fornecedor";
            this.button_Buscar_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Fornecedor.TabIndex = 4;
            this.button_Buscar_Fornecedor.Text = "Burcar";
            this.button_Buscar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Buscar_Fornecedor.Click += new System.EventHandler(this.button_Buscar_Fornecedor_Click);
            // 
            // button_Insirir_Fornecedor
            // 
            this.button_Insirir_Fornecedor.Location = new System.Drawing.Point(628, 84);
            this.button_Insirir_Fornecedor.Name = "button_Insirir_Fornecedor";
            this.button_Insirir_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Insirir_Fornecedor.TabIndex = 5;
            this.button_Insirir_Fornecedor.Text = "Inserir";
            this.button_Insirir_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Insirir_Fornecedor.Click += new System.EventHandler(this.button_Insirir_Fornecedor_Click);
            // 
            // button_Alterar_Fornecedor
            // 
            this.button_Alterar_Fornecedor.Location = new System.Drawing.Point(709, 84);
            this.button_Alterar_Fornecedor.Name = "button_Alterar_Fornecedor";
            this.button_Alterar_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Alterar_Fornecedor.TabIndex = 6;
            this.button_Alterar_Fornecedor.Text = "Alterar";
            this.button_Alterar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Alterar_Fornecedor.Click += new System.EventHandler(this.button_Alterar_Fornecedor_Click);
            // 
            // button_Excluir_Fornecedor
            // 
            this.button_Excluir_Fornecedor.Location = new System.Drawing.Point(790, 84);
            this.button_Excluir_Fornecedor.Name = "button_Excluir_Fornecedor";
            this.button_Excluir_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_Fornecedor.TabIndex = 7;
            this.button_Excluir_Fornecedor.Text = "Excluir";
            this.button_Excluir_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Excluir_Fornecedor.Click += new System.EventHandler(this.button_Excluir_Fornecedor_Click);
            // 
            // button_Selecionar_Fornecedor
            // 
            this.button_Selecionar_Fornecedor.Location = new System.Drawing.Point(690, 484);
            this.button_Selecionar_Fornecedor.Name = "button_Selecionar_Fornecedor";
            this.button_Selecionar_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Selecionar_Fornecedor.TabIndex = 8;
            this.button_Selecionar_Fornecedor.Text = "Selecionar";
            this.button_Selecionar_Fornecedor.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar_Fornecedor
            // 
            this.button_Cancelar_Fornecedor.Location = new System.Drawing.Point(790, 484);
            this.button_Cancelar_Fornecedor.Name = "button_Cancelar_Fornecedor";
            this.button_Cancelar_Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Fornecedor.TabIndex = 9;
            this.button_Cancelar_Fornecedor.Text = "Cancelar";
            this.button_Cancelar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Cancelar_Fornecedor.Click += new System.EventHandler(this.button_Cancelar_Fornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultar Fornecedor";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn5.HeaderText = "Site";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // FormConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancelar_Fornecedor);
            this.Controls.Add(this.button_Selecionar_Fornecedor);
            this.Controls.Add(this.button_Excluir_Fornecedor);
            this.Controls.Add(this.button_Alterar_Fornecedor);
            this.Controls.Add(this.button_Insirir_Fornecedor);
            this.Controls.Add(this.button_Buscar_Fornecedor);
            this.Controls.Add(this.textBox_Buscar_Fornecedor);
            this.Controls.Add(this.comboBox_BuscarPor_Fornecedor);
            this.Controls.Add(this.fornecedorDataGridView);
            this.Name = "FormConsultarFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox_BuscarPor_Fornecedor;
        private System.Windows.Forms.TextBox textBox_Buscar_Fornecedor;
        private System.Windows.Forms.Button button_Buscar_Fornecedor;
        private System.Windows.Forms.Button button_Insirir_Fornecedor;
        private System.Windows.Forms.Button button_Alterar_Fornecedor;
        private System.Windows.Forms.Button button_Excluir_Fornecedor;
        private System.Windows.Forms.Button button_Selecionar_Fornecedor;
        private System.Windows.Forms.Button button_Cancelar_Fornecedor;
        private System.Windows.Forms.Label label1;
    }
}