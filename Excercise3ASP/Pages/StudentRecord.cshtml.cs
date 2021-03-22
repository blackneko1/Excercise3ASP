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
            _studentformdbcontext = studentFormDBContext;
        }
        private readonly StudentFormDBContext _studentformdbcontext;


        [BindProperty]
        public StudentRegistrationForm StudentRegistrationForm { get; set; }

        public List<StudentRegistrationForm> studentRegistrationForms = new List<StudentRegistrationForm>();
        public void OnGet()
        {
            studentRegistrationForms = _studentformdbcontext.StudentRegistrationForm.ToList();
        }
        public ActionResult OnPost() 
        {
            if(!ModelState.IsValid) 
            {
                studentRegistrationForms = _studentformdbcontext.StudentRegistrationForm.ToList();
                return Page();

            }
            _studentformdbcontext.StudentRegistrationForm.Add(StudentRegistrationForm);
            _studentformdbcontext.SaveChanges();
            return Redirect("/Index");
        }
    }
}
