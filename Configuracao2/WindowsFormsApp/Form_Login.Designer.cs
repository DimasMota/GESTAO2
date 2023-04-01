namespace WindowsFormsApp
{
    partial class Form_Login
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
            this.button_Entrar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.textBox_NomeUsuario = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Entrar
            // 
            this.button_Entrar.Location = new System.Drawing.Point(127, 214);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(75, 23);
            this.button_Entrar.TabIndex = 0;
            this.button_Entrar.Text = "Entrar";
            this.button_Entrar.UseVisualStyleBackColor = true;
            this.button_Entrar.Click += new System.EventHandler(this.button_Entrar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(246, 214);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 1;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // textBox_NomeUsuario
            // 
            this.textBox_NomeUsuario.Location = new System.Drawing.Point(127, 74);
            this.textBox_NomeUsuario.Name = "textBox_NomeUsuario";
            this.textBox_NomeUsuario.Size = new System.Drawing.Size(243, 22);
            this.textBox_NomeUsuario.TabIndex = 2;
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(127, 142);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(243, 22);
            this.textBox_Senha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SENHA";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_NomeUsuario);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Entrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN DO USUÁRIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Entrar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TextBox textBox_NomeUsuario;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}