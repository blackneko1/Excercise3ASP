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
        [RegularExpression(@"([1-9][0-9]*)", ErrorMessage = "Invalid must a number"), Required, StringLength(8)]
        public string Idnumber { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Name Invalid"), Required, StringLength(50)]
        public string Name { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Course Invalid"), Required, StringLength(50)]
        public string Course { get; set; }
        [RegularExpression(@"^(0?[1-5]|[1-5][0-5]|[1][1-5][1-5]|1)$", ErrorMessage = "invalid must a number 1-5"), Required]
        public string Year { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Color Invalid"), Required, StringLength(50)]
        public string TshirtColor { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Size Invalid Example Medium, Large, Small"), Required, StringLength(50)]
        public string Size { get; set; }
        [RegularExpression(@"^(0?[1-9]|[1-9][0-9]|[1][1-9][1-9]|250)$", ErrorMessage = "Invalid amount Range 1-250/must a number"), Required]
        public string AmountPaid { get; set; }
    }
}
