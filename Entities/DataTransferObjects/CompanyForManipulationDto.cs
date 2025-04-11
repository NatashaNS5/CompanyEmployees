﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulationDto
    {

        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for rhe Address is 60 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Company country is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for rhe Country is 60 characters.")]
        public string Country { get; set; }
    }
}
