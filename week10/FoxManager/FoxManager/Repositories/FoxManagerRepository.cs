using System;
using FoxManager.Models;
using FoxManager.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace FoxManager.Repositories
{
    public class FoxManagerRepository
    {
        FoxManagerContext FoxManagerContext;

        public FoxManagerRepository (FoxManagerContext foxManagerContext)
        {
            this.FoxManagerContext = foxManagerContext;
        }

        //public Student GetStudentId(int id)
        //{
        //    return FoxManagerContext.Students.FirstOrDefault(x => x.Id == id);
        //}

        //public List<Student> GetStudentList()
        //{
        //    return FoxManagerContext.Students.ToList();
        //}

        public bool CheckStudentExist(string name)
        {
            var user = FoxManagerContext.Students.FirstOrDefault(x => x.Name.Equals(name));
            return user != null ? true : false;
        }

        public Student GetStudentInfo(string name)
        {
            return FoxManagerContext.Students.FirstOrDefault(y => y.Name.Equals(name));
        }

        public List<Task> GetStudentProjectList(string name)
        {
            return FoxManagerContext.Tasks.Where(p => p.Student.StudentName.Equals(name))
                .ToList();
        }


    }
}
