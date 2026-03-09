using FurnitureShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop.Domain.Entities.Concretes;

public class Collection:BaseEntity
{
    public string NameAz { get; set; }
    public string NameEn { get; set; }
    public string NameRu { get; set; }
    public string DescriptionAz { get; set; }
    public string DescriptionEn { get; set; }
    public string DescriptionRu { get; set; }
    public string ImagesUrl { get; set; }   // dəstin ümumi otaq şəkli
    public int CategoryId { get; set; }
    public CollectionCategory CollectionCategory { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal? DiscountPrice { get; set; }
    public int DisplayOrder { get; set; }
    public ICollection<Product> Products { get; set; }
}