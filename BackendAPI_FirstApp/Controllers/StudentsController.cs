using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using DataLayer.DataTables;
using ServiceLayer.IService;
using ViewModel.VM;


namespace BackendAPI_FirstApp.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();
        public readonly StidentInterface _studinterface;
        public StudentsController()
        {
            //StidentInterface studinterface
            //_studinterface =studinterface;
        }

        [HttpGet]
        [Route("getStudentList")]
        // GET: api/Students
        public List<Student> Getstud()
        {
            var studlist = _studinterface.Getstud();
            return studlist;
        }
        [HttpPost]
        [Route("login")]
        public bool Login([FromBody]LoginViewModel loginVM)
        {
            var data = _studinterface.LoginService(loginVM);
            return data;
        }
        [HttpGet]
        [Route("GetById")]
        // GET: api/Students/5
        //[ResponseType(typeof(Student))]
        public Student GetStudent(int id)
        {
            var data = _studinterface.GetStudent(id);
            return data;
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public bool PutStudent(int id, Student student)
        {

            var upadteStudent = _studinterface.PostStudent(student);
            return upadteStudent;
        }

        [HttpPost]
        [Route("postStudent")]
        public bool PostStudent(Student student)
        {

            var postStudent = _studinterface.PostStudent(student);
            return postStudent;
        }

        //// DELETE: api/Students/5
        //[ResponseType(typeof(Student))]

          [HttpGet]
          [Route("deleteStudent")]
        public int DeleteStudent(int id)
        {
            var deleteStudent = _studinterface.DeleteStudent(id);

            return deleteStudent;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool StudentExists(int id)
        //{
        //    return db.stud.Count(e => e.ID == id) > 0;
        //}
    }
}