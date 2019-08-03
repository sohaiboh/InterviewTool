namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Interview")]
    public class Interview
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterviewID { get; set; }


        public string PlanerID { get; set; }

        public int Gruppe { get; set; }

        [Required]
        [StringLength(50)]
        public string Titel { get; set; }

        public DateTime Termin_Beginn { get; set; }

        public DateTime Termin_Ende { get; set; }

        public int? Min_Anzahl { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FachgebietID { get; set; }

        public virtual Fachgebiet Fachgebiet { get; set; }
    }
}
