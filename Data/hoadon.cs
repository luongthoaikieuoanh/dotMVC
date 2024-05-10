namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hoadon")]
    public partial class hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadon()
        {
            cthoadons = new HashSet<cthoadon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masohd { get; set; }

        public int makh { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaydat { get; set; }

        public int tongtien { get; set; }

        public int mavc { get; set; }

        public int matt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cthoadon> cthoadons { get; set; }

        public virtual khachhang khachhang { get; set; }

        public virtual tinhtrang tinhtrang { get; set; }

        public virtual voucher voucher { get; set; }
    }
}
