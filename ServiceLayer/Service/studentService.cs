using DataLayer.DataTables;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using ViewModel.VM;

namespace ServiceLayer.Service
{
    public class studentService : StidentInterface
    {
        private ApplicationContext db = new ApplicationContext();

        public studentService()
        {
        }

        public List<Student> Getstud()
        {
            return db.stud.ToList();
        }
        public Student GetStudent(int id)
        {
            Student student = db.stud.Find(id);
            return student;
        }
        public bool LoginService(LoginViewModel loginVM)
        {
           // bool is_exist = false;
            var student = db.stud.Where(x=>x.Email.ToString() == loginVM.email.ToString() && x.Password == loginVM.password).Count();
            if(student > 0)
            {
                return true;
            }
            return false;
        }
        public bool PutStudent(int id, Student student) {
            bool updated = false;
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            if (db.SaveChanges() > 0) {
                updated = true;
            };       
            return updated;
         }
       public bool PostStudent(Student student)
        {
            bool add = false;
            db.stud.Add(student);
            if (db.SaveChanges() > 0)
            {
                add = true;
            }

            return add;
        }

        public int DeleteStudent(int id)
        {
            Student student = db.stud.Find(id);
             db.stud.Remove(student);
            if(db.SaveChanges() > 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
