namespace WindowsFormsAppPrincipal
{
    partial class Form_VincularGrupoPermissao
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
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_BuscarPermissao = new System.Windows.Forms.Button();
            this.button_SelecionarPermissao = new System.Windows.Forms.Button();
            this.button_CancelarVinculoPermissao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.permissaoDataGridView.DataSource = this.permissoesBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 100);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.Size = new System.Drawing.Size(494, 297);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Permissão (Descrição)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // button_BuscarPermissao
            // 
            this.button_BuscarPermissao.Location = new System.Drawing.Point(431, 71);
            this.button_BuscarPermissao.Name = "button_BuscarPermissao";
            this.button_BuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarPermissao.TabIndex = 3;
            this.button_BuscarPermissao.Text = "Buscar";
            this.button_BuscarPermissao.UseVisualStyleBackColor = true;
            this.button_BuscarPermissao.Click += new System.EventHandler(this.button_BuscarPermissao_Click);
            // 
            // button_SelecionarPermissao
            // 
            this.button_SelecionarPermissao.Location = new System.Drawing.Point(370, 422);
            this.button_SelecionarPermissao.Name = "button_SelecionarPermissao";
            this.button_SelecionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_SelecionarPermissao.TabIndex = 4;
            this.button_SelecionarPermissao.Text = "Selecionar";
            this.button_SelecionarPermissao.UseVisualStyleBackColor = true;
            this.button_SelecionarPermissao.Click += new System.EventHandler(this.button_SelecionarPermissao_Click);
            // 
            // button_CancelarVinculoPermissao
            // 
            this.button_CancelarVinculoPermissao.Location = new System.Drawing.Point(451, 422);
            this.button_CancelarVinculoPermissao.Name = "button_CancelarVinculoPermissao";
            this.button_CancelarVinculoPermissao.Size = new System.Drawing.Size(75, 23);
            this.button_CancelarVinculoPermissao.TabIndex = 5;
            this.button_CancelarVinculoPermissao.Text = "Cancelar";
            this.button_CancelarVinculoPermissao.UseVisualStyleBackColor = true;
            this.button_CancelarVinculoPermissao.Click += new System.EventHandler(this.button_CancelarVinculoPermissao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vincular Permissão um Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Grupo";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(109, 50);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(309, 20);
            this.nomeGrupoTextBox.TabIndex = 8;
            // 
            // Form_VincularGrupoPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 515);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CancelarVinculoPermissao);
            this.Controls.Add(this.button_SelecionarPermissao);
            this.Controls.Add(this.button_BuscarPermissao);
            this.Controls.Add(this.permissaoDataGridView);
            this.Name = "Form_VincularGrupoPermissao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vincular Permissão em Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button_BuscarPermissao;
        private System.Windows.Forms.Button button_SelecionarPermissao;
        private System.Windows.Forms.Button button_CancelarVinculoPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
    }
}