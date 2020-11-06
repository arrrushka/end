using System;
using System.Collections.Generic;
using System.Text;

namespace Week8Project.Core.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
