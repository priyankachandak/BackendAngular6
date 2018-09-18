using DataLayer.DataTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.VM;

namespace ServiceLayer.IService
{
   public interface StidentInterface
    {
        List<Student> Getstud();

        Student GetStudent(int id);
        bool PutStudent(int id, Student student);
        bool PostStudent(Student student);

        int DeleteStudent(int id);
        bool LoginService(LoginViewModel loginVM);
    }
}
