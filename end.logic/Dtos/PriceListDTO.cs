using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace end.logic.Dtos
{
    class PriceListDTO
    {
        public class PricelistAdd
        {
            public List<PriceListItem> priceListItems { get; set; }
        }
}
