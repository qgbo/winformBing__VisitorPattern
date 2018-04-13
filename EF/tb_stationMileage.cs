namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_stationMileage
    {
        public int? startStationId { get; set; }

        public int? endStationId { get; set; }

        public double? benwuMileage { get; set; }

        public double? standaloneMileage { get; set; }

        public bool? xingbie { get; set; }

        public int id { get; set; }

        public double? score { get; set; }
    }
}
