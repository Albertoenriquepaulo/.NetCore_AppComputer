using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCComponents.Models
{
    public class ComponentType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "This field can not be empty")]
        [MinLength(2)]
        public string Name { get; set; }

        //Navigation Properties
        public List<Component> Components { get; set; }
    }
}
