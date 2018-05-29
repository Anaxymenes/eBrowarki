using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest
{
    public class ProductMoq
    {
        static public List<Product> ProductList { get {
                var productList = new List<Product>() {
                    new Product {
                        AccountId = AccountMoq.AccountList[1].Id,
                        Date = DateTime.Now,
                        CountryId = CountryMoq.CountryList[1].Id,
                        IsBeer=false,
                        Picture="carlsbergSpZoo.png",
                        Name="Carlsberg Polska Sp. z o.o.",
                        Description = "Carlsberg Polska Sp. z o.o. – polskie przedsiębiorstwo z branży piwowarskiej należące do duńskiego koncernu Carlsberg Group. Do Carlsberg Polska należy 15,3% udziałów w rynku piwa w Polsce.",

                    },
                    new Product {
                        AccountId = AccountMoq.AccountList[2].Id,
                        Date = DateTime.Now,
                        CountryId = CountryMoq.CountryList[2].Id,
                        IsBeer=true,
                        Picture="harnasJasnePelne.png",
                        Name="Harnaś Jasne pełne",
                        Description = "Szlachetne męskie piwo pełne siły, humoru i pogody ducha. Orzeźwia i cieszy swoim wyjątkowym smakiem i aromatem. Idealne po pracy. ",
                    },
                    new Product {
                        AccountId = AccountMoq.AccountList[3].Id,
                        Date = DateTime.Now,
                        CountryId = CountryMoq.CountryList[3].Id,
                        IsBeer=true,
                        Picture="harnasOkocimski.png",
                        Name="Harnaś Okocimski",
                        Description = "Piwo jasne pełne, którego sprawdzona receptura jest sekretem jakości. To piwo stanowi doskonałe połączenie składników oraz gwarantuje jego głęboki i pełny smak. To oczywiście slogan producenta. Jest standardową propozycją, która nie odbiega znacząco od średniej. Producent piwa akcentuje, że kupując Harnasia wspierasz tatrzańskie drapieżniki.",

                }
                };
                
                    return ProductList;
            } }
    }
}
