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

        public Student GetStudentId(int id)
        {
            return FoxManagerContext.Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudentList()
        {
            return FoxManagerContext.Students.ToList();
        }


    }
}
