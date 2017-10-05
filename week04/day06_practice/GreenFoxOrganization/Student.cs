using System;

namespace GreenFoxOrganization
{
    public class Student : Person

    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            previousOrganization = "the school of life";
            skippedDays = 0;
        }
        
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who " +
                              "skipped {4} from the course already.", name, age, gender, previousOrganization,
                               skippedDays);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}