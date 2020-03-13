﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCComponents.Models
{
    public class Component
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "This field can not be empty")]
        [MinLength(2)]
        [Display(Name = "Component Descripcion")]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public double Price { get; set; }

        //Navigation Properties
        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
        public List<Computer> Computers { get; set; }
    }
}