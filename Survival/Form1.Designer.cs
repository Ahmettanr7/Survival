
namespace Survival
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.kayitAdSoyad = new System.Windows.Forms.TextBox();
            this.kayitEmail = new System.Windows.Forms.TextBox();
            this.kayitSifre = new System.Windows.Forms.TextBox();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(828, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAYIT OL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kayitAdSoyad
            // 
            this.kayitAdSoyad.BackColor = System.Drawing.Color.PeachPuff;
            this.kayitAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayitAdSoyad.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitAdSoyad.ForeColor = System.Drawing.Color.SandyBrown;
            this.kayitAdSoyad.Location = new System.Drawing.Point(640, 360);
            this.kayitAdSoyad.Multiline = true;
            this.kayitAdSoyad.Name = "kayitAdSoyad";
            this.kayitAdSoyad.Size = new System.Drawing.Size(640, 50);
            this.kayitAdSoyad.TabIndex = 2;
            this.kayitAdSoyad.Text = "Ad Soyad";
            this.kayitAdSoyad.Enter += new System.EventHandler(this.kayitAdSoyad_Enter);
            this.kayitAdSoyad.Leave += new System.EventHandler(this.kayitAdSoyad_Leave);
            // 
            // kayitEmail
            // 
            this.kayitEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.kayitEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayitEmail.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitEmail.ForeColor = System.Drawing.Color.SandyBrown;
            this.kayitEmail.Location = new System.Drawing.Point(640, 480);
            this.kayitEmail.Multiline = true;
            this.kayitEmail.Name = "kayitEmail";
            this.kayitEmail.Size = new System.Drawing.Size(640, 50);
            this.kayitEmail.TabIndex = 3;
            this.kayitEmail.Text = "E-Posta";
            this.kayitEmail.Enter += new System.EventHandler(this.kayitEmail_Enter);
            this.kayitEmail.Leave += new System.EventHandler(this.kayitEmail_Leave);
            // 
            // kayitSifre
            // 
            this.kayitSifre.BackColor = System.Drawing.Color.PeachPuff;
            this.kayitSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayitSifre.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitSifre.ForeColor = System.Drawing.Color.SandyBrown;
            this.kayitSifre.Location = new System.Drawing.Point(640, 600);
            this.kayitSifre.Multiline = true;
            this.kayitSifre.Name = "kayitSifre";
            this.kayitSifre.Size = new System.Drawing.Size(640, 50);
            this.kayitSifre.TabIndex = 4;
            this.kayitSifre.Text = "Şifre";
            this.kayitSifre.Enter += new System.EventHandler(this.kayitSifre_Enter);
            this.kayitSifre.Leave += new System.EventHandler(this.kayitSifre_Leave);
            // 
            // kayitBtn
            // 
            this.kayitBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.kayitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitBtn.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitBtn.ForeColor = System.Drawing.Color.LightSalmon;
            this.kayitBtn.Location = new System.Drawing.Point(1016, 716);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(264, 82);
            this.kayitBtn.TabIndex = 5;
            this.kayitBtn.Text = "Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = false;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(640, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesabım Var Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.kayitSifre);
            this.Controls.Add(this.kayitEmail);
            this.Controls.Add(this.kayitAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Survival";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kayitAdSoyad;
        private System.Windows.Forms.TextBox kayitEmail;
        private System.Windows.Forms.TextBox kayitSifre;
        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.Button button1;
    }
}

