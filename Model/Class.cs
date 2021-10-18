using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace StaffsApi.Model
{
    public partial class Class:IClass<Class>
    {
        public int ClassId { get; set; }
        public int CourseId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Clink { get; set; }
        public DateTime ClassDate { get; set; }

        public virtual Course Course { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async void ScheduleClass(Class c)
        {
            db.Classes.Add(c);
            await db.SaveChangesAsync();
        }

        public async Task<List<Class>> GetAllClasses()
        {
            return db.Classes.ToList();
        }

        public async Task<List<Class>> GetStaffClass(int id)
        {
            var date = DateTime.Now;
            List<Class> cl = new List<Class>();
            cl = (from i in db.Courses
                  join j in db.Classes on i.CourseId equals j.CourseId
                  where i.UserId == id && j.ClassDate == date
                  select j).ToList();
            return cl;
        }
    }
}
