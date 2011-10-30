using System.Collections.Generic;
using EFCodeFirst.Models;
using EFCodeFirst.Web.Models;

namespace EFCodeFirst.Web.ViewModels {

    public class EFCodeFirstViewModel {
        public IList<Manufacturer> Manufacturers { get; set; }
        public IList<SpatialModel> Spatials { get; set; } 
    }
}