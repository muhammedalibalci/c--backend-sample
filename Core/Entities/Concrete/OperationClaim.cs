﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    [Table("OperationClaims")]
    public class OperationClaim 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
