namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fbntype")]
    public partial class fbntype
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filetype { get; set; }

        [StringLength(60)]
        public string descrip { get; set; }

        public int ownernumid { get; set; }

        public byte need_articles { get; set; }

        public int isdefaultvalue { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public int isactive { get; set; }
    }
}
