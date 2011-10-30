using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models {

    public class Engine {

        public long EngineId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int NumberOfCylinders { get; set; }

        [Required]
        public decimal Liters { get; set; }

        [Required]
        public long BreakHorsepower { get; set; }

        #region << Relationships >>

        public virtual IList<Model> AvailableOn { get; set; }

        #endregion

    }
}