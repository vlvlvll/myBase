﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBase
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string ServiceName {  get; set; }
        public decimal Price { get; set; }
    }
}
