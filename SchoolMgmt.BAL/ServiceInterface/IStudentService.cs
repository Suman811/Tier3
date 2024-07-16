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

    }
}
