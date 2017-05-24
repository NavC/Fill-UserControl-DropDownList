namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jobtitle")]
    public partial class jobtitle
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string jobtitleid { get; set; }

        [Column("jobtitle")]
        [StringLength(21)]
        public string jobtitle1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }
    }
}
