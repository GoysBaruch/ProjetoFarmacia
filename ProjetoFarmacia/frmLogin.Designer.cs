namespace ProjetoFarmacia
{
    partial class frmLogin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.TabCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.TabCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.textBox2);
            this.TabLogin.Controls.Add(this.label2);
            this.TabLogin.Controls.Add(this.textBox1);
            this.TabLogin.Controls.Add(this.label1);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabLogin.Size = new System.Drawing.Size(655, 322);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // TabCadastro
            // 
            this.TabCadastro.Location = new System.Drawing.Point(4, 22);
            this.TabCadastro.Name = "TabCadastro";
            this.TabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadastro.Size = new System.Drawing.Size(767, 329);
            this.TabCadastro.TabIndex = 1;
            this.TabCadastro.Text = "Cadastro";
            this.TabCadastro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 29);
            this.textBox2.TabIndex = 3;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.TabPage TabCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}