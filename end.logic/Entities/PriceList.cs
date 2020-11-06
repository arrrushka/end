using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    class PriceList
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<PriceListItem> priceListItems { get; set; }
    }
}
