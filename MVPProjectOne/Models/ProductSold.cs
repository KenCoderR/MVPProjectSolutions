namespace MVPProjectOne.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("MVP.ProductSolds")]
    public partial class ProductSold
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product")]
        public string ProductId { get; set; }

        [Required]
        [Display(Name = "Consumer")]
        public string ConsumerId { get; set; }

        [Required]
        [Display(Name ="Store")]
        public string StoreId { get; set; }

        [Required]
        [Display(Name ="Date sold")]
        public string DataSold { get; set; }

        public int Customer_Id { get; set; }

        public int Store_Id { get; set; }

        public int Product_Id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }
    }
}
