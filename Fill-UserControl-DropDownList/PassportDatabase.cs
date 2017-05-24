namespace Fill_UserControl_DropDownList
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PassportDatabase : DbContext
    {
        public PassportDatabase()
            : base("name=PassportDatabase")
        {
        }

        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<fbninfo> fbninfoes { get; set; }
        public virtual DbSet<fbnname> fbnnames { get; set; }
        public virtual DbSet<fbnregi> fbnregis { get; set; }
        public virtual DbSet<fbntype> fbntypes { get; set; }
        public virtual DbSet<mrg> mrgs { get; set; }
        public virtual DbSet<MrgPerfAppointment> MrgPerfAppointments { get; set; }
        public virtual DbSet<MrgPerfCerStatu> MrgPerfCerStatus { get; set; }
        public virtual DbSet<MrgPerfSchedule> MrgPerfSchedules { get; set; }
        public virtual DbSet<MrgPerfTimeStatu> MrgPerfTimeStatus { get; set; }
        public virtual DbSet<Notary> Notaries { get; set; }
        public virtual DbSet<notarypub> notarypubs { get; set; }
        public virtual DbSet<publda> publdas { get; set; }
        public virtual DbSet<publdaperson> publdapersons { get; set; }
        public virtual DbSet<pubmrg> pubmrgs { get; set; }
        public virtual DbSet<pubPassport> pubPassports { get; set; }
        public virtual DbSet<pubppc> pubppcs { get; set; }
        public virtual DbSet<pubppcperson> pubppcpersons { get; set; }
        public virtual DbSet<pubp> pubps { get; set; }
        public virtual DbSet<pubpsperson> pubpspersons { get; set; }
        public virtual DbSet<pubuda> pubudas { get; set; }
        public virtual DbSet<pubudaperson> pubudapersons { get; set; }
        public virtual DbSet<bondcompany> bondcompanies { get; set; }
        public virtual DbSet<cmstate> cmstates { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<conducttype> conducttypes { get; set; }
        public virtual DbSet<county> counties { get; set; }
        public virtual DbSet<industry> industries { get; set; }
        public virtual DbSet<jobtitle> jobtitles { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<ParentIDType> ParentIDTypes { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<skdefault> skdefaults { get; set; }
        public virtual DbSet<suffix> suffixes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.address1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.address2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.maddress1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.maddress2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.phone1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.othertype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.agentname)
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.agentaddress)
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.agentidtypeother)
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.agentidnumber)
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.agentphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbninfo>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.fbname)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<fbnname>()
                .Property(e => e.agentname)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.agentaddress)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.agentidtypeother)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.agentidnumber)
                .IsUnicode(false);

            modelBuilder.Entity<fbnname>()
                .Property(e => e.agentphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.registrnam)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.city)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.phone1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.phone2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.stateofinc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.llcaih)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.idnumber)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.agentname)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.agentaddress)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.agentidtypeother)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.agentidnumber)
                .IsUnicode(false);

            modelBuilder.Entity<fbnregi>()
                .Property(e => e.agentphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbntype>()
                .Property(e => e.descrip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fbntype>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<mrg>()
                .Property(e => e.countid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.notary)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.notaryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hfirst)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hlast)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hclast)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hstate)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hoccup)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hindustry)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hfathname)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hbirthst)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmothmdnnm)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmothbirth)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hdrivlcn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hdrvexpm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hdrvexpy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wfirst)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wlast)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wclast)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmaiden)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wstate)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.woccup)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.windustry)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wfathname)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wbirthst)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmothmdnnm)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmothbirth)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wdrivlcn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wdrvexpm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wdrvexpy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.haddress)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hstateres)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmdayphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.waddress)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wstateres)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmdayphone2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmaddress)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hmstateres)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmaddress)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wmstateres)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witname1)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witaddr1)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witstzip1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witname2)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witaddr2)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.witstzip2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.solemdenom)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.solemtitle)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.solemname)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.solemaddr)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.solemzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.mrgperfcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.mrgperfcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<mrg>()
                .Property(e => e.hnewmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.hnewlast)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wnewmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<mrg>()
                .Property(e => e.wnewlast)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.hfirst)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.hlast)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.wfirst)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.wlast)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.hphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.wphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.countid)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfAppointment>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<MrgPerfCerStatu>()
                .Property(e => e.ceremonystatus_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperfhoursfrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperfminutesfrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperftimefrmtfrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperfhoursto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperfminutesto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.mrgperftimefrmtto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MrgPerfSchedule>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<MrgPerfTimeStatu>()
                .Property(e => e.timestatus_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.notaryid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemdenom)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemtitle)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemaddr)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemcity)
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.solemzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.notuserid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.notpass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Notary>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<notarypub>()
                .Property(e => e.lastname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.firstname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.middlename)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.commission_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.bond_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.bonding_company)
                .IsUnicode(false);

            modelBuilder.Entity<notarypub>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<publda>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.state_inc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.maddress1)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.maddress2)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.mcity)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.mstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.mzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.corpaddress1)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.corpaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.corpcity)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.corpstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.corpzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.primarycounty)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.bond_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.bonding_company)
                .IsUnicode(false);

            modelBuilder.Entity<publda>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<publda>()
                .HasMany(e => e.publdapersons)
                .WithOptional(e => e.publda)
                .WillCascadeOnDelete();

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.jobtitle)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.executed_place)
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.personident)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.personident_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publdaperson>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hfirst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hlast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hclast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hstate)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hoccup)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hindustry)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hfathname)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hbirthst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmothmdnnm)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmothbirth)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hdrivlcn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hdrvexpm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hdrvexpy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wfirst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wlast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wclast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmaiden)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wstate)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.woccup)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.windustry)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wfathname)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wbirthst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmothmdnnm)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmothbirth)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wdrivlcn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wdrvexpm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wdrvexpy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.haddress)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hstateres)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmdayphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.waddress)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wstateres)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmdayphone2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmaddress)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hmstateres)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmaddress)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wmstateres)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witname1)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witaddr1)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witstzip1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witname2)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witaddr2)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.witstzip2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperflng)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperfcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperfcounty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.lastfirst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wlastfirst)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hnewmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.hnewlast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wnewmiddle)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.wnewlast)
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperfhours)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperfminutes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubmrg>()
                .Property(e => e.mrgperftimefrmt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.suffixname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.birth_city)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.birth_country)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ssn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.occupation)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.employername)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.maddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.maddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mcountry)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mincareof)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.cellphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.recfullname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.recstatusother)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.recnumber)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.reccardfullname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.reccardstatusother)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.reccardnumber)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.triplength)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.tripcounties)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.sfullname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.sbirth_country)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ofullname1)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ofullname2)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ofullname3)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ofullname4)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ffirstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.fmiddlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.flastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.fbirth_country)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mfirstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mmiddlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mlastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mbirth_country)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.efullname)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.eaddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.eaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ecity)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.estate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ezip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.eemail)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.erelationship)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.other_doc_att)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.parent_id_num)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.birth_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.sbirth_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.fbirth_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.mbirth_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.ecountry)
                .IsUnicode(false);

            modelBuilder.Entity<pubPassport>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubppc>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.state_inc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.maddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.maddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.mcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.mstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.mzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.corpaddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.corpaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.corpcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.corpstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.corpzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.primarycounty)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.bond_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.bonding_company)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.not_lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.not_firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.not_middlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.not_commission_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.ps_filenumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppc>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubppc>()
                .HasMany(e => e.pubppcpersons)
                .WithOptional(e => e.pubppc)
                .WillCascadeOnDelete();

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.jobtitle)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.executed_place)
                .IsUnicode(false);

            modelBuilder.Entity<pubppcperson>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubp>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.state_inc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.maddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.maddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.mcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.mstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.mzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.corpaddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.corpaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.corpcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.corpstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.corpzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.primarycounty)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.bond_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.bonding_company)
                .IsUnicode(false);

            modelBuilder.Entity<pubp>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubp>()
                .HasMany(e => e.pubpspersons)
                .WithOptional(e => e.pubp)
                .WillCascadeOnDelete();

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.jobtitle)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.executed_place)
                .IsUnicode(false);

            modelBuilder.Entity<pubpsperson>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubuda>()
                .Property(e => e.business_name)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.state_inc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.maddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.maddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.mcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.mstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.mzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.corpaddress1)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.corpaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.corpcity)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.corpstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.corpzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.primarycounty)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.bond_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.bonding_company)
                .IsUnicode(false);

            modelBuilder.Entity<pubuda>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<pubuda>()
                .HasMany(e => e.pubudapersons)
                .WithOptional(e => e.pubuda)
                .WillCascadeOnDelete();

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.middlename)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.homephone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.workphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.jobtitle)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.executed_place)
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.personident)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.personident_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pubudaperson>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<bondcompany>()
                .Property(e => e.comp_name)
                .IsUnicode(false);

            modelBuilder.Entity<bondcompany>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<cmstate>()
                .Property(e => e.cmstatesid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cmstate>()
                .Property(e => e.code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cmstate>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<cmstate>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<Color>()
                .Property(e => e.color_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<conducttype>()
                .Property(e => e.condtype_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<conducttype>()
                .Property(e => e.persontypes)
                .IsUnicode(false);

            modelBuilder.Entity<conducttype>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<county>()
                .Property(e => e.county_name)
                .IsUnicode(false);

            modelBuilder.Entity<county>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<industry>()
                .Property(e => e.industryid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<industry>()
                .Property(e => e.industry1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<industry>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<jobtitle>()
                .Property(e => e.jobtitleid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<jobtitle>()
                .Property(e => e.jobtitle1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<jobtitle>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<language>()
                .Property(e => e.lang_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<language>()
                .Property(e => e.language_name)
                .IsUnicode(false);

            modelBuilder.Entity<language>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<ParentIDType>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<ParentIDType>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<PersonType>()
                .Property(e => e.persontype_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PersonType>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<Place>()
                .Property(e => e.placesid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<skdefault>()
                .Property(e => e.officename)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.clerkrecorder)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.citystzip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.county)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mailaddr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mailaddr2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.fromhour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.tohour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.fgclerknm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.fgclerkttl)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.not_rtl_path)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.altadd1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.altadd2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.noathrev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.imgreppath)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.usersignpath)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.npsettingspath)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.helppath)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.nightproc_help)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.defphonepref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.defcity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.defstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.defsolemtitle)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.timestamp_column)
                .IsFixedLength();

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmisctitle1)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmisctitle2)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmiscaddress)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmisccity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmiscstate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmisczip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgmiscphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.recorderaddr1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.recorderaddr2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.clerkaddr1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.clerkaddr2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgduplicate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.expletnote)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.expletbatchpath)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.passfacilitynumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.fbnletterphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.courtaddline1)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.courtaddline2)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.courtaddline3)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.courtname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.notpubdivphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<skdefault>()
                .Property(e => e.mrgphone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<suffix>()
                .Property(e => e.suffix_name)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
