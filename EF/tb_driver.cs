namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_driver
    {
        [StringLength(15)]
        public string gh { get; set; }

        [StringLength(10)]
        public string drivername { get; set; }

        [StringLength(5)]
        public string post { get; set; }

        public int id { get; set; }

        [StringLength(5)]
        public string department { get; set; }
    }
}
