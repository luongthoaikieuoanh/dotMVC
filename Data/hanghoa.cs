namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanghoa")]
    public partial class hanghoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hanghoa()
        {
            binhluan1 = new HashSet<binhluan1>();
            cthanghoas = new HashSet<cthanghoa>();
            cthoadons = new HashSet<cthoadon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahh { get; set; }

        [Required]
        [StringLength(60)]
        public string tenhh { get; set; }

        public int maloai { get; set; }

        public bool dacbiet { get; set; }

        public int soluotxem { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaylap { get; set; }

        [Required]
        [StringLength(2000)]
        public string mota { get; set; }

        public int? an { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<binhluan1> binhluan1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cthanghoa> cthanghoas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cthoadon> cthoadons { get; set; }

        public virtual loai loai { get; set; }
    }
}
