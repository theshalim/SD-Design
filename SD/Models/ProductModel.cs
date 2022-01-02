using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SD.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = " Product Code")]
        public string ProductCode { get; set; }
        [Required]
        [Display(Name =" Product Name")]
        public string ProductName { get; set; }
       
        [Required]
        [Display(Name = "Unit")]
        public string Unit { get; set; }
        [Required]
        [Display(Name = "Countity")]
        public string Count { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = " Manufacture Date")]
        public string ManufactureDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = " Expried Date")]
        public string ExpriedDate { get; set; }


        public virtual List<ProductModel> ProductModels { get; set; } = new List<ProductModel>();
    }
}
