namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pubPassport
    {
        [Key]
        public int pass_id { get; set; }

        public byte regexpedite { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(35)]
        public string firstname { get; set; }

        [StringLength(35)]
        public string middlename { get; set; }

        [StringLength(20)]
        public string suffixname { get; set; }

        public byte birth_date_month { get; set; }

        public byte birth_date_day { get; set; }

        public short birth_date_year { get; set; }

        public byte? sex { get; set; }

        [StringLength(40)]
        public string birth_city { get; set; }

        [StringLength(100)]
        public string birth_country { get; set; }

        [StringLength(9)]
        public string ssn { get; set; }

        public byte? height_feets { get; set; }

        public byte? height_inches { get; set; }

        public byte? haircolor_id { get; set; }

        public byte? eyecolor_id { get; set; }

        [StringLength(100)]
        public string occupation { get; set; }

        [StringLength(80)]
        public string employername { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(60)]
        public string maddress1 { get; set; }

        [StringLength(60)]
        public string maddress2 { get; set; }

        [StringLength(40)]
        public string mcity { get; set; }

        [StringLength(2)]
        public string mstate { get; set; }

        [StringLength(10)]
        public string mzip { get; set; }

        public bool misUS { get; set; }

        [StringLength(100)]
        public string mcountry { get; set; }

        [StringLength(100)]
        public string mincareof { get; set; }

        public bool issameaddr { get; set; }

        [StringLength(60)]
        public string address1 { get; set; }

        [StringLength(60)]
        public string address2 { get; set; }

        [StringLength(40)]
        public string city { get; set; }

        public bool isUS { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        [StringLength(17)]
        public string homephone { get; set; }

        [StringLength(17)]
        public string workphone { get; set; }

        [StringLength(17)]
        public string cellphone { get; set; }

        public byte recpassport { get; set; }

        [StringLength(100)]
        public string recfullname { get; set; }

        public byte recstatus { get; set; }

        [StringLength(50)]
        public string recstatusother { get; set; }

        [StringLength(30)]
        public string recnumber { get; set; }

        public byte reccard { get; set; }

        [StringLength(100)]
        public string reccardfullname { get; set; }

        public byte reccardstatus { get; set; }

        [StringLength(50)]
        public string reccardstatusother { get; set; }

        [StringLength(30)]
        public string reccardnumber { get; set; }

        [StringLength(50)]
        public string triplength { get; set; }

        [StringLength(100)]
        public string tripcounties { get; set; }

        public byte smrgstatus { get; set; }

        [StringLength(100)]
        public string sfullname { get; set; }

        public byte sUScitizen { get; set; }

        [StringLength(100)]
        public string sbirth_country { get; set; }

        public byte smrgend_status { get; set; }

        [StringLength(50)]
        public string ofullname1 { get; set; }

        [StringLength(50)]
        public string ofullname2 { get; set; }

        [StringLength(50)]
        public string ofullname3 { get; set; }

        [StringLength(50)]
        public string ofullname4 { get; set; }

        [StringLength(35)]
        public string ffirstname { get; set; }

        [StringLength(35)]
        public string fmiddlename { get; set; }

        [StringLength(50)]
        public string flastname { get; set; }

        public byte fbirth_date_month { get; set; }

        public byte fbirth_date_day { get; set; }

        public short fbirth_date_year { get; set; }

        [StringLength(100)]
        public string fbirth_country { get; set; }

        public byte fUScitizen { get; set; }

        [StringLength(35)]
        public string mfirstname { get; set; }

        [StringLength(35)]
        public string mmiddlename { get; set; }

        [StringLength(50)]
        public string mlastname { get; set; }

        public byte mbirth_date_month { get; set; }

        public byte mbirth_date_day { get; set; }

        public short mbirth_date_year { get; set; }

        [StringLength(100)]
        public string mbirth_country { get; set; }

        public byte mUScitizen { get; set; }

        [StringLength(100)]
        public string efullname { get; set; }

        [StringLength(60)]
        public string eaddress1 { get; set; }

        [StringLength(60)]
        public string eaddress2 { get; set; }

        [StringLength(40)]
        public string ecity { get; set; }

        [StringLength(2)]
        public string estate { get; set; }

        [StringLength(10)]
        public string ezip { get; set; }

        [StringLength(17)]
        public string ephone { get; set; }

        [StringLength(50)]
        public string eemail { get; set; }

        [StringLength(50)]
        public string erelationship { get; set; }

        public int? old_pass_att { get; set; }

        public int? birth_cert_att { get; set; }

        public int? ntrlz_cert_att { get; set; }

        [Column(TypeName = "text")]
        public string other_doc_att { get; set; }

        public int? parent_id_type { get; set; }

        [StringLength(20)]
        public string parent_id_num { get; set; }

        public bool isbook { get; set; }

        public bool iscard { get; set; }

        public bool birth_isUS { get; set; }

        [StringLength(2)]
        public string birth_state { get; set; }

        public bool sbirth_isUS { get; set; }

        [StringLength(2)]
        public string sbirth_state { get; set; }

        public bool fbirth_isUS { get; set; }

        [StringLength(2)]
        public string fbirth_state { get; set; }

        public bool mbirth_isUS { get; set; }

        [StringLength(2)]
        public string mbirth_state { get; set; }

        public bool eisUS { get; set; }

        [StringLength(100)]
        public string ecountry { get; set; }

        public byte recissuedate_month { get; set; }

        public byte recissuedate_day { get; set; }

        public short recissuedate_year { get; set; }

        public byte reccardissuedate_month { get; set; }

        public byte reccardissuedate_day { get; set; }

        public short reccardissuedate_year { get; set; }

        public byte depdate_month { get; set; }

        public byte depdate_day { get; set; }

        public short depdate_year { get; set; }

        public byte smrgdate_month { get; set; }

        public byte smrgdate_day { get; set; }

        public short smrgdate_year { get; set; }

        public byte smrgenddate_month { get; set; }

        public byte smrgenddate_day { get; set; }

        public short smrgenddate_year { get; set; }

        public byte acceptapp { get; set; }

        public DateTime? fill_dttm { get; set; }

        public bool internet { get; set; }

        public bool to_import { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        public byte pagebook { get; set; }

        public byte fsex { get; set; }

        public byte msex { get; set; }

        public byte sbirthdate_month { get; set; }

        public byte sbirthdate_day { get; set; }

        public short sbirthdate_year { get; set; }

        public byte retdate_month { get; set; }

        public byte retdate_day { get; set; }

        public short retdate_year { get; set; }
    }
}
