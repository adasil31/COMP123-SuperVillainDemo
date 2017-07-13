using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SuperVillainDemo
{


    public class Power
    {

        public string Name { get; set; }
        public int Malice { get; set; }

        public Power(string name, int rank)
        {
            this.Name = name;
            this.Malice = rank;
        }
    }
}