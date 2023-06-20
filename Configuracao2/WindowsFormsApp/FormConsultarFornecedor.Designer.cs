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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_BuscarPor_Fornecedor = new System.Windows.Forms.ComboBox();
            this.textBox_Buscar_Fornecedor = new System.Windows.Forms.TextBox();
            this.button_Buscar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Insirir_Fornecedor = new System.Windows.Forms.Button();
            this.button_Alterar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Excluir_Fornecedor = new System.Windows.Forms.Button();
            this.button_Selecionar_Fornecedor = new System.Windows.Forms.Button();
            this.button_Cancelar_Fornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.fornecedorDataGridView.Location = new System.Drawing.Point(31, 146);
            this.fornecedorDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.RowHeadersVisible = false;
            this.fornecedorDataGridView.RowHeadersWidth = 51;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(1123, 421);
            this.fornecedorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn5.HeaderText = "Site";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // comboBox_BuscarPor_Fornecedor
            // 
            this.comboBox_BuscarPor_Fornecedor.FormattingEnabled = true;
            this.comboBox_BuscarPor_Fornecedor.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id",
            "Site"});
            this.comboBox_BuscarPor_Fornecedor.Location = new System.Drawing.Point(31, 105);
            this.comboBox_BuscarPor_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BuscarPor_Fornecedor.Name = "comboBox_BuscarPor_Fornecedor";
            this.comboBox_BuscarPor_Fornecedor.Size = new System.Drawing.Size(160, 24);
            this.comboBox_BuscarPor_Fornecedor.TabIndex = 2;
            this.comboBox_BuscarPor_Fornecedor.Text = "Buscar por";
            // 
            // textBox_Buscar_Fornecedor
            // 
            this.textBox_Buscar_Fornecedor.Location = new System.Drawing.Point(200, 106);
            this.textBox_Buscar_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Buscar_Fornecedor.Name = "textBox_Buscar_Fornecedor";
            this.textBox_Buscar_Fornecedor.Size = new System.Drawing.Size(520, 22);
            this.textBox_Buscar_Fornecedor.TabIndex = 3;
            // 
            // button_Buscar_Fornecedor
            // 
            this.button_Buscar_Fornecedor.Location = new System.Drawing.Point(729, 103);
            this.button_Buscar_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Buscar_Fornecedor.Name = "button_Buscar_Fornecedor";
            this.button_Buscar_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Buscar_Fornecedor.TabIndex = 4;
            this.button_Buscar_Fornecedor.Text = "Burcar";
            this.button_Buscar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Buscar_Fornecedor.Click += new System.EventHandler(this.button_Buscar_Fornecedor_Click);
            // 
            // button_Insirir_Fornecedor
            // 
            this.button_Insirir_Fornecedor.Location = new System.Drawing.Point(837, 103);
            this.button_Insirir_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Insirir_Fornecedor.Name = "button_Insirir_Fornecedor";
            this.button_Insirir_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Insirir_Fornecedor.TabIndex = 5;
            this.button_Insirir_Fornecedor.Text = "Inserir";
            this.button_Insirir_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Insirir_Fornecedor.Click += new System.EventHandler(this.button_Insirir_Fornecedor_Click);
            // 
            // button_Alterar_Fornecedor
            // 
            this.button_Alterar_Fornecedor.Location = new System.Drawing.Point(945, 103);
            this.button_Alterar_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Alterar_Fornecedor.Name = "button_Alterar_Fornecedor";
            this.button_Alterar_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Alterar_Fornecedor.TabIndex = 6;
            this.button_Alterar_Fornecedor.Text = "Alterar";
            this.button_Alterar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Alterar_Fornecedor.Click += new System.EventHandler(this.button_Alterar_Fornecedor_Click);
            // 
            // button_Excluir_Fornecedor
            // 
            this.button_Excluir_Fornecedor.Location = new System.Drawing.Point(1053, 103);
            this.button_Excluir_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Excluir_Fornecedor.Name = "button_Excluir_Fornecedor";
            this.button_Excluir_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Excluir_Fornecedor.TabIndex = 7;
            this.button_Excluir_Fornecedor.Text = "Excluir";
            this.button_Excluir_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Excluir_Fornecedor.Click += new System.EventHandler(this.button_Excluir_Fornecedor_Click);
            // 
            // button_Selecionar_Fornecedor
            // 
            this.button_Selecionar_Fornecedor.Location = new System.Drawing.Point(920, 596);
            this.button_Selecionar_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Selecionar_Fornecedor.Name = "button_Selecionar_Fornecedor";
            this.button_Selecionar_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Selecionar_Fornecedor.TabIndex = 8;
            this.button_Selecionar_Fornecedor.Text = "Selecionar";
            this.button_Selecionar_Fornecedor.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar_Fornecedor
            // 
            this.button_Cancelar_Fornecedor.Location = new System.Drawing.Point(1053, 596);
            this.button_Cancelar_Fornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancelar_Fornecedor.Name = "button_Cancelar_Fornecedor";
            this.button_Cancelar_Fornecedor.Size = new System.Drawing.Size(100, 28);
            this.button_Cancelar_Fornecedor.TabIndex = 9;
            this.button_Cancelar_Fornecedor.Text = "Cancelar";
            this.button_Cancelar_Fornecedor.UseVisualStyleBackColor = true;
            this.button_Cancelar_Fornecedor.Click += new System.EventHandler(this.button_Cancelar_Fornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultar Fornecedor";
            // 
            // FormConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 639);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsultarFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.ComboBox comboBox_BuscarPor_Fornecedor;
        private System.Windows.Forms.TextBox textBox_Buscar_Fornecedor;
        private System.Windows.Forms.Button button_Buscar_Fornecedor;
        private System.Windows.Forms.Button button_Insirir_Fornecedor;
        private System.Windows.Forms.Button button_Alterar_Fornecedor;
        private System.Windows.Forms.Button button_Excluir_Fornecedor;
        private System.Windows.Forms.Button button_Selecionar_Fornecedor;
        private System.Windows.Forms.Button button_Cancelar_Fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}