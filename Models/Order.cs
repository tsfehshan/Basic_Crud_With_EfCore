using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud_With_EFCore.Models
{
    public class Order : BaseEntity
    {
        public double Price { get; set; }
        public int Qty { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }

    }
}
