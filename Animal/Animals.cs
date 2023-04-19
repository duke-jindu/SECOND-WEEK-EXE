using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_oop.Animal
{
   public class Animals
    {
        public Animals() { }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual void Make_Sound()
        {
            Console.WriteLine("All cats meows! ");
        }
    }
}
