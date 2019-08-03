namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skalar")]
    public partial class Skalar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkalarId { get; set; }

        public int Idfrage { get; set; }

        public int? Anfangswert { get; set; }

        public int? Endwert { get; set; }

        public int? Schrittweite { get; set; }
    }
}
