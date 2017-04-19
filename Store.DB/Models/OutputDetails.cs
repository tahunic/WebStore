﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class OutputDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public float Discount { get; set; }

        public virtual Output Output { get; set; }
        public int OutputId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}