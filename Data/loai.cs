namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loai")]
    public partial class loai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loai()
        {
            hanghoas = new HashSet<hanghoa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maloai { get; set; }

        [Required]
        [StringLength(60)]
        public string tenloai { get; set; }

        [Required]
        [StringLength(50)]
        public string link { get; set; }

        [Column("loai")]
        [Required]
        [StringLength(50)]
        public string loai1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hanghoa> hanghoas { get; set; }
    }
}
