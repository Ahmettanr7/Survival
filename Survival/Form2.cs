using Survival.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void girisEmail_Enter(object sender, EventArgs e)
        {
            if (girisEmail.Text == "E-Posta")
            {
                girisEmail.Text = "";
                girisEmail.ForeColor = Color.SaddleBrown;
            }
        }

        private void girisEmail_Leave(object sender, EventArgs e)
        {
            if (girisEmail.Text == "")
            {
                girisEmail.Text = "E-Posta";
                girisEmail.ForeColor = Color.SandyBrown;
            }
        }

        private void girisSifre_Enter(object sender, EventArgs e)
        {
            if (girisSifre.Text == "Şifre")
            {
                girisSifre.Text = "";
                girisSifre.ForeColor = Color.SaddleBrown;
                girisSifre.PasswordChar = '*';
            }
        }

        char? none = null;
        private void girisSifre_Leave(object sender, EventArgs e)
        {
            if (girisSifre.Text == "")
            {
                girisSifre.Text = "Şifre";
                girisSifre.ForeColor = Color.SandyBrown;
                girisSifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (girisEmail.Text != "E-Posta" && girisSifre.Text != "Şifre")
            {
                AuthService.Login(girisEmail.Text, girisSifre.Text);
            }
            else { MessageBox.Show("Bütün Alanları Doldurunuz!"); }


        }

        private void girisBtn_Click_1(object sender, EventArgs e)
        {
            if (girisEmail.Text != "E-Posta" && girisSifre.Text != "Şifre")
            {
                AuthService.Login(girisEmail.Text, girisSifre.Text);
                if (AuthService.user.Token != "")
                {
                    this.Hide();
                }
            }
            else { MessageBox.Show(AuthService.user.Token); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
