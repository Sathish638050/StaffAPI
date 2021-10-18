using StaffsApi.Model;
using StaffsApi.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Service
{
    public class CourseServ : ICourseServ<Course>
    {

        private readonly ICourseRepo<Course> repo;
        public CourseServ(ICourseRepo<Course> _repo)
        {
            repo = _repo;
        }
        public void AddsCourse(Course c)
        {
            repo.AddsCourse(c);
        }

        public void EditCourse(int id, Course c)
        {
            repo.EditCourse(id, c);
        }

        public Task<List<Course>> GetCourses()
        {
           return repo.GetCourses();
        }

        public Task<List<Course>> GetCouseById(int id)
        {
            return repo.GetCouseById(id);
        }
    }
}
