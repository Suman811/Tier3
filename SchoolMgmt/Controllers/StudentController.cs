using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMgmt.BAL.ServiceInterface;
using SchoolMgmt.DAL.Models;

namespace SchoolMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentServices;
        public StudentController(IStudentService studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        [Route("/getStudentById")]
        public async Task<StudentModel> GetStudentById(int id)
        {

            return await _studentServices.GetStudentById(id);
        }
        [HttpPost]
        [Route("InsertStudent")]
        public async Task<StudentModel> InsertStudent(StudentModel studentModel)
        {
            return await _studentServices.InsertStudent(studentModel);
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public async Task<StudentModel> UpdateStudent(StudentModel studentModel)
        {
            return await _studentServices.UpdateStudent(studentModel);
        }
        [HttpDelete]
        [Route("DeleteStudent")]
        public void DeleteStudent(int id)
        {
            _studentServices.DeleteStudent(id);
        }
    }

}
