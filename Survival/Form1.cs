using Newtonsoft.Json.Linq;
using Survival.Entities;
using Survival.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kayitAdSoyad_Enter(object sender, EventArgs e)
        {
            if (kayitAdSoyad.Text == "Ad Soyad")
            {
                kayitAdSoyad.Text = "";
                kayitAdSoyad.ForeColor = Color.SaddleBrown;
            }
        }

        private void kayitAdSoyad_Leave(object sender, EventArgs e)
        {
            if (kayitAdSoyad.Text == "")
            {
                kayitAdSoyad.Text = "Ad Soyad";
                kayitAdSoyad.ForeColor = Color.SandyBrown;
            }
        }

        private void kayitEmail_Enter(object sender, EventArgs e)
        {
            if (kayitEmail.Text == "E-Posta")
            {
                kayitEmail.Text = "";
                kayitEmail.ForeColor = Color.SaddleBrown;
            }
        }

        private void kayitEmail_Leave(object sender, EventArgs e)
        {
            if (kayitEmail.Text == "")
            {
                kayitEmail.Text = "E-Posta";
                kayitEmail.ForeColor = Color.SandyBrown;
            }
        }

        private void kayitSifre_Enter(object sender, EventArgs e)
        {
            if (kayitSifre.Text == "Şifre")
            {
                kayitSifre.Text = "";
                kayitSifre.ForeColor = Color.SaddleBrown;
                kayitSifre.PasswordChar = '*';
            }
        }

        char? none = null;
        private void kayitSifre_Leave(object sender, EventArgs e)
        {
            if (kayitSifre.Text == "")
            {
                kayitSifre.Text = "Şifre";
                kayitSifre.ForeColor = Color.SandyBrown;
                kayitSifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            if (kayitAdSoyad.Text != "Ad Soyad" && kayitEmail.Text != "E-Posta" && kayitSifre.Text != "Şifre")
            {
                AuthService.Register(kayitAdSoyad.Text, kayitEmail.Text, kayitSifre.Text);
            }
            else { MessageBox.Show("Bütün Alanları Doldurunuz!"); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
