using FurnitureShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop.Domain.Entities.Concretes;
public class Product:BaseEntity
{
    public string NameAz { get; set; }
    public string NameEn { get; set; }
    public string NameRu { get; set; }
    public string DescriptionAz { get; set; }
    public string DescriptionEn { get; set; }
    public string DescriptionRu { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public FurnitureCategory Category { get; set; }
    public string Material { get; set; }
    public string  Colors { get; set; }       
    public bool IsFeatured { get; set; }
    public int DisplayOrder { get; set; }
    public string ImagesUrl { get; set; }
    public string Label { get; set; }
    public decimal? PriceExtra { get; set; }
    public int Rating { get; set; }

}