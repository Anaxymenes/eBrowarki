using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest
{
    public class BeerTypeMoq
    {
        static public List<BeerType> BeerTypeList { get {
                var beerTypeList = new List<BeerType>{
                new BeerType { Name = "Stout" , Id=1},
                new BeerType { Name = "Ale" , Id=2},
                new BeerType { Name = "Porter" , Id=3},
                new BeerType { Name = "Porter Bałtycki" , Id=4},
                new BeerType { Name = "Piwo pszeniczne" , Id=5},
                new BeerType { Name = "Pilzner" , Id=6},
                new BeerType { Name = "Lager" , Id=7},
                new BeerType { Name = "Ice Lager" , Id=8},
                new BeerType { Name = "Pale Lager" , Id=9}
            };
                return beerTypeList;
        } }
    }
}
