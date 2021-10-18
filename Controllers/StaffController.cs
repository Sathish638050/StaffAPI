using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffsApi.Model;
using StaffsApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffsApi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(StaffController));
        private readonly ICourseServ<Course> CS;
        private readonly ITopicServ<Topic> TS;
        private readonly IClassServ<Class> CLS;
        public StaffController(ICourseServ<Course> _CS, ITopicServ<Topic> _TS, IClassServ<Class> _CLS)
        {
            CS = _CS;
            TS = _TS;
            CLS = _CLS;
        }
        public ELearnApplicationContext db = new ELearnApplicationContext();
       

        [HttpPost]
        [Route("AddCourses")]
        public async Task<IActionResult> AddsCourse(Course c)
        {
            _log4net.Info(c.CourseName+"  course is added!");
            CS.AddsCourse(c);
            return Ok();
        }
        [HttpPost]
        [Route("AddTopic")]
        public async Task<IActionResult> AddModule(Topic m)
        {
            _log4net.Info(m.TopicName + "  Module is added!");
            TS.AddModule(m);
            return Ok();
        }
        [HttpPost]
        [Route("ScheduleClass")]
        public async Task<IActionResult>ScheduleClass(Class c)
        {
            _log4net.Info(c.CourseId + "-This Class is Scheduled");
            CLS.ScheduleClass(c);

            return Ok();

        }
        [HttpGet]
        [Route("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            _log4net.Info( " Get Course method has been called ");
            return Ok(CS.GetCourses());
     
        }
        [HttpGet]
        [Route("Topics")]
        public async Task<IActionResult> Topics(int cid)
        {
            _log4net.Info(cid+"-These are the topic's Id you requested");
            List<Topic> modDetail = new List<Topic>();

            modDetail = await TS.Topics(cid);

            return Ok(modDetail);
        }
        [HttpGet]
        [Route("GetAllClasses")]
        public async Task<IActionResult>GetAllClasses()
        {
            _log4net.Info( " Get All Classes method has been executed");
            return Ok(CLS.GetAllClasses());
               
        }
        [HttpGet("GetCourseByUser")]
        public async Task<IActionResult> GetCouseById(int id)
        {
            _log4net.Info(id + " -Course you requested ");
            List<Course> lc = new List<Course>();
            lc = await CS.GetCouseById(id);
            return Ok(lc);
        }
        [HttpPut("EditCourse")]
        public async Task<IActionResult> EditCourse(int id,Course c)
        {
            _log4net.Info(id + " Your course was edited Successfully!");

            CS.EditCourse(id, c);
            return Ok();
        }
        [HttpGet("getClassStaff")]
        public async Task<IActionResult> GetStaffClass(int id)
        {
            _log4net.Info(id + "-These are the classes you have now");

            List<Class> cl = new List<Class>();
            cl = await CLS.GetStaffClass(id);
            return Ok(cl);
        }
        

    }
}
