using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Spatial;

namespace EFCodeFirst.Models {

    public class Manufacturer {

        public long ManufacturerId { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Country { get; set; }

        [Required]
        public DbGeography Location { get; set; }

        #region << Relationships >>

        public virtual IList<Model> Models { get; set; }

        #endregion

    }
}