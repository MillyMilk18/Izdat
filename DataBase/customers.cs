namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customers()
        {
            orders = new HashSet<orders>();
        }

        [Key]
        public int customer_id { get; set; }

        [Required]
        public string customer_name { get; set; }

        [Required]
        public string address { get; set; }

        [StringLength(16)]
        public string phone { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string customer_login { get; set; }

        [Required]
        public string customer_password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
    }
}
