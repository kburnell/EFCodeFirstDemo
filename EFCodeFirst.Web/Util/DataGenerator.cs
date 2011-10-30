using System.Collections.Generic;
using System.Data.Spatial;
using EFCodeFirst.Enumerations;
using EFCodeFirst.Models;

namespace EFCodeFirst.Web.Util {

    public static class DataGenerator {

        private static Manufacturer _ferrari;
        private static Manufacturer _lamborghini;
        private static Manufacturer _astonMartin;
        private static Manufacturer _porsche;
        private static Engine _astonMartinV12;
        private static Engine _ferrariV8;
        private static Engine _ferrariV12;
        private static Engine _lamborghiniV10;
        private static Engine _lamborghiniV12;
        private static Engine _porscheStraight6;


        public static IList<Manufacturer> GetManufacturers() 
        {
            _ferrari = new Manufacturer { Name = "Ferrari", Country = "Italy", Models = new List<Model>() };
            _ferrari.Models.Add(new Model { Name = "458 Italia", BasePrice = 220000, Year = 2012, Manufacturer = _ferrari, AvailableEngines = new List<Engine> { _ferrariV8, _ferrariV12 }, EngineLocation = EngineLocationType.Mid });
            _ferrari.Models.Add(new Model { Name = "Scaglietti", BasePrice = 313000, Year = 2012, Manufacturer = _ferrari, AvailableEngines = new List<Engine> { _ferrariV12 }, EngineLocation = EngineLocationType.Front });
            _lamborghini = new Manufacturer { Name = "Lamborghini", Country = "Italy", Models = new List<Model>() };
            _lamborghini.Models.Add(new Model { Name = "Gallardo LP 570-4 Superleggera", BasePrice = 237600, Year = 2012, Manufacturer = _lamborghini, AvailableEngines = new List<Engine> { _lamborghiniV10 }, EngineLocation = EngineLocationType.Mid });
            _lamborghini.Models.Add(new Model { Name = "Aventador LP 700-4", BasePrice = 387000, Year = 2012, Manufacturer = _lamborghini, AvailableEngines = new List<Engine> { _lamborghiniV12 }, EngineLocation = EngineLocationType.Mid });
            _astonMartin = new Manufacturer { Name = "Aston Martin", Country = "United Kingdom", Models = new List<Model>() };
            _astonMartin.Models.Add(new Model { Name = "DB9", BasePrice = 185000, Year = 2012, Manufacturer = _astonMartin, AvailableEngines = new List<Engine> { _astonMartinV12 }, EngineLocation = EngineLocationType.Front });
            _astonMartin.Models.Add(new Model { Name = "V12 Vantage", BasePrice = 180000, Year = 2012, Manufacturer = _astonMartin, AvailableEngines = new List<Engine> { _astonMartinV12 }, EngineLocation = EngineLocationType.Mid });
            _porsche = new Manufacturer { Name = "Porsche", Country = "Germany", Models = new List<Model> { new Model { Name = "911 GT2 R2", BasePrice = 245000, Year = 2012, Manufacturer = _porsche, AvailableEngines = new List<Engine> { _porscheStraight6 }, EngineLocation = EngineLocationType.Rear } } };
            _ferrari.Location = DbGeography.Parse("POINT(44.53244	10.86412)");
            _lamborghini.Location = DbGeography.Parse("POINT (44.65934	11.12693)");
            _astonMartin.Location = DbGeography.Parse("POINT (52.18708	-1.48351)");
            _porsche.Location = DbGeography.Parse("POINT (48.83498	9.15231)");
            return new List<Manufacturer> { _ferrari, _lamborghini, _astonMartin, _porsche };
        }

    }
}