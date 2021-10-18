using StaffsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public class ClassRepo : IClassRepo<Class>
    {
        private readonly IClass<Class> obj;
        public ClassRepo(IClass<Class> _obj)
        {
            obj = _obj;
        }

        public Task<List<Class>> GetAllClasses()
        {
            return obj.GetAllClasses();
        }

        public Task<List<Class>> GetStaffClass(int id)
        {
            return obj.GetStaffClass(id);
        }

        public void ScheduleClass(Class c)
        {
            obj.ScheduleClass(c);
        }
    }
}
