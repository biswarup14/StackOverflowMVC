using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowMVC.ViewModels
{
    public class EditUserDetailsViewModel
    {
        public int UserID { get; set; }
        [Required]
        [RegularExpression(@"(^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$)")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }
    }
}
