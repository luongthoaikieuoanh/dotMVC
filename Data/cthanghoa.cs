namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cthanghoa")]
    public partial class cthanghoa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idhanghoa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idmau { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idsize { get; set; }

        public double dongia { get; set; }

        public int soluongton { get; set; }

        [Required]
        [StringLength(100)]
        public string hinh { get; set; }

        public double giamgia { get; set; }

        public virtual hanghoa hanghoa { get; set; }

        public virtual mausac mausac { get; set; }

        public virtual sizegiay sizegiay { get; set; }
    }
}
