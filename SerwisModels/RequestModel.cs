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
        [Key]
        public int RequestID { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Numer telefonu musi zawierać dokładnie 9 cyfr")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Opis zgłoszenia jest wymagany")]
        [MaxLength(500, ErrorMessage = "Opis może zawierać maksymalnie 500 znaków")]
        public string RequestContent { get; set; }
    }

}