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
        public Task <StudentModel> GetStudentById(int id); 
    }
}
