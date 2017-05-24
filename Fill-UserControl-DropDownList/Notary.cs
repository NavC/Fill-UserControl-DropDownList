namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notary")]
    public partial class Notary
    {
        [StringLength(13)]
        public string notaryid { get; set; }

        [StringLength(90)]
        public string fullname { get; set; }

        public DateTime? exp_date { get; set; }

        [StringLength(40)]
        public string solemdenom { get; set; }

        [StringLength(40)]
        public string solemtitle { get; set; }

        [StringLength(200)]
        public string solemaddr { get; set; }

        [StringLength(40)]
        public string solemcity { get; set; }

        [StringLength(2)]
        public string solemstate { get; set; }

        [StringLength(10)]
        public string solemzip { get; set; }

        [StringLength(17)]
        public string phone { get; set; }

        public bool allownotpub { get; set; }

        [StringLength(50)]
        public string notuserid { get; set; }

        [StringLength(30)]
        public string notpass { get; set; }

        public bool pasexpired { get; set; }

        public bool isNotary { get; set; }

        public bool isSolemn { get; set; }

        public DateTime? passchangedate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }
    }
}
