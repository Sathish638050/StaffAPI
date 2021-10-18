﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public interface ICourseRepo<Course>
    {
        public void AddsCourse(Course c);
        public Task<List<Course>> GetCourses();
        public Task<List<Course>> GetCouseById(int id);
        public void EditCourse(int id, Course c);
    }
}
