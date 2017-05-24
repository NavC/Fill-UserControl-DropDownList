namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MrgPerfSchedule")]
    public partial class MrgPerfSchedule
    {
        [Key]
        public int schedule_id { get; set; }

        public DateTime mrgperfdt { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperfhoursfrom { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperfminutesfrom { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperftimefrmtfrom { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperfhoursto { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperfminutesto { get; set; }

        [Required]
        [StringLength(2)]
        public string mrgperftimefrmtto { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }
    }
}
