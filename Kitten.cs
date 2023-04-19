using school_oop.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_oop
{
    public class Kitten : Animals
    {
        public Kitten() { }

        public void kitten_detail()
        {
            Console.WriteLine("KITTEN");

            string Detail = $"Animal name : {this.Name} \nAge of Animal : {this.Age} months old \n" +
               $"Gender  : {this.Gender} ";
            Console.WriteLine(Detail);
            Make_Sound();

            Console.WriteLine("............................");
            Console.WriteLine(" ");

        }

    }
}
