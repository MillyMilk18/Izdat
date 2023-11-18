namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class writers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public writers()
        {
            books = new HashSet<books>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int passport_number { get; set; }

        public int contract_number { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string surname { get; set; }

        public string third_name { get; set; }

        [Required]
        public string address { get; set; }

        [StringLength(16)]
        public string phone { get; set; }

        public virtual contracts contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<books> books { get; set; }
    }
}
