using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace GreenFoxOrganization
{
    public class PallidaClass
    {
        private string className;
      //  private string students;
      //  private string mentors;
        private List<Student> StudentList = new List<Student>();
        private List<Mentor> MentorList = new List<Mentor>();

        public PallidaClass(string className)
        {
            this.className = className;
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

        public void Info()
        {
            Console.WriteLine("Pallida" + className + " class has" + StudentList.Count + " students and " + 
                              MentorList.Count + " mentors.");
        }

    }
}