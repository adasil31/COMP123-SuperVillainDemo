using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace SuperVillainDemo
{

    public class SuperHero : SuperVillain
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        public SuperHero(string name, int Malice)
            : base(name)
        {
            this.Malice = Malice;
        }


    }
}
