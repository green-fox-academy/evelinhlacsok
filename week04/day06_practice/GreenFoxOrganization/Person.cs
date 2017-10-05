using System;

namespace GreenFoxOrganization
{
    public class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person()
        {
            name = "Jane";
            age = 30;
            gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", name, age, gender); 
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}