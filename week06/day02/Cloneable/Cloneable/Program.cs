using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person mark = new Person("Mark", 46, "male");
            people.Add(mark);
            Person jane = new Person();
            people.Add(jane);
            Student john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            Student student = new Student();
            people.Add(student);
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            Mentor mentor = new Mentor();
            people.Add(mentor);
            Mentor mrhelp = new Mentor("mrHelp", 32, "male", "senior");
            people.Add(mrhelp);
            Mentor mrhelp2 = new Mentor("mrHelp", 32, "male", "senior");
            people.Add(mrhelp2);
            Sponsor sponsor = new Sponsor();
            people.Add(sponsor);
            Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);
            Sponsor steve = new Sponsor("steve smith", 56, "male", "verydogfriendlyCompany");
            people.Add(steve);
            Student johnTheClone = (Student)john.Clone();
            people.Add(johnTheClone);
            

            foreach  (Person person in people)
            {
                person.Introduce();
                person.GetGoal();
            }
            PallidaClass alpaga = new PallidaClass("ALPAGA");
            alpaga.AddStudent(new Student("bela", 29, "male", "sol")); //counts students and mentors now
            alpaga.AddMentor(new Mentor("elon", 49, "female", "harvard"));

            alpaga.Info();

            Console.ReadLine();
        }
    }
}
