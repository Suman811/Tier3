using SchoolMgmt.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolMgmt.DAL.RepositoyInterface
{
    public interface IStudentRepository
    {
        public Task<StudentModel> GetStudentById(int id);
        public Task<StudentModel> InsertStudent(StudentModel studentModel);
        public Task<StudentModel> UpdateStudent(StudentModel studentModel);
        public void DeleteStudent(int id);
    }
}
