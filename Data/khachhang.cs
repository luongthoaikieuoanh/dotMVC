namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachhang")]
    public partial class khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khachhang()
        {
            binhluan1 = new HashSet<binhluan1>();
            hoadons = new HashSet<hoadon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int makh { get; set; }

        [Required]
        [StringLength(50)]
        public string tenkh { get; set; }

        [Required]
        [StringLength(25)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string matkhau { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(12)]
        public string sodienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<binhluan1> binhluan1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadon> hoadons { get; set; }
    }
}
