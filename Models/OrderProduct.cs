using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud_With_EFCore.Models
{
    public class OrderProduct : BaseEntity
    {
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
