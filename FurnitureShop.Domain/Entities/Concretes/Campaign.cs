using FurnitureShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop.Domain.Entities.Concretes;
    public class Campaign:BaseEntity
    {
        public string TitleAz { get; set; }
        public string TitleEn { get; set; }
        public string TitleRu { get; set; }
        public string DescriptionAz { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionRu { get; set; }
        public string ImageUrl { get; set; }
        public string ButtonTextAz { get; set; }
        public string ButtonTextEn { get; set; }
        public string ButtonTextRu { get; set; }
        public string ButtonLink { get; set; }
        public decimal? DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }
    }
