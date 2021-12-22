
namespace Survival
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.girisEmail = new System.Windows.Forms.TextBox();
            this.girisSifre = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girisEmail
            // 
            this.girisEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.girisEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.girisEmail.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisEmail.ForeColor = System.Drawing.Color.SandyBrown;
            this.girisEmail.Location = new System.Drawing.Point(640, 480);
            this.girisEmail.Multiline = true;
            this.girisEmail.Name = "girisEmail";
            this.girisEmail.Size = new System.Drawing.Size(640, 50);
            this.girisEmail.TabIndex = 4;
            this.girisEmail.Text = "E-Posta";
            this.girisEmail.Enter += new System.EventHandler(this.girisEmail_Enter);
            this.girisEmail.Leave += new System.EventHandler(this.girisEmail_Leave);
            // 
            // girisSifre
            // 
            this.girisSifre.BackColor = System.Drawing.Color.PeachPuff;
            this.girisSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.girisSifre.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisSifre.ForeColor = System.Drawing.Color.SandyBrown;
            this.girisSifre.Location = new System.Drawing.Point(640, 600);
            this.girisSifre.Multiline = true;
            this.girisSifre.Name = "girisSifre";
            this.girisSifre.Size = new System.Drawing.Size(640, 50);
            this.girisSifre.TabIndex = 5;
            this.girisSifre.Text = "Şifre";
            this.girisSifre.Enter += new System.EventHandler(this.girisSifre_Enter);
            this.girisSifre.Leave += new System.EventHandler(this.girisSifre_Leave);
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.girisBtn.Location = new System.Drawing.Point(855, 750);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(215, 68);
            this.girisBtn.TabIndex = 6;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(781, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "GİRİŞ YAP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1871, 904);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.girisSifre);
            this.Controls.Add(this.girisEmail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox girisEmail;
        private System.Windows.Forms.TextBox girisSifre;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label label1;
    }
}