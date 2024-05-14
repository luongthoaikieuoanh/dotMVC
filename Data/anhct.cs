namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("anhct")]
    public partial class anhct
    {
        public int mahh { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahinh { get; set; }

        [Required]
        [StringLength(250)]
        public string anh { get; set; }
    }
}
