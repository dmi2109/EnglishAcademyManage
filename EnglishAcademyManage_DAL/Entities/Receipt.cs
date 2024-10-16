namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        [StringLength(10)]
        public string receipt_id { get; set; }

        public DateTime? payment_date { get; set; }

        public decimal? amount { get; set; }

        [StringLength(50)]
        public string payment_method { get; set; }

        [Required]
        [StringLength(10)]
        public string student_id { get; set; }

        [Required]
        [StringLength(10)]
        public string employee_id { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
