namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders
    {
        [Key]
        public int order_number { get; set; }

        public int cipher_of_book { get; set; }

        public int customer_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? receipt_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fulfillment_date { get; set; }

        public int? copies_number { get; set; }

        public virtual books books { get; set; }

        public virtual customers customers { get; set; }
    }
}
