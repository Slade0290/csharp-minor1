﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Venezia.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName  { get; set; }
    }
}
