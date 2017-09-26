﻿using System;
namespace GreenFoxOrganization
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string gender;
        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        
        public void Introduce ()
        {
            Console.WriteLine("Hi, I'm" + name + ", a" + age + "year old" + gender + ".");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
