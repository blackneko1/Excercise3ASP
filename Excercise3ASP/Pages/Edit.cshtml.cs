using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Excercise3ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Excercise3ASP.Pages
{
    public class EditModel : PageModel
    {
        public EditModel(StudentFormDBContext studentFormDBContext)
        {
            _studentFormDBContext = studentFormDBContext;
        }

        private readonly StudentFormDBContext _studentFormDBContext;

        [BindProperty]
        public StudentRegistrationForm StudentRegistrationForm { get; set; }

        public void OnGet(int id)
        {
            StudentRegistrationForm = _studentFormDBContext.StudentRegistrationForm.
                FirstOrDefault(student => student.ID == id);
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            StudentRegistrationForm stud = new StudentRegistrationForm();
            stud = _studentFormDBContext.StudentRegistrationForm.
                FirstOrDefault(student => student.ID == StudentRegistrationForm.ID);

            if (stud != null)
            {

                stud.Idnumber = StudentRegistrationForm.Idnumber;
                stud.Name = StudentRegistrationForm.Name;
                stud.Course = StudentRegistrationForm.Course;
                stud.Year = StudentRegistrationForm.Year;
                stud.TshirtColor = StudentRegistrationForm.TshirtColor;
                stud.Size = StudentRegistrationForm.Size;
                stud.AmountPaid = StudentRegistrationForm.AmountPaid;

                _studentFormDBContext.Update(stud);

                _studentFormDBContext.SaveChanges();
            }

           

            return Redirect("StudentRecord");
        }

    }   

}
