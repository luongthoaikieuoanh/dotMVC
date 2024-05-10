namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cthoadon")]
    public partial class cthoadon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masohd { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahh { get; set; }

        public int soluongmua { get; set; }

        [Required]
        [StringLength(20)]
        public string mausac { get; set; }

        public int size { get; set; }

        public int thanhtien { get; set; }

        public int tinhtrang { get; set; }

        public virtual hanghoa hanghoa { get; set; }

        public virtual hoadon hoadon { get; set; }
    }
}
