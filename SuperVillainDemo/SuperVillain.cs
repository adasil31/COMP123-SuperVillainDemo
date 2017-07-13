using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperVillainDemo
{
  
    public class SuperVillain : Villain
    {
       
        private List<Power> _powers;
        private int v;

        public List<Power> Powers
        {
            get
            {
                return this._powers; 
            }
        }

        public string Name { get; private set; }

        public SuperVillain(string malice)
            : base(malice)
        {
            this._initialize();
        }

        public SuperVillain(string malice, int v) : this(malice)
        {
            this.v = v;
        }

        private void _initialize()
        {
            this._powers = new List<Power>();
        }

      
        public void AddPower(string name, int malice)
        {
            this.Powers.Add(new Power(name, malice));
        }

        
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Malice);
            }
        }

        
        public override string ToString()
        {
            string outputString = "";
            outputString += "===========================================================\n";
            outputString += "Super Villain Name: " + this.Name + "\n";
            outputString += "===========================================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Malice + "\n";
            }
            outputString += "===========================================================\n";
            return outputString;
        }

       
        public  void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }
    }
}