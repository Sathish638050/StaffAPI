using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Service
{
    public interface ICourseServ<Course>
    {
        public void AddsCourse(Course c);
        public Task<List<Course>> GetCourses();
        public Task<List<Course>> GetCouseById(int id);
        public void EditCourse(int id, Course c);
    }
}
