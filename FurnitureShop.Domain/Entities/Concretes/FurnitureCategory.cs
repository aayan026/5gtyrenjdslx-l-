using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop.Domain.Entities.Concretes;

public class FurnitureCategory:Category
{
    public ICollection<Product> Products { get; set; }

}
