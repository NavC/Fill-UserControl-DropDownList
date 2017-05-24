namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Place
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string placesid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string description { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp_column { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool isusstate { get; set; }
    }
}
