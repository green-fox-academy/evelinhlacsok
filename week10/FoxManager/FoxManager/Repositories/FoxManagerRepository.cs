using System;
using FoxManager.Models;
using FoxManager.Entities;
using System.Threading.Tasks;


namespace FoxManager.Repositories
{
    public class FoxManagerRepository
    {
        FoxManagerContext FoxManagerContext;

        public FoxManagerRepository (FoxManagerContext foxManagerContext)
        {
            this.FoxManagerContext = foxManagerContext;
        }
    }

}
