using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Survival.Entities;
using Survival.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Survival.Services
{
    public class AuthService
    {
        public static User user = new User();
        public static void Register(string nameSurname,string email,string pass)
        {
            var url = "https://localhost:44385/api/auth/register";

            var request = WebRequest.Create(url);
            request.Method = "POST";
            user.NameSurname = nameSurname;
            user.Email = email;
            user.Password = pass;
            var json = System.Text.Json.JsonSerializer.Serialize(user);
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
                user.Token = array["data"]["token"].ToString();
                user.Id = array["message"];
                Form1 form1 = new Form1();
                Form3 form3 = new Form3();
                form3.Show();
                form1.Hide();
            }
            else { MessageBox.Show("Opps. İşlem Başarısız. Tekrar Dene"); }

        }   
        
        public static void Login(string email, string pass)
        {
            //post giriş
            var url = "https://localhost:44385/api/auth/login";
            var request = WebRequest.Create(url);
            request.Method = "POST";
            user.Email = email;
            user.Password = pass;
            var json = System.Text.Json.JsonSerializer.Serialize(user);
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
                // get kullanıcı bilgileri
                var url2 = "https://localhost:44385/api/users/getbyemail?email=" + email;
                var request2 = WebRequest.Create(url2);
                request2.Method = "GET";
                request2.ContentType = "application/json";
                using var response2 = request2.GetResponse();
                using var respStream2 = response2.GetResponseStream();
                using var reader2 = new StreamReader(respStream2);

                dynamic array2 = JsonConvert.DeserializeObject(reader2.ReadToEnd());
                user = new User()
                {
                    Id = array2["data"]["id"],
                    NameSurname = array2["data"]["nameSurname"].ToString(),
                    Email = array2["data"]["email"].ToString(),
                    Token = array["data"]["token"].ToString()
                };
                Form3 form3 = new Form3();
                Form2 form2 = new Form2();
                form3.Show();
                form2.Hide();
            }
            else { MessageBox.Show("Opps. İşlem Başarısız. Tekrar Dene"); }
        }
    }
}
