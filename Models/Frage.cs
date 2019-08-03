namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Frage")]
    public partial class Frage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Frageid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InterviewId { get; set; }

        [Required]
        [StringLength(50)]
        public string Bezeichnung { get; set; }

        [StringLength(128)]
        public string Bilddatei1 { get; set; }

        [StringLength(128)]
        public string Bildatei2 { get; set; }

        [StringLength(128)]
        public string Audiodatei { get; set; }

        [StringLength(10)]
        public string Anwortformat { get; set; }
    }
}
