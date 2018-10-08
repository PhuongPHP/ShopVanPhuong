using ShopVanPhuong.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ShopVanPhuong.Model.Models
{
    [Table("Products")]

    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [Column(TypeName = "xml")]
        public string MoreImages { set; get; }

        public decimal Price { set; get; } // decimal là tính toán chính xác nó tính toán chính xác đến bao nhiêu lần số đằng sau cũng dc

        public decimal? PromotionPrice { set; get; } // có dấu ? là có thể null

        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public string Tags { set; get; }

        public int Quantity { set; get; }

        public decimal OriginalPrice { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
