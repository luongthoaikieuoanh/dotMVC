namespace dotMVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("background")]
    public partial class background
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int matn { get; set; }

        [Required]
        [StringLength(500)]
        public string url { get; set; }
    }
}
