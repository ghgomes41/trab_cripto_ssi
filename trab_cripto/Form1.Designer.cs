namespace trab_cripto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbCryp = new System.Windows.Forms.RadioButton();
            this.rbDecryp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exec_btn1 = new System.Windows.Forms.Button();
            this.exec_btn2 = new System.Windows.Forms.Button();
            this.txt_src1 = new System.Windows.Forms.TextBox();
            this.txt_src2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_target1 = new System.Windows.Forms.TextBox();
            this.txt_target2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCryp
            // 
            this.rbCryp.AutoSize = true;
            this.rbCryp.Location = new System.Drawing.Point(12, 12);
            this.rbCryp.Name = "rbCryp";
            this.rbCryp.Size = new System.Drawing.Size(79, 17);
            this.rbCryp.TabIndex = 0;
            this.rbCryp.Text = "Criptografar";
            this.rbCryp.UseVisualStyleBackColor = true;
            this.rbCryp.CheckedChanged += new System.EventHandler(this.RbCryp_CheckedChanged);
            // 
            // rbDecryp
            // 
            this.rbDecryp.AutoSize = true;
            this.rbDecryp.Location = new System.Drawing.Point(12, 168);
            this.rbDecryp.Name = "rbDecryp";
            this.rbDecryp.Size = new System.Drawing.Size(97, 17);
            this.rbDecryp.TabIndex = 1;
            this.rbDecryp.Text = "Descriptografar";
            this.rbDecryp.UseVisualStyleBackColor = true;
            this.rbDecryp.CheckedChanged += new System.EventHandler(this.RbDecryp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_target1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_src1);
            this.panel1.Controls.Add(this.exec_btn1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 127);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_target2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_src2);
            this.panel2.Controls.Add(this.exec_btn2);
            this.panel2.Location = new System.Drawing.Point(12, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 127);
            this.panel2.TabIndex = 3;
            // 
            // exec_btn1
            // 
            this.exec_btn1.Location = new System.Drawing.Point(454, 27);
            this.exec_btn1.Name = "exec_btn1";
            this.exec_btn1.Size = new System.Drawing.Size(75, 23);
            this.exec_btn1.TabIndex = 0;
            this.exec_btn1.Text = "Executar";
            this.exec_btn1.UseVisualStyleBackColor = true;
            this.exec_btn1.Click += new System.EventHandler(this.Exec_btn1_Click);
            // 
            // exec_btn2
            // 
            this.exec_btn2.Location = new System.Drawing.Point(454, 34);
            this.exec_btn2.Name = "exec_btn2";
            this.exec_btn2.Size = new System.Drawing.Size(75, 23);
            this.exec_btn2.TabIndex = 1;
            this.exec_btn2.Text = "Executar";
            this.exec_btn2.UseVisualStyleBackColor = true;
            this.exec_btn2.Click += new System.EventHandler(this.Exec_btn2_Click);
            // 
            // txt_src1
            // 
            this.txt_src1.Location = new System.Drawing.Point(15, 28);
            this.txt_src1.Name = "txt_src1";
            this.txt_src1.Size = new System.Drawing.Size(433, 20);
            this.txt_src1.TabIndex = 1;
            // 
            // txt_src2
            // 
            this.txt_src2.Location = new System.Drawing.Point(15, 37);
            this.txt_src2.Name = "txt_src2";
            this.txt_src2.Size = new System.Drawing.Size(433, 20);
            this.txt_src2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a mensagem que deseja criptografar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira a mensagem que deseja descriptografar:";
            // 
            // txt_target1
            // 
            this.txt_target1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_target1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_target1.Location = new System.Drawing.Point(15, 83);
            this.txt_target1.Name = "txt_target1";
            this.txt_target1.ReadOnly = true;
            this.txt_target1.Size = new System.Drawing.Size(433, 20);
            this.txt_target1.TabIndex = 3;
            // 
            // txt_target2
            // 
            this.txt_target2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_target2.Location = new System.Drawing.Point(15, 88);
            this.txt_target2.Name = "txt_target2";
            this.txt_target2.ReadOnly = true;
            this.txt_target2.Size = new System.Drawing.Size(433, 20);
            this.txt_target2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(466, 327);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(385, 327);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 362);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbDecryp);
            this.Controls.Add(this.rbCryp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalho SSI - Criptografia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCryp;
        private System.Windows.Forms.RadioButton rbDecryp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_src1;
        private System.Windows.Forms.Button exec_btn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_target2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_src2;
        private System.Windows.Forms.Button exec_btn2;
        private System.Windows.Forms.TextBox txt_target1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
    }
}

