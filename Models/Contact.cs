using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Models
{
    public class Contact
    {
        [Required (ErrorMessage = "پر کردن این فیلد اجباری است")]
        [MinLength(2)]
        public string name { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است")]
        [EmailAddress (ErrorMessage = "لطفا آدرس ایمیل وارد نمایید")]
        public string email { get; set; }
        public int service { get; set; }
        public string message { get; set; }
        public SelectList Services { get; set; }

    }
}
