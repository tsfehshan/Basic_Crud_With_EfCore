using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud_With_EFCore.Models
{
    public class Variation : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
