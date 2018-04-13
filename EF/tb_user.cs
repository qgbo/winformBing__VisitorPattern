namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class tb_user
    {
        [Required]
        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string pwd { get; set; }

        [StringLength(10)]
        public string gh { get; set; }

        [Key]
        public int userid { get; set; }

        [StringLength(5)]
        public string role { get; set; }


    }

    public partial class tb_user
    {
        public bool Exist()
        {
            using (Test context=new Test())
            {
               return context.tb_user.Where(u=>u.gh==this.gh) !=null;
            }
        }

    }
}
