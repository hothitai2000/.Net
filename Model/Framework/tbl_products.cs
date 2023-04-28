namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_products
 {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         public int ID { get; set; }

        [StringLength(50)]
         [DisplayName("Tên sản phẩm")]
         [Required]
         //[Required(ErrorMessage ="Bạn chưa nhập tên")]
         public string Name { get; set; }
        [DisplayName("Giá")]
         public decimal? Price { get; set; }
         [DisplayName("Chi tiết SP")]
         public string Detail { get; set; }

         [StringLength(50)]
         [DisplayName("HÌnh ảnh SP")]
         public string Images { get; set; }
 }
}
