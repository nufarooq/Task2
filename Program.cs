using System;

namespace PersonInheritanceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int total = 3;
            Person[] persons = new Person[total];
            Console.WriteLine("Enter 3 Person Name");
            for (int i = 0; i < total; i++)
            {
                if(i==0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
                
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
                if (i == 0)
                {
                    persons[i].Explain();
                }
                else
                {
                    persons[i].Study();
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Entered name is " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }

        public virtual void Explain()
        { 
        }

        public virtual void Study()
        { 
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public override void Explain()
        {
            Console.WriteLine("Teacher is Explaining");
        }
    }
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public override void Study()
        {
            Console.WriteLine("Student is Studying");
        }

    }
}