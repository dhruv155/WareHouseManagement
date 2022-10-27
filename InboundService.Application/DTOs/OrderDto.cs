using InboundService.Application.DTOs.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InboundService.Application.DTOs
{
   public  class OrderDto: BaseDto
    {
        public string status { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public string description { get; set; }
    }
}
