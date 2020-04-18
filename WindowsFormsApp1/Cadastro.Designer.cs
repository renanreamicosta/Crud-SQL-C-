namespace WindowsFormsApp1
{
    partial class Cadastro
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_busca = new System.Windows.Forms.DataGridView();
            this.ClientesID = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_addimage = new System.Windows.Forms.Button();
            this.LogoTipo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Logra = new System.Windows.Forms.TextBox();
            this.btn_inserir_logra = new System.Windows.Forms.Button();
            this.btn_excluir_logra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_Cli = new System.Windows.Forms.TextBox();
            this.btn_alterar_logra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_log = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(295, 359);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 20);
            this.txt_name.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(243, 253);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 52);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Inserir";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(80, 253);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 52);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(161, 253);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 52);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(298, 79);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(75, 42);
            this.btn_procurar.TabIndex = 4;
            this.btn_procurar.Text = "Pesquisar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(295, 394);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 20);
            this.txt_email.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Location = new System.Drawing.Point(86, 95);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(206, 20);
            this.txt_procurar.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pesquisar Nome:";
            // 
            // dgv_busca
            // 
            this.dgv_busca.AllowUserToAddRows = false;
            this.dgv_busca.AllowUserToDeleteRows = false;
            this.dgv_busca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busca.Location = new System.Drawing.Point(0, 128);
            this.dgv_busca.Name = "dgv_busca";
            this.dgv_busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busca.Size = new System.Drawing.Size(520, 110);
            this.dgv_busca.TabIndex = 19;
            this.dgv_busca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_busca_CellContentClick_1);
            // 
            // ClientesID
            // 
            this.ClientesID.AutoSize = true;
            this.ClientesID.Location = new System.Drawing.Point(217, 325);
            this.ClientesID.Name = "ClientesID";
            this.ClientesID.Size = new System.Drawing.Size(58, 13);
            this.ClientesID.TabIndex = 20;
            this.ClientesID.Text = "ClientesID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(295, 326);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(36, 20);
            this.txt_id.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_addimage
            // 
            this.btn_addimage.Location = new System.Drawing.Point(42, 377);
            this.btn_addimage.Name = "btn_addimage";
            this.btn_addimage.Size = new System.Drawing.Size(113, 23);
            this.btn_addimage.TabIndex = 22;
            this.btn_addimage.Text = "Inserir  Logotipo";
            this.btn_addimage.UseVisualStyleBackColor = true;
            this.btn_addimage.Click += new System.EventHandler(this.btn_addimage_Click);
            // 
            // LogoTipo
            // 
            this.LogoTipo.Location = new System.Drawing.Point(51, 321);
            this.LogoTipo.Name = "LogoTipo";
            this.LogoTipo.Size = new System.Drawing.Size(94, 50);
            this.LogoTipo.TabIndex = 23;
            this.LogoTipo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Logradouro:";
            // 
            // txt_Logra
            // 
            this.txt_Logra.Location = new System.Drawing.Point(105, 538);
            this.txt_Logra.Name = "txt_Logra";
            this.txt_Logra.Size = new System.Drawing.Size(237, 20);
            this.txt_Logra.TabIndex = 25;
            // 
            // btn_inserir_logra
            // 
            this.btn_inserir_logra.Location = new System.Drawing.Point(228, 564);
            this.btn_inserir_logra.Name = "btn_inserir_logra";
            this.btn_inserir_logra.Size = new System.Drawing.Size(103, 23);
            this.btn_inserir_logra.TabIndex = 26;
            this.btn_inserir_logra.Text = "Inserir Logradouro ";
            this.btn_inserir_logra.UseVisualStyleBackColor = true;
            this.btn_inserir_logra.Click += new System.EventHandler(this.btn_inserir_logra_Click);
            // 
            // btn_excluir_logra
            // 
            this.btn_excluir_logra.Location = new System.Drawing.Point(348, 511);
            this.btn_excluir_logra.Name = "btn_excluir_logra";
            this.btn_excluir_logra.Size = new System.Drawing.Size(103, 23);
            this.btn_excluir_logra.TabIndex = 27;
            this.btn_excluir_logra.Text = "Excluir Logradouro";
            this.btn_excluir_logra.UseVisualStyleBackColor = true;
            this.btn_excluir_logra.Click += new System.EventHandler(this.btn_excluir_logra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "COD_Cli";
            // 
            // txt_id_Cli
            // 
            this.txt_id_Cli.Location = new System.Drawing.Point(98, 502);
            this.txt_id_Cli.Name = "txt_id_Cli";
            this.txt_id_Cli.Size = new System.Drawing.Size(36, 20);
            this.txt_id_Cli.TabIndex = 29;
            // 
            // btn_alterar_logra
            // 
            this.btn_alterar_logra.Location = new System.Drawing.Point(348, 482);
            this.btn_alterar_logra.Name = "btn_alterar_logra";
            this.btn_alterar_logra.Size = new System.Drawing.Size(103, 23);
            this.btn_alterar_logra.TabIndex = 30;
            this.btn_alterar_logra.Text = "Alterar Logradouro";
            this.btn_alterar_logra.UseVisualStyleBackColor = true;
            this.btn_alterar_logra.Click += new System.EventHandler(this.btn_alterar_logra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "COD_Log";
            // 
            // txt_id_log
            // 
            this.txt_id_log.Location = new System.Drawing.Point(297, 483);
            this.txt_id_log.Name = "txt_id_log";
            this.txt_id_log.Size = new System.Drawing.Size(36, 20);
            this.txt_id_log.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(498, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Para excluir ou alterar  basta colocar o cod_log  desejado utilizando a tabela de" +
    " pesquisa para indetificar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Para excluir ou efetuar   modifcaçoes aperte no botão de pesquisa e selecione o n" +
    "ome ";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id_log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_alterar_logra);
            this.Controls.Add(this.txt_id_Cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_excluir_logra);
            this.Controls.Add(this.btn_inserir_logra);
            this.Controls.Add(this.txt_Logra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoTipo);
            this.Controls.Add(this.btn_addimage);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.ClientesID);
            this.Controls.Add(this.dgv_busca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_procurar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_busca;
        private System.Windows.Forms.Label ClientesID;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_addimage;
        private System.Windows.Forms.PictureBox LogoTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Logra;
        private System.Windows.Forms.Button btn_inserir_logra;
        private System.Windows.Forms.Button btn_excluir_logra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_Cli;
        private System.Windows.Forms.Button btn_alterar_logra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_log;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}