using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Model
{
   public interface IClass<Class>
    {
        public void ScheduleClass(Class c);
        public Task<List<Class>> GetAllClasses();
        public Task<List<Class>> GetStaffClass(int id);
    }
}
