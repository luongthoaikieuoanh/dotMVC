namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhanvien")]
    public partial class nhanvien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idnv { get; set; }

        [Required]
        [StringLength(250)]
        public string hoten { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string dia { get; set; }

        [Required]
        [StringLength(250)]
        public string username { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string matkhau { get; set; }

        [Column(TypeName = "text")]
        public string email { get; set; }

        [Column(TypeName = "text")]
        public string fb { get; set; }
    }
}
