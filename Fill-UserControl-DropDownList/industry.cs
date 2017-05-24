namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("industry")]
    public partial class industry
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string industryid { get; set; }

        [Column("industry")]
        [StringLength(34)]
        public string industry1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }
    }
}
