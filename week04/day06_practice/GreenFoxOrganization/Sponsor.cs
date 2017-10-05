using System;

namespace GreenFoxOrganization
{
    public class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", 
                name, age, gender, company, hiredStudents);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }
    }
}