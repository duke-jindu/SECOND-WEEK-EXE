
using school_oop.student;
using school_oop.courses;
//using school_oop.entity;
using school_oop.teacher;





//using school_oop.school;



//namespace school
//{


//class School
//{
//    public School() { }
//    // public float RegNumber { get; set; }
//    public string Name { get; set; }
//    // public string courses { get; set; }
//    //public string courseName { get; set; }

//}



namespace school_oop
{



class program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "duke chukwujindu";
            student.RegNumber = 2018374013;

           Teacher teacher = new Teacher();
            teacher.Name = "Mis Jennifer";
            teacher.NumberOfCourses = 4;

            Courses courses = new Courses();
            courses.Name = "programming in c#";
            courses.course_completed = 65 ;
            courses.Times_Taught = 5;


            student.student_info();
            teacher.teacher_info();
           // Teacher.teacher_Info();
            courses.Courses_Info();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("press enter");

            Console.ReadKey();
            


            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(" ");

            //for the Animals

            Dog dog = new Dog();
            dog.Age = 5;
            dog.Name = "spark";
            dog.Gender = "Male";
        //  dog.Make_Sound();

            Frog frog = new Frog();
            frog.Age = 3;
            frog.Name = "froggy";
            frog.Gender = "Female";
        //  frog.Make_Sound();

            cat cats = new cat();
            cats.Age = 2;
            cats.Name = "zoe";
            cats.Gender = "Female";
        //  cats.Make_Sound();

            Kitten kittens = new Kitten();
            kittens.Age = 2;
            kittens.Name = "Summer";
            kittens.Gender = "Male";
        //  kittens.Make_Sound();

            Tomcat tomcat = new Tomcat();
            tomcat.Age = 6;
            tomcat.Name = "mr fuzzyPants";
            tomcat.Gender = "Male";
        //  tomcat.Make_Sound();

            dog.dog_details();
            frog.frog_details();
            cats.cat_detail();
            kittens.kitten_detail();
            tomcat.tomcat_detail();

            Console.ReadKey();

        }
    }
}
//}
