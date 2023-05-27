namespace informationSystem.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        [StringLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public string ProductCategory { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProductPhoto { get; set; }

        [Required]
        public string ProductManufacturer { get; set; }

        public decimal ProductCost { get; set; }

        public byte? ProductDiscountAmount { get; set; }

        public int ProductQuantityInStock { get; set; }

        [Required]
        public string ProductStatus { get; set; }

        [Required]
        public string ProductProvider { get; set; }

        public int? ProductMaxDiscountAmount { get; set; }

        [Required]
        public string ProductUnitQuantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
