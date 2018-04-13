namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_driverReportInput
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_driverReportInput()
        {
            tb_driverReportDetails = new HashSet<tb_driverReportDetails>();
        }

        [Column(TypeName = "date")]
        public DateTime? submitDate { get; set; }

        [StringLength(10)]
        public string driverGh { get; set; }

        [StringLength(10)]
        public string assistantDriverGh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? coefficientMonth { get; set; }

        [StringLength(1)]
        public string groupType { get; set; }

        [StringLength(15)]
        public string trainNum { get; set; }

        [StringLength(20)]
        public string train { get; set; }

        [StringLength(15)]
        public string traintype { get; set; }

        public int id { get; set; }

        [StringLength(5)]
        public string fromClass { get; set; }

        public double? fromOil { get; set; }

        public DateTime? fromDateTime { get; set; }

        [StringLength(5)]
        public string toClass { get; set; }

        public double? toOil { get; set; }

        public DateTime? toDateTime { get; set; }

        public double? dqAddOil { get; set; }

        public double? oil18 { get; set; }

        public int? driverRuntime { get; set; }

        public int? gtRuntime { get; set; }

        public int? dqRuntime { get; set; }

        public double? driverOil { get; set; }

        public double? gtOil { get; set; }

        public double? dqOil { get; set; }

        public DateTime? fromDateTimeReal { get; set; }

        public DateTime? toDateTimeReal { get; set; }

        public DateTime? previousDateTime { get; set; }

        public double? previousToOil { get; set; }

        public double? actualOil { get; set; }

        public double? comprehensiveOil { get; set; }

        [StringLength(5)]
        public string downtimepair { get; set; }

        public DateTime? insertTime { get; set; }

        [StringLength(5)]
        public string previousClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_driverReportDetails> tb_driverReportDetails { get; set; }
    }
}
