﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Score { get; set; }
        public string Discription { get; set; }
    }
}
