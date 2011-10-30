using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EFCodeFirst.Enumerations;

namespace EFCodeFirst.Models {

    public class Model {

        public long ModelId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal BasePrice { get; set; }

        public EngineLocationType EngineLocation { get; set; }

        #region << Relationships >>

        public long ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual IList<Engine> AvailableEngines { get; set; }

        #endregion


    }
}