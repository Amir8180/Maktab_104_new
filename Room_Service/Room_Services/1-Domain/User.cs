﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public long National_Code { get; set; }
        public long Phone_Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


    }
}