namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Coefficient
    {
        public DateTime datet { get; set; }

        public double? pullCoefficient { get; set; }

        public double? densityCoefficient { get; set; }

        public double? shouldCoefficient1 { get; set; }

        public double? shouldCoefficient2out { get; set; }

        public double? shouldCoefficient3 { get; set; }

        public int id { get; set; }
    }
}
