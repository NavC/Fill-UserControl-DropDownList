namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MrgPerfTimeStatu
    {
        [Key]
        public byte timestatus_id { get; set; }

        [Required]
        [StringLength(30)]
        public string timestatus_desc { get; set; }
    }
}
