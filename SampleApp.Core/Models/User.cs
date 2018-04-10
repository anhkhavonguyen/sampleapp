namespace SampleApp.Core.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

        public int? Role { get; set; }
    }
}
