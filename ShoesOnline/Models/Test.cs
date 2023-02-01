using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoesOnline.Models
{
    public class Test
    {
        [Required(ErrorMessage = "Please Input ID")]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please Input Product Name")]
        public string Name { get; set; }
    }
}
