namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Train
    {
        [StringLength(10)]
        public string TrainType { get; set; }

        [Required]
        [StringLength(10)]
        public string TrainNum { get; set; }

        public int id { get; set; }

        public int? Oil { get; set; }

        public DateTime? initDate { get; set; }
    }
}
