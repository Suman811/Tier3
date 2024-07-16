using Microsoft.EntityFrameworkCore;
using SchoolMgmt.DAL.DBContext;
using SchoolMgmt.DAL.Models;
using SchoolMgmt.DAL.RepositoyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgmt.DAL.Repositories
{
    public class StudentRepository : IStudentRepository
        
    { 
        private readonly databasecontext _databasecontext;
        public StudentRepository(databasecontext databasecontext) { 
            _databasecontext = databasecontext;
        }

        public async Task<StudentModel> GetStudentById(int id)
        {
          return await  _databasecontext.StudentModel.FirstOrDefaultAsync(u=>u.StudentId== id);
        }

    }
}
