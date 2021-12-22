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
    public partial class Form5 : Form
    {
        Store Item1;
        Store Item2;
        Store Item3;
        int money_;
        public Form5()
        {
            InitializeComponent();
        }

        private void Get_Gold()
        {
            //Oyun bilgilerini getir
            var url2 = "https://localhost:44385/api/games/getbyid?id=" + GameService.game.Id;
            var request2 = WebRequest.Create(url2);
            request2.Method = "GET";
            request2.ContentType = "application/json";
            using var response2 = request2.GetResponse();
            using var respStream2 = response2.GetResponseStream();
            using var reader2 = new StreamReader(respStream2);

            dynamic array2 = JsonConvert.DeserializeObject(reader2.ReadToEnd());
            money_ = array2["data"]["money"];
            label7.Text = "Altın : " + money_;
            label8.Text = "Sağlık : " + array2["data"]["healty"];
        }

        private void Get_Item()
        {
            var url = "https://localhost:44385/api/store/getall";

            var request = WebRequest.Create(url);
            request.Method = "GET";


            request.ContentType = "application/json";

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            Item1 = new Store()
            {
                Id = array["data"][0]["id"],
                Name = array["data"][0]["name"].ToString(),
                Price = array["data"][0]["price"],
                Amount = array["data"][0]["amount"]
            };
            Item2 = new Store()
            {
                Id = array["data"][1]["id"],
                Name = array["data"][1]["name"].ToString(),
                Price = array["data"][1]["price"],
                Amount = array["data"][1]["amount"]
            };
            Item3 = new Store()
            {
                Id = array["data"][2]["id"],
                Name = array["data"][2]["name"].ToString(),
                Price = array["data"][2]["price"],
                Amount = array["data"][2]["amount"]
            };
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Get_Item();
            Get_Gold();
            label1.Text = Item1.Name;
            label2.Text = Item1.Price.ToString();
            label4.Text = Item2.Name;
            label3.Text = Item2.Price.ToString();
            label6.Text = Item3.Name;
            label5.Text = Item3.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameService.Shopping(Item1,money_);
            Get_Gold();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameService.Shopping(Item2,money_);
            Get_Gold();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameService.Shopping(Item3,money_);
            Get_Gold();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Gamer_Get();
            form4.Refresh();
        }
    }
}
