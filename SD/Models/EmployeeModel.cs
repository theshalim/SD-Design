using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }

        [Display(Name ="Present Posting")]
        public string PresentPosting { get; set; }
        [Required]
        [Display(Name = " Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }


        public virtual List<EmployeeModel> EmployeeModels { get; set; } = new List<EmployeeModel>();

       
        public string PhotoUrl { get; set; }
        [Required(ErrorMessage = "Required*")]
        [Display(Name = "Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
    }
}
