using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    class PriceListItem
    {
        public Guid Id { get; set; }
        public Guid PriceListId { get; set; }
        public Guid ProductId { get; set; }
        public Decimal Price { get; set; }
    }
}
