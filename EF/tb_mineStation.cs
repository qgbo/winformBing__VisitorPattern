namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_mineStation
    {
        [StringLength(10)]
        public string mineStationName { get; set; }

        [StringLength(10)]
        public string zjm { get; set; }

        public int id { get; set; }
    }
}
