using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    public class PallidaClass
    {
        private string className;
        List<Student>StudentList = new List<Student>();
        List<Mentor>MentorList = new List<Mentor>();

        public PallidaClass(string className)
        {
            this.className = className;
            this.StudentList = new List<Student>();
            this.MentorList = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student); 
        }

        public void AddMentor(Mentor mentor)
        {
            MentorList.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, StudentList.Count, 
                                MentorList.Count);
        }
    }
}