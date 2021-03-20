using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Excercise3ASP.Models
{
    public class StudentRegistrationForm
    {
        public int ID { get; set; }
        [RegularExpression(@"^(0?[1-9]|[1-9][0-9]|[1][1-9][1-9]|8)$", ErrorMessage = "Id number must length of 8/must be a number"), Required]
        public string Idnumber { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Name Invalid"), Required, StringLength(50)]
        public string Name { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Course Invalid"), Required, StringLength(50)]
        public string Course { get; set; }
        [RegularExpression(@"^(0?[1-9]|[1-9][0-9]|[1][1-9][1-9]|1)$", ErrorMessage = "Invalid Year"), Required]
        public string Year { get; set; }

        public string TshirtColor { get; set; }

        public string Size { get; set; }

        public string AmountPaid { get; set; }
    }
}
