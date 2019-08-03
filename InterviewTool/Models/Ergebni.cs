namespace InterviewTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ergebni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ergebni()
        {
            Teilnehmers = new HashSet<Teilnehmer>();
        }

        [Key]
        public int ErgebnisId { get; set; }

        [StringLength(50)]
        public string ErgFrage1 { get; set; }

        [StringLength(50)]
        public string ErgFrage2 { get; set; }

        [StringLength(50)]
        public string ErgFrage3 { get; set; }

        [StringLength(50)]
        public string ErgFrage4 { get; set; }

        [StringLength(50)]
        public string ErgFrage5 { get; set; }

        [StringLength(50)]
        public string ErgFrage6 { get; set; }

        [StringLength(50)]
        public string ErgFrage7 { get; set; }

        [StringLength(50)]
        public string ErgFrage8 { get; set; }

        [StringLength(50)]
        public string ErgFrage9 { get; set; }

        [StringLength(50)]
        public string ErgFrage10 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teilnehmer> Teilnehmers { get; set; }
    }
}
