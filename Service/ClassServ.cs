using StaffsApi.Model;
using StaffsApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Service
{
    public class ClassServ : IClassServ<Class>
    {

        private readonly IClassRepo<Class> repo;
        public ClassServ(IClassRepo<Class> _repo)
        {
            repo = _repo;
        }

        public Task<List<Class>> GetAllClasses()
        {
            return repo.GetAllClasses();
        }

        public Task<List<Class>> GetStaffClass(int id)
        {
            return repo.GetStaffClass(id);
        }

        public void ScheduleClass(Class c)
        {
            repo.ScheduleClass(c);
        }
    }
}
