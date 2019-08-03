namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Antwort-Text")]
    public partial class Antwort_Text
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TextId { get; set; }

        public int Frageid { get; set; }

        [Column("möglich-text-antwort1")]
        [StringLength(128)]
        public string möglich_text_antwort1 { get; set; }

        [Column("möglich-text-antwort2")]
        [StringLength(128)]
        public string möglich_text_antwort2 { get; set; }

        [Column("möglich-text-antwort3")]
        [StringLength(128)]
        public string möglich_text_antwort3 { get; set; }

        [Column("möglich-text-antwort4")]
        [StringLength(128)]
        public string möglich_text_antwort4 { get; set; }
    }
}
