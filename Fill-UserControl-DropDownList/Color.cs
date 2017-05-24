namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Color
    {
        [Key]
        [Column(Order = 0)]
        public byte color_id { get; set; }

        [StringLength(30)]
        public string color_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool type { get; set; }
    }
}
