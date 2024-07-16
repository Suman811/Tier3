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
        private readonly  IStudentService _studentServices;
        public StudentController(IStudentService studentServices) {
                 _studentServices = studentServices;
        }

        [HttpGet]
        [Route("/getById")]
        public async Task<StudentModel> Get(int id) { 
            return await _studentServices.GetStudentById(id);  
        }
    }
}
