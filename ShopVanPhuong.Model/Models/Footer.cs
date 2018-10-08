using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ShopVanPhuong.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)] // MaxLength là em viết cái MVC Razor rồi sinh ra cái form. Còn StringLenghth là để generate ra DB
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}
