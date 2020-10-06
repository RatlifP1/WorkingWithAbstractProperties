using System;

namespace AbstractProperties
{
    class Program
    {
        public abstract class Person 
        {
            //public abstract string Code { get; set; }
            public abstract string Name { get; set; }
            public abstract int Age { get; set; }
        }
        /*public*/ class Student : Person
        {
            private string code = "N.A.";
            private string name = "N.A.";
        private int age = 0;
            //declare a Code property of type string
            public /*override*/ string Code
            {
                get { return code; }
                set { code = value; }
            }
            public override string Name
        {
            get{return name;}
            set{name = value;}
        }
        public override int Age
        {
            get{return age;}
            set{age = value;}
        }
            public override string ToString()
            {
                return ("Code = " + Code + ", Name = " + Name + ", Age " + Age);
            }
    }
        public static void Main(string[] args)
        {
            //create a new student object:
            Student s = new Student();

            //Setting code, name and the age of the student.
            s.Code = "007";
            s.Name = "James Bond";
            s.Age = 42;
            Console.WriteLine("Student Info:{0}", s);
            //Let us incremeant age
            s.Age++;
            //s.Age += 10; to add age more than 1
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}

