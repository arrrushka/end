using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Week8Project.Core.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsBad { get; set; }
    }
}
