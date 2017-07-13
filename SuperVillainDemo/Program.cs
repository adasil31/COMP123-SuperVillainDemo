using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperVillainDemo;



namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperVillain superVillain = new SuperVillain("Black Panther", 80);
            superVillain.AddPower("Cat women", 100);
            superVillain.AddPower("Hammer", 2000);
            Console.WriteLine(superVillain.ToString());


        }
    }
}