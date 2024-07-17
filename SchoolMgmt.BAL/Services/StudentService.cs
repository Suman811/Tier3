using SchoolMgmt.BAL.ServiceInterface;
using SchoolMgmt.DAL.Models;
using SchoolMgmt.DAL.RepositoyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgmt.BAL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {

            _studentRepository = studentRepository;
        }
        public async Task<StudentModel> GetStudentById(int id)
        {
            return await _studentRepository.GetStudentById(id);
        }
        public async Task<StudentModel> InsertStudent(StudentModel studentModel)
        {
            return await _studentRepository.InsertStudent(studentModel);
        }
        public async Task<StudentModel> UpdateStudent(StudentModel studentModel)
        {
            return await _studentRepository.UpdateStudent(studentModel);
        }
        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);


        }
    }
}
