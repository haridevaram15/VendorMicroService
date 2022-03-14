﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor1.Model
{
    public class VendorStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
       
        public int HandInStocks { get; set; }
        public DateTime ReplinshmentDate { get; set; }
        [ForeignKey("Vendor")]

        public int VendorId { get; set; }
        
        public Vendor Vendor { get; set; }
    }
}
