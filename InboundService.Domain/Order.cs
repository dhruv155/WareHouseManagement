using InboundService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InboundService.Domain 
{
   public class Order:BaseDomainEntity
    {
        
        
        public string status { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public string description { get; set; }
    }
}
