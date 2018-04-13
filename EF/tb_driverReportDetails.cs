namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_driverReportDetails
    {
        [StringLength(10)]
        public string trainTrips { get; set; }

        public int? mileageStationId { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? endTime { get; set; }

        public double? emptyWeight { get; set; }

        public double? heavyWeight { get; set; }

        public double? heavyLoad { get; set; }

        public double? pullMinute { get; set; }

        public double? standaloneMinute { get; set; }

        public double? shuntingdz { get; set; }

        public double? shuntingdx { get; set; }

        public double? shuntingdc { get; set; }

        public double? downtime { get; set; }

        [StringLength(30)]
        public string remark { get; set; }

        public int id { get; set; }

        public double? firePauseMinutes { get; set; }

        public double? WTonKM { get; set; }

        public double? standaloneOil { get; set; }

        public double? pullOil { get; set; }

        public double? dzOil { get; set; }

        public double? dxOil { get; set; }

        public double? dcOil { get; set; }

        public double? firePauseOil { get; set; }

        public double? airconditionerOil { get; set; }

        public double? comprehensiveOil { get; set; }

        public int? reportid { get; set; }

        public DateTime? startdowntime1 { get; set; }

        public DateTime? startdowntime2 { get; set; }

        public DateTime? startdowntime3 { get; set; }

        public DateTime? enddowntime1 { get; set; }

        public DateTime? enddowntime2 { get; set; }

        public DateTime? enddowntime3 { get; set; }

        public DateTime? startTimeReal { get; set; }

        public DateTime? endTimeReal { get; set; }

        public byte? dcCount { get; set; }

        public byte? dxCount { get; set; }

        public byte? dzCount { get; set; }

        [StringLength(5)]
        public string downtimepair { get; set; }

        public double? actualOil { get; set; }

        public virtual tb_driverReportInput tb_driverReportInput { get; set; }
    }
}
