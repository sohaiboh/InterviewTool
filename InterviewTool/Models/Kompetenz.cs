namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kompetenz")]
    public partial class Kompetenz
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string LevelValue { get; set; }

        public int? FachgebietId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual Fachgebiet Fachgebiet { get; set; }
    }
}
