using System;
using System.Collections.Generic;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //Person person = new Person();
            //person.name = "Sarfraz";
            //person.id = 9;
            //person.age = 26;
            //person.DOB = DateTime.Today;
            //Person person1 = new Person(person);
            //Console.WriteLine(person1.id);
            //List<Student> students = new List<Student>()
            //{
            //    new Student {name = "Sarfraz"},
            //    new Student { name = "Noman" },
            //    new Student { name = "Ali" }
            //};
            //students.Add(new Student {name = "Sarfraz"});
            //students.Add(new Student { name = "Noman" });
            //students.Add(new Student { name = "Ali" });
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.name);
            //}


            Console.ReadLine();
        }
    }


    public class Person
    {
        public int id;
        public string name;
        public DateTime DOB;
        public int age;
        public Address address;
        public Person()
        {
            Console.WriteLine("Hello Person!");
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(Person person)
        {
            id = person.id;
        }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(int id,string name,DateTime DOB, int age , Address address)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
            this.DOB = DOB;  
        }
        

        public string GetName()
        {
            name = "Parent";
            return name;
        }
    }

    public class Student : Person
    {
        public string grade;
        public string className;
        public Student()
        {
            Console.WriteLine("Hello Student!");
        }
        

        public string GetName()
        {
            name = "child";
            return name;
        }
        
    }
    public class Employe : Person
    {
        public Employe()
        {
            Console.WriteLine("Hello Employe!");
        }
    }

    public class Address
    {
        public string CountryName;
        public string CityName;
        public int HouseNo;
    }
}
