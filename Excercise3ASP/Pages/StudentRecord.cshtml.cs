using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Excercise3ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Excercise3ASP.Pages
{
    public class StudentRecordModel : PageModel
    {
        public StudentRecordModel(StudentFormDBContext studentFormDBContext) 
        {
            _studentFormDBContext = studentFormDBContext;
        }
        private readonly StudentFormDBContext _studentFormDBContext;


        [BindProperty]
        public StudentRegistrationForm StudentRegistrationForm { get; set; }
        public void OnGet()
        {
        }
        public void OnPost() 
        {
            _studentFormDBContext.StudentRegistrationForm.Add(StudentRegistrationForm);
            _studentFormDBContext.SaveChanges();
        }
    }
}
