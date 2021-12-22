﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Survival.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CharId { get; set; }
        public int TotalPoint { get; set; }
        public int Money { get; set; }
        public int Healty { get; set; }
    }
}
