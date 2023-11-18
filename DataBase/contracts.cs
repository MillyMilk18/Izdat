namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class contracts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contracts()
        {
            writers = new HashSet<writers>();
        }

        [Key]
        public int contract_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public float? contract_term { get; set; }

        public bool terminated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_termination { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<writers> writers { get; set; }
    }
}
