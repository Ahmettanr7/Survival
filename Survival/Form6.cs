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
    public partial class Form6 : Form
    {
        int point_ = 0;
        public Form6()
        {
            InitializeComponent();
        }

        public void Gamer_Get()
        {
            //Oyun bilgilerini getir
            var url2 = "https://localhost:44385/api/games/getbyid?id="+GameService.game.Id;
            var request2 = WebRequest.Create(url2);
            request2.Method = "GET";
            request2.ContentType = "application/json";
            using var response2 = request2.GetResponse();
            using var respStream2 = response2.GetResponseStream();
            using var reader2 = new StreamReader(respStream2);

            dynamic array2 = JsonConvert.DeserializeObject(reader2.ReadToEnd());
            point_ = array2["data"]["totalPoint"];
            label2.Text = "Puan : " + point_;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Gamer_Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameService.game = new Game()
            {};
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
