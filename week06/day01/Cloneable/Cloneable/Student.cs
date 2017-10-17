﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public class Student : Person, ICloneable
    {
        private readonly string previousOrganization;
        private int skippedDays;

        public Student(string name = "Jane Doe", int age = 30, string gender = "female", string previousOrganization =
            "School of life", int skippedDays = 0)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }


        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " + previousOrganization +
            " who skipped " + skippedDays + " days from the course already.");
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student();
        }
    }
}
