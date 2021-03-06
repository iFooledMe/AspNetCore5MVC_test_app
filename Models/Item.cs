using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5MVC_test_app.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Item")]
        public string Name { get; set; }

        public string Borrower { get; set; }

        public string Lender { get; set; }

    }
}
