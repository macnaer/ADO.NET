using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Data_Annotation.Data.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Field Id is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be beatween 3 and 50 characters")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field Surname is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must be beatween 3 and 50 characters")]
        [Column(TypeName = "varchar(50)")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Field Phone is required.")]
        //[Phone]
        [RegularExpression(@"^\+[1-9]\d{3}-\d{3}-\d{4}", ErrorMessage = "Phone number must have format +xxx-xxx-xxxx")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field Age is required.")]
        [Range(1,120, ErrorMessage = "Age must be between 0 and 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Field Password is required.")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Password must be beatween 3 and 50 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Field ConfirmPassword is required.")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "ConfirmPassword must be beatween 3 and 50 characters")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
