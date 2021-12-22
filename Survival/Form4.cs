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
    public partial class Form4 : Form
    {
        Enemy RandEnemy = null;
        int money_;
        int healty_;

        public Form4()
        {
            InitializeComponent();
            if (GameService.game.Id == 0 || AuthService.user.Token == null)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void Enemy_get()
        {
            //1 düşman getir
            var rand = new Random();
            var url = "https://localhost:44385/api/enemies/getbyid?id=" + rand.Next(1, 4);
            var request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            using var response = request.GetResponse();
            using var respStream = response.GetResponseStream();
            using var reader = new StreamReader(respStream);

            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            RandEnemy = new Enemy()
            {
                Id = array["data"]["id"],
                Name = array["data"]["name"].ToString(),
                Healty = array["data"]["healty"],
                Point = array["data"]["point"],
                ForcedTax = array["data"]["forcedTax"],
                Message = array["data"]["message"].ToString()
            };

            if (RandEnemy.Id == 1)
            {
                Image resim = new Bitmap(@"C:\Users\Ahmet Tanrıkulu\source\repos\Survival\Survival\Properties\img\vampir.jpg");
                this.BackgroundImage = resim;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                label1.Text = RandEnemy.Message;

            }
            else if (RandEnemy.Id == 2)
            {
                Image resim = new Bitmap(@"C:\Users\Ahmet Tanrıkulu\source\repos\Survival\Survival\Properties\img\zombi.jpg");
                this.BackgroundImage = resim;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                label1.Text = RandEnemy.Message;

            }
            else if (RandEnemy.Id == 3)
            {
                Image resim = new Bitmap(@"C:\Users\Ahmet Tanrıkulu\source\repos\Survival\Survival\Properties\img\haydut.jpg");
                this.BackgroundImage = resim;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                label1.Text = RandEnemy.Message;
            }

            button2.Text = "Savaş" + "\n" + " +" + RandEnemy.Point + " puan" + "\n" + " -" + RandEnemy.Healty + " sağlık";
            button3.Text = "Kaç" + " -" + RandEnemy.ForcedTax + " altın";
        }

        public void Gamer_Get()
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
            healty_ = array2["data"]["healty"];
            money_ = array2["data"]["money"];
            label7.Text = "Altın : " + money_;
            label8.Text = "Puan : " + array2["data"]["totalPoint"];
            label9.Text = "Sağlık : " + healty_;


        }

        private void Character_Get()
        {
            //Karakter Bilgilerini getir
            var url3 = "https://localhost:44385/api/characters/getbyid?id=" + GameService.game.CharId;
            var request3 = WebRequest.Create(url3);
            request3.Method = "GET";
            request3.ContentType = "application/json";
            using var response3 = request3.GetResponse();
            using var respStream3 = response3.GetResponseStream();
            using var reader3 = new StreamReader(respStream3);

            dynamic array3 = JsonConvert.DeserializeObject(reader3.ReadToEnd());

            label6.Text = "Karakter : " + array3["data"]["name"].ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label5.Text = "Oyuncu : " + AuthService.user.NameSurname;
            Enemy_get();
            Character_Get();
            Gamer_Get();
            if (healty_ <= 0)
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Size.Width) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameService.War(RandEnemy,healty_);
            Form4_Load(null,null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameService.Escape(RandEnemy, money_, healty_);
            Form4_Load(null, null);
        }

    }
}
