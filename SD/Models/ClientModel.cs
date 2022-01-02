using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SD.Models
{
    public class ClientModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Display(Name ="Client Name ")]
        public string Name { get; set; }

        [Display]
        public string Country { get; set; }

        [Display(Name = " Email Address ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = " Phone Number  ")]
        [DataType(DataType.PhoneNumber)]
        public string Number { get; set; }
        [Display(Name = " Company Name  ")]
        public string CompanyName { get; set; }

        [Required]
        public string Product { get; set; }

        [StringLength(150)]
        public string Remarks { get; set; }

        public virtual List<ClientModel> ClientModels { get; set; } = new List<ClientModel>();

    }
}
