using StaffsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public class CourseRepo : ICourseRepo<Course>
    {
        private readonly ICourse<Course> obj;
        public CourseRepo(ICourse<Course> _obj)
        {
            obj = _obj;
        }
        public void AddsCourse(Course c)
        {
            obj.AddsCourse(c);
        }

        public void EditCourse(int id, Course c)
        {
            obj.EditCourse(id, c);
        }

        public Task<List<Course>> GetCourses()
        {
            return obj.GetCourses();
        }

        public Task<List<Course>> GetCouseById(int id)
        {
            return obj.GetCouseById(id);
        }
    }
}
