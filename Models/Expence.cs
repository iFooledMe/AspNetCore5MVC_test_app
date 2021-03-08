using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5MVC_test_app.Models
{
    public class Expence
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expence Description")]
        [Required]
        public string Item { get; set; }

        [Required]
        [Range(100, int.MaxValue, ErrorMessage = "Must be over 100!")]
        public int Sum { get; set; }
    }
}
