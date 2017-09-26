using System;
using System.Globalization;

namespace GreenFoxOrganization
{
    public class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name = "Jane Doe", int age = 30, string gender = "female", string company =
            "Google", int hiredStudents = 0)
        {

        }


        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + "year old " + gender + "who represents " + company + "and " +
                              "hired " + hiredStudents + "students so far.");
        }

        public int Hire()
        {
            return hiredStudents++;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
           
    }
}