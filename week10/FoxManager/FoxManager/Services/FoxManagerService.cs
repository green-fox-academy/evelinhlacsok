using System;
using FoxManager.Repositories;

namespace FoxManager.Services
{
    public class FoxManagerService
    {
        private FoxManagerRepository FoxManagerRepository;

        public FoxManagerService(FoxManagerRepository userRepository)
        {
            FoxManagerRepository = userRepository;
        }

        public bool AuthenticateStudent(string name)
        {
            return FoxManagerRepository.CheckStudentExist(name);
        }

        public Student GetStudentInfo(string name)
        {
            return FoxManagerRepository.GetStudentInfo(name);
        }

        public List<Project> GetStudentProjects(string name)
        {
            return FoxManagerRepository.GetStudentProjectList(name);
        }
    }
}
