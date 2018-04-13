namespace EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Test : DbContext
    {
        public Test()
            : base("name=TestContext")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tb_Coefficient> tb_Coefficient { get; set; }
        public virtual DbSet<tb_driver> tb_driver { get; set; }
        public virtual DbSet<tb_driverReportDetails> tb_driverReportDetails { get; set; }
        public virtual DbSet<tb_driverReportInput> tb_driverReportInput { get; set; }
        public virtual DbSet<tb_mineStation> tb_mineStation { get; set; }
        public virtual DbSet<tb_stationMileage> tb_stationMileage { get; set; }
        public virtual DbSet<tb_Train> tb_Train { get; set; }
        public virtual DbSet<tb_user> tb_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_driverReportInput>()
                .HasMany(e => e.tb_driverReportDetails)
                .WithOptional(e => e.tb_driverReportInput)
                .HasForeignKey(e => e.reportid)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tb_user>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<tb_user>()
                .Property(e => e.pwd)
                .IsFixedLength();

            modelBuilder.Entity<tb_user>()
                .Property(e => e.gh)
                .IsFixedLength();
        }
    }
}
