using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAspCrud.Models;

namespace ReactAspCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDBContext _context;

        public StudentsController(StudentDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("GetStudents")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }


        [HttpPost]
        [Route("AddStudents")]
        public async Task<Student> AddStudents(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }


        [HttpPost]
        [Route("UpdateStudents")]
        public Student UpdateStudents(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
           
            return student;
        }



        [HttpDelete]
        [Route("DeleteStudents/{id}")]
        public bool DeleteStudents(int id)
        {
            bool a;
            Student student = _context.Students.FirstOrDefault(x => x.id == id);
            if (student != null)
            {
                a = true;
                _context.Students.Remove(student);
                _context.SaveChanges();

            }
            else
            {
                a = false;
            }

            return a;

         
        }


    }
}
