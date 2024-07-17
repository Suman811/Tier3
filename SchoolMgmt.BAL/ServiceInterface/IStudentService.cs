using SchoolMgmt.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgmt.BAL.ServiceInterface
{
    public interface IStudentService
    {
        public Task<StudentModel> GetStudentById(int id);
        public Task<StudentModel> InsertStudent(StudentModel student);
        public Task<StudentModel> UpdateStudent(StudentModel student);
        public void DeleteStudent(int id);

    }
}
