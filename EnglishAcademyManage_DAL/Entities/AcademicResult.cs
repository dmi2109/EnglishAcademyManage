namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AcademicResult
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int attempt { get; set; }

        public decimal? average_score { get; set; }

        [StringLength(50)]
        public string final_result { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string student_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string course_id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
