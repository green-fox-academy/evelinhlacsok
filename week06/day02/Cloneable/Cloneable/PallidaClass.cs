using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public class PallidaClass
    {
        private string className;
        public int students = 0;
        public int mentors = 0;
        //private string students;
        //private string mentors;

        public List<Student> StudentList = new List<Student>();
        public List<Mentor> MentorList = new List<Mentor>();
        //   private List<StudentList, Mentor> PallidaClassStudentMentor = new List<Student, Mentor>;

        public PallidaClass(string className)
        {
            this.className = className;
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student);
            //students++;
            //return StudentList;
        }

        public void AddMentor(Mentor mentor)
        {
            MentorList.Add(mentor);
            //mentors++;
            //return MentorList;
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + StudentList.Count + " students and " +
                              MentorList.Count + " mentors.");
        }

    }
}
