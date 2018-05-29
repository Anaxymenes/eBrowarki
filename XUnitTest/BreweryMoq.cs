using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest
{
    public class BreweryMoq
    {
        static public List<Brewery> BreweryList { get {
                var breweryList = new List<Brewery>(){
                    new Brewery {
                        ProductId = 1,
                        NumberOfBuilding = "34",
                        PostalCode = "02-255",
                        Place="Warszawa",
                        Street="Krakowiaków",
                        PostOffice="Warszawa",
                    },
                };
                return breweryList;
            } }
    }
}
