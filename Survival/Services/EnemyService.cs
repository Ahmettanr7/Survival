using Newtonsoft.Json;
using Survival.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Survival.Services
{
    public class EnemyService
    {
        Enemy Vampir;
        Enemy Zombi;
        Enemy Haydut;

        public void GetAll()
        {
            var url = "https://localhost:44385/api/enemies/getall";

            var request = WebRequest.Create(url);
            request.Method = "GET";


            request.ContentType = "application/json";

            using var response = request.GetResponse();

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            dynamic array = JsonConvert.DeserializeObject(reader.ReadToEnd());

            Vampir = new Enemy()
            {
                Id = array["data"][0]["id"],
                Name = array["data"][0]["name"].ToString(),
                Healty = array["data"][0]["healty"],
                Point = array["data"][0]["point"],
                ForcedTax = array["data"][0]["forcedTax"],
                Message = array["data"][0]["message"].ToString()

            };
            Zombi = new Enemy()
            {
                Id = array["data"][1]["id"],
                Name = array["data"][1]["name"].ToString(),
                Healty = array["data"][1]["healty"],
                Point = array["data"][1]["point"],
                ForcedTax = array["data"][1]["forcedTax"],
                Message = array["data"][1]["message"].ToString()

            };
            Haydut = new Enemy()
            {
                Id = array["data"][2]["id"],
                Name = array["data"][2]["name"].ToString(),
                Healty = array["data"][2]["healty"],
                Point = array["data"][2]["point"],
                ForcedTax = array["data"][2]["forcedTax"],
                Message = array["data"][2]["message"].ToString()
            };
        }
    }
}
