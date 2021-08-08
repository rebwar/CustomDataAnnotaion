using System.ComponentModel.DataAnnotations;
using CustomDataAnnotaion.CustomValidation;

namespace CustomDataAnnotaion.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        [ExcludeChar("@#$%&*",ErrorMessage ="نمیتوانید از  کارکترهای @#$%&* در نام کاربری استفاده کنید")]
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}