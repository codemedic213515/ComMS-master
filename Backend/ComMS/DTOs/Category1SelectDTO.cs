using System.ComponentModel.DataAnnotations;

namespace ComMS.DTOs
{
    public class Category1SelectDTO
    {
        [Key]
        public int? 分類1_Category1 { get; set; }

        public string 分類名_CategoryName { get; set; }
    }
}
