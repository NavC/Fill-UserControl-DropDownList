namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MrgPerfCerStatu
    {
        [Key]
        public byte ceremonystatus_id { get; set; }

        [Required]
        [StringLength(30)]
        public string ceremonystatus_desc { get; set; }
    }
}
