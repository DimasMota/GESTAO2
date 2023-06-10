namespace WindowsFormsApp
{
    partial class FormCadastrarPais
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
            System.Windows.Forms.Label nomePaisLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cadastrar_Pais = new System.Windows.Forms.Button();
            this.button_Excluir_Pais = new System.Windows.Forms.Button();
            this.paisDataGridView = new System.Windows.Forms.DataGridView();
            this.button_Buscar_Pais = new System.Windows.Forms.Button();
            this.button_Alterar_Pais = new System.Windows.Forms.Button();
            this.button_Selecionar_Pais = new System.Windows.Forms.Button();
            this.button_Cancelar_Pais = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Nome_Pais = new System.Windows.Forms.TextBox();
            this.textBox_Cadastrar_Pais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_BuscarTodos_Pais = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorNome_Pais = new System.Windows.Forms.RadioButton();
            this.radioButton_BuscarPorID_Pais = new System.Windows.Forms.RadioButton();
            nomePaisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomePaisLabel
            // 
            nomePaisLabel.AutoSize = true;
            nomePaisLabel.Location = new System.Drawing.Point(15, 122);
            nomePaisLabel.Name = "nomePaisLabel";
            nomePaisLabel.Size = new System.Drawing.Size(61, 13);
            nomePaisLabel.TabIndex = 3;
            nomePaisLabel.Text = "Nome Pais:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAÍSES";
            // 
            // button_Cadastrar_Pais
            // 
            this.button_Cadastrar_Pais.Location = new System.Drawing.Point(360, 384);
            this.button_Cadastrar_Pais.Name = "button_Cadastrar_Pais";
            this.button_Cadastrar_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Cadastrar_Pais.TabIndex = 6;
            this.button_Cadastrar_Pais.Text = "Cadastrar";
            this.button_Cadastrar_Pais.UseVisualStyleBackColor = true;
            this.button_Cadastrar_Pais.Click += new System.EventHandler(this.button_Cadastrar_Pais_Click);
            // 
            // button_Excluir_Pais
            // 
            this.button_Excluir_Pais.Location = new System.Drawing.Point(487, 120);
            this.button_Excluir_Pais.Name = "button_Excluir_Pais";
            this.button_Excluir_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir_Pais.TabIndex = 7;
            this.button_Excluir_Pais.Text = "Excluir";
            this.button_Excluir_Pais.UseVisualStyleBackColor = true;
            // 
            // paisDataGridView
            // 
            this.paisDataGridView.AllowUserToAddRows = false;
            this.paisDataGridView.AllowUserToDeleteRows = false;
            this.paisDataGridView.AutoGenerateColumns = false;
            this.paisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.paisDataGridView.DataSource = this.paisBindingSource;
            this.paisDataGridView.Location = new System.Drawing.Point(39, 162);
            this.paisDataGridView.Name = "paisDataGridView";
            this.paisDataGridView.ReadOnly = true;
            this.paisDataGridView.Size = new System.Drawing.Size(595, 209);
            this.paisDataGridView.TabIndex = 7;
            // 
            // button_Buscar_Pais
            // 
            this.button_Buscar_Pais.Location = new System.Drawing.Point(406, 120);
            this.button_Buscar_Pais.Name = "button_Buscar_Pais";
            this.button_Buscar_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_Pais.TabIndex = 8;
            this.button_Buscar_Pais.Text = "Buscar";
            this.button_Buscar_Pais.UseVisualStyleBackColor = true;
            this.button_Buscar_Pais.Click += new System.EventHandler(this.button_Buscar_Pais_Click);
            // 
            // button_Alterar_Pais
            // 
            this.button_Alterar_Pais.Location = new System.Drawing.Point(568, 119);
            this.button_Alterar_Pais.Name = "button_Alterar_Pais";
            this.button_Alterar_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Alterar_Pais.TabIndex = 9;
            this.button_Alterar_Pais.Text = "Alterar";
            this.button_Alterar_Pais.UseVisualStyleBackColor = true;
            // 
            // button_Selecionar_Pais
            // 
            this.button_Selecionar_Pais.Location = new System.Drawing.Point(468, 384);
            this.button_Selecionar_Pais.Name = "button_Selecionar_Pais";
            this.button_Selecionar_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Selecionar_Pais.TabIndex = 10;
            this.button_Selecionar_Pais.Text = "Selecionar";
            this.button_Selecionar_Pais.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar_Pais
            // 
            this.button_Cancelar_Pais.Location = new System.Drawing.Point(559, 384);
            this.button_Cancelar_Pais.Name = "button_Cancelar_Pais";
            this.button_Cancelar_Pais.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_Pais.TabIndex = 11;
            this.button_Cancelar_Pais.Text = "Cancelar";
            this.button_Cancelar_Pais.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Pais";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Pais";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomePais";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Pais";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(Models.Pais);
            // 
            // textBox_Nome_Pais
            // 
            this.textBox_Nome_Pais.Location = new System.Drawing.Point(83, 122);
            this.textBox_Nome_Pais.Name = "textBox_Nome_Pais";
            this.textBox_Nome_Pais.Size = new System.Drawing.Size(317, 20);
            this.textBox_Nome_Pais.TabIndex = 12;
            // 
            // textBox_Cadastrar_Pais
            // 
            this.textBox_Cadastrar_Pais.Location = new System.Drawing.Point(39, 386);
            this.textBox_Cadastrar_Pais.Name = "textBox_Cadastrar_Pais";
            this.textBox_Cadastrar_Pais.Size = new System.Drawing.Size(317, 20);
            this.textBox_Cadastrar_Pais.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar por:";
            // 
            // radioButton_BuscarTodos_Pais
            // 
            this.radioButton_BuscarTodos_Pais.AutoSize = true;
            this.radioButton_BuscarTodos_Pais.Checked = true;
            this.radioButton_BuscarTodos_Pais.Location = new System.Drawing.Point(83, 96);
            this.radioButton_BuscarTodos_Pais.Name = "radioButton_BuscarTodos_Pais";
            this.radioButton_BuscarTodos_Pais.Size = new System.Drawing.Size(55, 17);
            this.radioButton_BuscarTodos_Pais.TabIndex = 15;
            this.radioButton_BuscarTodos_Pais.TabStop = true;
            this.radioButton_BuscarTodos_Pais.Text = "Todos";
            this.radioButton_BuscarTodos_Pais.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorNome_Pais
            // 
            this.radioButton_BuscarPorNome_Pais.AutoSize = true;
            this.radioButton_BuscarPorNome_Pais.Location = new System.Drawing.Point(174, 96);
            this.radioButton_BuscarPorNome_Pais.Name = "radioButton_BuscarPorNome_Pais";
            this.radioButton_BuscarPorNome_Pais.Size = new System.Drawing.Size(53, 17);
            this.radioButton_BuscarPorNome_Pais.TabIndex = 16;
            this.radioButton_BuscarPorNome_Pais.Text = "Nome";
            this.radioButton_BuscarPorNome_Pais.UseVisualStyleBackColor = true;
            // 
            // radioButton_BuscarPorID_Pais
            // 
            this.radioButton_BuscarPorID_Pais.AutoSize = true;
            this.radioButton_BuscarPorID_Pais.Location = new System.Drawing.Point(271, 96);
            this.radioButton_BuscarPorID_Pais.Name = "radioButton_BuscarPorID_Pais";
            this.radioButton_BuscarPorID_Pais.Size = new System.Drawing.Size(36, 17);
            this.radioButton_BuscarPorID_Pais.TabIndex = 17;
            this.radioButton_BuscarPorID_Pais.Text = "ID";
            this.radioButton_BuscarPorID_Pais.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 419);
            this.Controls.Add(this.radioButton_BuscarPorID_Pais);
            this.Controls.Add(this.radioButton_BuscarPorNome_Pais);
            this.Controls.Add(this.radioButton_BuscarTodos_Pais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Cadastrar_Pais);
            this.Controls.Add(this.textBox_Nome_Pais);
            this.Controls.Add(this.button_Cancelar_Pais);
            this.Controls.Add(this.button_Selecionar_Pais);
            this.Controls.Add(this.button_Alterar_Pais);
            this.Controls.Add(this.button_Buscar_Pais);
            this.Controls.Add(this.paisDataGridView);
            this.Controls.Add(this.button_Excluir_Pais);
            this.Controls.Add(this.button_Cadastrar_Pais);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomePaisLabel);
            this.Name = "FormCadastrarPais";
            this.Text = "FormCadastrarPais";
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cadastrar_Pais;
        private System.Windows.Forms.Button button_Excluir_Pais;
        private System.Windows.Forms.DataGridView paisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_Buscar_Pais;
        private System.Windows.Forms.Button button_Alterar_Pais;
        private System.Windows.Forms.Button button_Selecionar_Pais;
        private System.Windows.Forms.Button button_Cancelar_Pais;
        private System.Windows.Forms.TextBox textBox_Nome_Pais;
        private System.Windows.Forms.TextBox textBox_Cadastrar_Pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_BuscarTodos_Pais;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorNome_Pais;
        private System.Windows.Forms.RadioButton radioButton_BuscarPorID_Pais;
    }
}