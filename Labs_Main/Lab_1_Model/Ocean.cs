﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Model
{
    public class Ocean
    {
        private string name = "undefined";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Ocean(string name)
        {
            this.name = name;
        }
    }
}
