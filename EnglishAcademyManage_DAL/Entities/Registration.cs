namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    public partial class Registration
    {
        [Key]
        [StringLength(10)]
        public string registration_id { get; set; }

        public DateTime? registration_date { get; set; }

        [Required]
        [StringLength(10)]
        public string student_id { get; set; }

        [Required]
        [StringLength(10)]
        public string course_id { get; set; }

        [StringLength(30)]
        public string status { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
