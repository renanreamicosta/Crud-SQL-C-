namespace WindowsFormsApp1
{
    partial class Crud
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
            this.txt_login_cad = new System.Windows.Forms.TextBox();
            this.txt_senha_cad = new System.Windows.Forms.TextBox();
            this.btn_cad = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_login_cad
            // 
            this.txt_login_cad.Location = new System.Drawing.Point(74, 42);
            this.txt_login_cad.Name = "txt_login_cad";
            this.txt_login_cad.Size = new System.Drawing.Size(100, 20);
            this.txt_login_cad.TabIndex = 0;
            // 
            // txt_senha_cad
            // 
            this.txt_senha_cad.Location = new System.Drawing.Point(74, 68);
            this.txt_senha_cad.Name = "txt_senha_cad";
            this.txt_senha_cad.Size = new System.Drawing.Size(100, 20);
            this.txt_senha_cad.TabIndex = 1;
            this.txt_senha_cad.UseSystemPasswordChar = true;
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(74, 103);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(65, 36);
            this.btn_cad.TabIndex = 2;
            this.btn_cad.Text = "Cadastrar";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(26, 48);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.txt_senha_cad);
            this.Controls.Add(this.txt_login_cad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Crud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login_cad;
        private System.Windows.Forms.TextBox txt_senha_cad;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label1;
    }
}