﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Repositary
{
    public interface IClassRepo<Class>
    {
        public void ScheduleClass(Class c);
        public Task<List<Class>> GetAllClasses();
        public Task<List<Class>> GetStaffClass(int id);
    }
}
