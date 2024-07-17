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
        public StudentRepository(databasecontext databasecontext)
        {
            _databasecontext = databasecontext;
        }

        public async Task<StudentModel> GetStudentById(int id)
        {
            return await _databasecontext.StudentModel.FirstOrDefaultAsync(u => u.StudentId == id);
        }
        public async Task<StudentModel> InsertStudent(StudentModel studentModel)
        {
            await _databasecontext.StudentModel.AddAsync(studentModel);
            await _databasecontext.SaveChangesAsync();
            return studentModel;
        }
        public async Task<StudentModel> UpdateStudent(StudentModel studentModel)
        {
            _databasecontext.Entry(studentModel).State = EntityState.Modified;
            _databasecontext.SaveChangesAsync();
            return studentModel;
        }

        public void DeleteStudent(int id)

        {
            var entity = _databasecontext.StudentModel.Find(id);
            if (entity != null)
            {
                _databasecontext.StudentModel.Remove(entity);
                _databasecontext.SaveChangesAsync();
                //_databasecontext.StudentModel.RemoveAsync(id);
                //_databasecontext.Entry(Stu.State= EntityState.Deleted;
                //_databasecontext.SaveChangesAsync();

            }
        }

    }
}
