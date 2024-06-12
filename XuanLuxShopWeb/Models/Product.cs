using System.ComponentModel.DataAnnotations;

namespace XuanLuxShopWeb.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "商品名稱")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "商品圖片")]
        public string ThumbnaiImage { get; set; }
    }
}