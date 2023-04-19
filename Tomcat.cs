using school_oop.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_oop
{
    public class Tomcat : Animals
    {
        public Tomcat() { }

        public void tomcat_detail()
        {
            Console.WriteLine("TOMCAT");

            string Detail = $"Animal name : {this.Name} \n Age of Animal : {this.Age} years old \n" +
               $"Gender  : {this.Gender} ";
            Console.WriteLine(Detail);
            Make_Sound();

            Console.WriteLine("............................");
            Console.WriteLine(" ");

        }
    }
}
