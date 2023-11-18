namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            orders = new HashSet<orders>();
            writers = new HashSet<writers>();
        }

        [Key]
        public int cipher { get; set; }

        [Required]
        public string title { get; set; }

        public float? circulation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_publication { get; set; }

        public float? cost_price { get; set; }

        public float? sale_price { get; set; }

        public float? fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<writers> writers { get; set; }
    }
}
