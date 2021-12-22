using Newtonsoft.Json;
using Survival.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Survival.Services
{
    public class GameService
    {
        public static Game game = new Game();
        public static void Start(int charId,int healty, int money)
        {
            var url = "https://localhost:44385/api/games/add";

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + AuthService.user.Token;


            game.UserId = AuthService.user.Id;
            game.CharId = charId;
            game.TotalPoint = 0;
            game.Money = money;
            game.Healty = healty;
            var json = System.Text.Json.JsonSerializer.Serialize(game);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            using var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            if (array["success"].ToString() == "True")
            {
                game = new Game()
                {
                    Id = array["message"],
                    UserId = AuthService.user.Id,
                    CharId = charId,
                    Money = money,
                    Healty = healty,
                    TotalPoint = 0
                };
            }
            else { MessageBox.Show("Opps. İşlem Başarısız. Tekrar Dene"); }

        }

        public static void War(Enemy enemy, int healty)
        {        
            var url = "https://localhost:44385/api/games/war?gameId="+game.Id+"&enemyId="+enemy.Id;

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + AuthService.user.Token;

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            if (array["success"].ToString() == "True")
            {

            }
            else { MessageBox.Show("Opps. Bir Şeyler Ters Gidiyor"); }

        }

        public static void Escape(Enemy enemy,int money, int healty)
        {
            if (money < enemy.ForcedTax)
            {
                MessageBox.Show("Yeterli Altının Yok. Kaçamadın!");
                War(enemy,healty);
            }
            else
            {
            var url = "https://localhost:44385/api/games/escape?gameId=" + game.Id + "&enemyId=" + enemy.Id;

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + AuthService.user.Token;

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            if (array["success"].ToString() == "True")
            {

            }
            else { MessageBox.Show("Opps. Bir Şeyler Ters Gidiyor"); }
            }

        }

        public static void Shopping(Store item,int money)
        {
            if (money < item.Price)
            {
                MessageBox.Show("Yeterli Altının Yok");
            }
            else { 

            var url = "https://localhost:44385/api/games/shopping?gameId=" + game.Id + "&itemId=" + item.Id;

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers["Authorization"] = "Bearer " + AuthService.user.Token;

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            if (array["success"].ToString() == "True")
            {

            }
            else { MessageBox.Show("Opps. Bir Şeyler Ters Gidiyor"); }
            }
        }
    }
}
