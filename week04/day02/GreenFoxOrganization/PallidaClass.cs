using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace GreenFoxOrganization
{
    public class PallidaClass
    {
        private string className;
        private List<Student> StudentList = new List<Student>();
        private List<Mentor> MentorList = new List<Mentor>();

        public PallidaClass()
        {
         
        }

        public List<Student> AddStudent(Student student)
        {
            StudentList.Add(student);
            return StudentList;
        }

        public List<Mentor> AddMentor(Mentor mentor)
        {
            MentorList.Add(mentor);
            return MentorList;
        }

        public string Info()
        {
            Console.WriteLine("Pallida" + className + "class has" + StudentList.Count + "students and " + 
                              MentorList.Count + "mentors.");
            return Info();
        }

    }
}