namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(10)]
        public string account_id { get; set; }

        [StringLength(10)]
        public string employee_id { get; set; }

        [StringLength(10)]
        public string teacher_id { get; set; }

        [StringLength(10)]
        public string student_id { get; set; }

        public bool? is_active { get; set; }

        [Required]
        [StringLength(100)]
        public string login { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [StringLength(20)]
        public string role { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
