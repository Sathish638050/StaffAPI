using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace StaffsApi.Model
{
    public partial class Course:ICourse<Course>
    {
        public Course()
        {
            Classes = new HashSet<Class>();
            CourseEnrolls = new HashSet<CourseEnroll>();
            Customers = new HashSet<Customer>();
            Fees = new HashSet<Fee>();
            Topics = new HashSet<Topic>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }

        public virtual UserAccount User { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<CourseEnroll> CourseEnrolls { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public ELearnApplicationContext db = new ELearnApplicationContext();
        public async void AddsCourse(Course c)
        {
            db.Courses.Add(c);
            await db.SaveChangesAsync();
        }

        public async Task<List<Course>> GetCourses()
        {
            return (db.Courses.ToList());
        }

        public async Task<List<Course>> GetCouseById(int id)
        {
            List<Course> lc = new List<Course>();
            lc = (from i in db.Courses where i.UserId == id select i).ToList();
            return lc;
        }

        public async void EditCourse(int id, Course c)
        {
            Course co = db.Courses.Find(id);
            co.CourseName = c.CourseName;
            co.Description = c.Description;
            co.Amount = c.Amount;
            await db.SaveChangesAsync();
        }
    }
}
