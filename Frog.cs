using school_oop.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_oop
{
    public class Frog : Animals
    {
        public Frog() { }

        public void frog_details()
        {
            Console.WriteLine("FROG");

            string Detail = $"Animal name : {this.Name} \nAge of Animal : {this.Age} years old \n" +
                $"Gender  : {this.Gender} ";
            Console.WriteLine(Detail);

            Make_Sound();
            Console.WriteLine("............................");
            Console.WriteLine(" ");

        }

        public override void Make_Sound()
        {
            Console.WriteLine("frogs Ribbit ");
        }
    }
}
