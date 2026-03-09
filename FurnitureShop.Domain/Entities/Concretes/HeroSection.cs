using FurnitureShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop.Domain.Entities.Concretes;

public class HeroSection:BaseEntity
{
    public string TitleAz { get; set; }
    public string TitleEn { get; set; }
    public string TitleRu { get; set; }
    public string SubtitleAz { get; set; }
    public string SubtitleEn { get; set; }
    public string SubtitleRu { get; set; }
    public string BadgeTextAz { get; set; }
    public string BadgeTextEn { get; set; }
    public string BadgeTextRu { get; set; }
    public string ImageUrl { get; set; }
    public bool IsActive { get; set; }
}
