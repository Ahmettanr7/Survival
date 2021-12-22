using Newtonsoft.Json;
using Survival.Entities;
using Survival.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form3 : Form
    {
        Character Samuray;
        Character Okcu;
        Character Sovalye;

        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            var url = "https://localhost:44385/api/characters/getall";

            var request = WebRequest.Create(url);
            request.Method = "GET";


            request.ContentType = "application/json";

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            Sovalye = new Character()
            {
                Id = array["data"][0]["id"],
                Name = array["data"][0]["name"].ToString(),
                Money = array["data"][0]["money"],
                Healty = array["data"][0]["healty"]
            };
            Samuray = new Character()
            {
                Id = array["data"][1]["id"],
                Name = array["data"][1]["name"].ToString(),
                Money = array["data"][1]["money"],
                Healty = array["data"][1]["healty"]
            };
            Okcu = new Character()
            {
                Id = array["data"][2]["id"],
                Name = array["data"][2]["name"].ToString(),
                Money = array["data"][2]["money"],
                Healty = array["data"][2]["healty"]
            };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = Sovalye.Name;
            label2.Text = "Altın : " + Sovalye.Money;
            label3.Text = "Sağlık : " + Sovalye.Healty;

            groupBox2.Text = Samuray.Name;
            label4.Text = "Altın : " + Samuray.Money;
            label5.Text = "Sağlık : " + Samuray.Healty;

            groupBox3.Text = Okcu.Name;
            label6.Text = "Altın : " + Okcu.Money;
            label7.Text = "Sağlık : " + Okcu.Healty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameService.Start(Samuray.Id, Samuray.Healty, Samuray.Money);
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameService.Start(Okcu.Id,Okcu.Money, Okcu.Healty);
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameService.Start(Sovalye.Id, Sovalye.Healty, Sovalye.Money);
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
