using System;
using System.Collections.Generic;
using System.Text;

namespace Survival.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
