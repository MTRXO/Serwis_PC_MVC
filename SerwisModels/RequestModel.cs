using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisModels
{
    public class RequestModel
    {
        [Required]
        public int RequestID { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Wprowadz porawny numer telefonu")]
        public string PhoneNumber { get; set; }  
        [Required]
        [MaxLength(500)]
        public string RequestContent { get; set; }
    }
}
