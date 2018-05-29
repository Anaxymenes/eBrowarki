using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DatabaseSeeder
    {
        public static void SeedDB(DatabaseContext context) {
            if (!context.Role.Any()) {
                var accountRoleList = new List<Role>() {
                    new Role { Name = "Admin"},
                    new Role { Name = "Moderator" },
                    new Role { Name = "User" }
                };

                context.AddRange(accountRoleList);
                context.SaveChanges();
            };

            if (!context.Account.Any()) {
                var accountList = new List<Account>() { 
                    new Account { Username="admin", RoleId = context.Role.First(x=>x.Name.Equals("Admin")).Id,  // Hasło : @dmIn
                                  Email="admin@admin.admin", Active = true, Avatar = "admin.png",
                                  Password = "huJvnFB7W+s+R1VKD5+mVk3Kxl4VLQ9FoKbdwWVj3dM=",
                                  PasswordSalt= "Oa4hhLqKNfKrM5lmBlNp5o2RBMAcb/oZY2JrSliHGPg=" },
                    new Account { Username="moderator", RoleId = context.Role.First(x=>x.Name.Equals("Moderator")).Id,  // Hasło : @dmIn
                                  Email="moderator@admin.admin", Active = true, Avatar = "moderator.png",
                                  Password = "huJvnFB7W+s+R1VKD5+mVk3Kxl4VLQ9FoKbdwWVj3dM=",
                                  PasswordSalt= "Oa4hhLqKNfKrM5lmBlNp5o2RBMAcb/oZY2JrSliHGPg=" },
                    new Account { Username="user", RoleId = context.Role.First(x=>x.Name.Equals("User")).Id, // Hasło : T3st3r
                                  Email="user@admin.admin", Active = true, Avatar = "user.png",
                                  Password = "T3meNC23KoJwxxJFOsOx2fwj3vnh73dYk9tG9k3UIWg=",
                                  PasswordSalt= "/VAB3o32Ct62xq8cxaLC9gHj+FfvZmGmTlneXAVJOq0=" }, 
                };

                context.AddRange(accountList);
                context.SaveChanges();
            };

            if (!context.BeerType.Any()) {
                var beerTypeList = new List<BeerType>() {
                        new BeerType{ Name = "Stout"},
                        new BeerType{ Name = "Ale"},
                        new BeerType{ Name = "Porter"},
                        new BeerType{ Name = "Porter Bałtycki"},
                        new BeerType{ Name = "Piwo pszeniczne"},
                        new BeerType{ Name = "Pilzner"},
                        new BeerType{ Name = "Lager"},
                        new BeerType{ Name = "Ice Lager"},
                        new BeerType{ Name = "Pale Lager"},
                    };
                context.AddRange(beerTypeList);
                context.SaveChanges();
            };

            if (!context.Country.Any()) {
                var countryList = new List<Country>() {
                    new Country{ Shortcut="AF" , Name = "Afghanistan" },
                    new Country{ Shortcut="AL" , Name = "Albania" },
                    new Country{ Shortcut="DZ" , Name = "Algeria" },
                    new Country{ Shortcut="DS" , Name = "American Samoa" },
                    new Country{ Shortcut="AD" , Name = "Andorra" },
                    new Country{ Shortcut="AO" , Name = "Angola" },
                    new Country{ Shortcut="AI" , Name = "Anguilla" },
                    new Country{ Shortcut="AQ" , Name = "Antarctica" },
                    new Country{ Shortcut="AG" , Name = "Antigua and Barbuda" },
                    new Country{ Shortcut="AR" , Name = "Argentina" },
                    new Country{ Shortcut="AM" , Name = "Armenia" },
                    new Country{ Shortcut="AW" , Name = "Aruba" },
                    new Country{ Shortcut="AU" , Name = "Australia" },
                    new Country{ Shortcut="AT" , Name = "Austria" },
                    new Country{ Shortcut="AZ" , Name = "Azerbaijan" },
                    new Country{ Shortcut="BS" , Name = "Bahamas" },
                    new Country{ Shortcut="BH" , Name = "Bahrain" },
                    new Country{ Shortcut="BD" , Name = "Bangladesh" },
                    new Country{ Shortcut="BB" , Name = "Barbados" },
                    new Country{ Shortcut="BY" , Name = "Belarus" },
                    new Country{ Shortcut="BE" , Name = "Belgium" },
                    new Country{ Shortcut="BZ" , Name = "Belize" },
                    new Country{ Shortcut="BJ" , Name = "Benin" },
                    new Country{ Shortcut="BM" , Name = "Bermuda" },
                    new Country{ Shortcut="BT" , Name = "Bhutan" },
                    new Country{ Shortcut="BO" , Name = "Bolivia" },
                    new Country{ Shortcut="BA" , Name = "Bosnia and Herzegovina" },
                    new Country{ Shortcut="BW" , Name = "Botswana" },
                    new Country{ Shortcut="BV" , Name = "Bouvet Island" },
                    new Country{ Shortcut="BR" , Name = "Brazil" },
                    new Country{ Shortcut="IO" , Name = "British Indian Ocean Territory" },
                    new Country{ Shortcut="BN" , Name = "Brunei Darussalam" },
                    new Country{ Shortcut="BG" , Name = "Bulgaria" },
                    new Country{ Shortcut="BF" , Name = "Burkina Faso" },
                    new Country{ Shortcut="BI" , Name = "Burundi" },
                    new Country{ Shortcut="KH" , Name = "Cambodia" },
                    new Country{ Shortcut="CM" , Name = "Cameroon" },
                    new Country{ Shortcut="CA" , Name = "Canada" },
                    new Country{ Shortcut="CV" , Name = "Cape Verde" },
                    new Country{ Shortcut="KY" , Name = "Cayman Islands" },
                    new Country{ Shortcut="CF" , Name = "Central African Republic" },
                    new Country{ Shortcut="TD" , Name = "Chad" },
                    new Country{ Shortcut="CL" , Name = "Chile" },
                    new Country{ Shortcut="CN" , Name = "China" },
                    new Country{ Shortcut="CX" , Name = "Christmas Island" },
                    new Country{ Shortcut="CC" , Name = "Cocos (Keeling) Islands" },
                    new Country{ Shortcut="CO" , Name = "Colombia" },
                    new Country{ Shortcut="KM" , Name = "Comoros" },
                    new Country{ Shortcut="CG" , Name = "Congo" },
                    new Country{ Shortcut="CK" , Name = "Cook Islands" },
                    new Country{ Shortcut="CR" , Name = "Costa Rica" },
                    new Country{ Shortcut="HR" , Name = "Croatia (Hrvatska)" },
                    new Country{ Shortcut="CU" , Name = "Cuba" },
                    new Country{ Shortcut="CY" , Name = "Cyprus" },
                    new Country{ Shortcut="CZ" , Name = "Czech Republic" },
                    new Country{ Shortcut="DK" , Name = "Denmark" },
                    new Country{ Shortcut="DJ" , Name = "Djibouti" },
                    new Country{ Shortcut="DM" , Name = "Dominica" },
                    new Country{ Shortcut="DO" , Name = "Dominican Republic" },
                    new Country{ Shortcut="TP" , Name = "East Timor" },
                    new Country{ Shortcut="EC" , Name = "Ecuador" },
                    new Country{ Shortcut="EG" , Name = "Egypt" },
                    new Country{ Shortcut="SV" , Name = "El Salvador" },
                    new Country{ Shortcut="GQ" , Name = "Equatorial Guinea" },
                    new Country{ Shortcut="ER" , Name = "Eritrea" },
                    new Country{ Shortcut="EE" , Name = "Estonia" },
                    new Country{ Shortcut="ET" , Name = "Ethiopia" },
                    new Country{ Shortcut="FK" , Name = "Falkland Islands (Malvinas)" },
                    new Country{ Shortcut="FO" , Name = "Faroe Islands" },
                    new Country{ Shortcut="FJ" , Name = "Fiji" },
                    new Country{ Shortcut="FI" , Name = "Finland" },
                    new Country{ Shortcut="FR" , Name = "France" },
                    new Country{ Shortcut="FX" , Name = "France, Metropolitan" },
                    new Country{ Shortcut="GF" , Name = "French Guiana" },
                    new Country{ Shortcut="PF" , Name = "French Polynesia" },
                    new Country{ Shortcut="TF" , Name = "French Southern Territories" },
                    new Country{ Shortcut="GA" , Name = "Gabon" },
                    new Country{ Shortcut="GM" , Name = "Gambia" },
                    new Country{ Shortcut="GE" , Name = "Georgia" },
                    new Country{ Shortcut="DE" , Name = "Germany" },
                    new Country{ Shortcut="GH" , Name = "Ghana" },
                    new Country{ Shortcut="GI" , Name = "Gibraltar" },
                    new Country{ Shortcut="GK" , Name = "Guernsey" },
                    new Country{ Shortcut="GR" , Name = "Greece" },
                    new Country{ Shortcut="GL" , Name = "Greenland" },
                    new Country{ Shortcut="GD" , Name = "Grenada" },
                    new Country{ Shortcut="GP" , Name = "Guadeloupe" },
                    new Country{ Shortcut="GU" , Name = "Guam" },
                    new Country{ Shortcut="GT" , Name = "Guatemala" },
                    new Country{ Shortcut="GN" , Name = "Guinea" },
                    new Country{ Shortcut="GW" , Name = "Guinea-Bissau" },
                    new Country{ Shortcut="GY" , Name = "Guyana" },
                    new Country{ Shortcut="HT" , Name = "Haiti" },
                    new Country{ Shortcut="HM" , Name = "Heard and Mc Donald Islands" },
                    new Country{ Shortcut="HN" , Name = "Honduras" },
                    new Country{ Shortcut="HK" , Name = "Hong Kong" },
                    new Country{ Shortcut="HU" , Name = "Hungary" },
                    new Country{ Shortcut="IS" , Name = "Iceland" },
                    new Country{ Shortcut="IN" , Name = "India" },
                    new Country{ Shortcut="IM" , Name = "Isle of Man" },
                    new Country{ Shortcut="ID" , Name = "Indonesia" },
                    new Country{ Shortcut="IR" , Name = "Iran (Islamic Republic of)" },
                    new Country{ Shortcut="IQ" , Name = "Iraq" },
                    new Country{ Shortcut="IE" , Name = "Ireland" },
                    new Country{ Shortcut="IL" , Name = "Israel" },
                    new Country{ Shortcut="IT" , Name = "Italy" },
                    new Country{ Shortcut="CI" , Name = "Ivory Coast" },
                    new Country{ Shortcut="JE" , Name = "Jersey" },
                    new Country{ Shortcut="JM" , Name = "Jamaica" },
                    new Country{ Shortcut="JP" , Name = "Japan" },
                    new Country{ Shortcut="JO" , Name = "Jordan" },
                    new Country{ Shortcut="KZ" , Name = "Kazakhstan" },
                    new Country{ Shortcut="KE" , Name = "Kenya" },
                    new Country{ Shortcut="KI" , Name = "Kiribati" },
                    new Country{ Shortcut="KP" , Name = "Korea, Democratic People''s Republic of" },
                    new Country{ Shortcut="KR" , Name = "Korea, Republic of" },
                    new Country{ Shortcut="XK" , Name = "Kosovo" },
                    new Country{ Shortcut="KW" , Name = "Kuwait" },
                    new Country{ Shortcut="KG" , Name = "Kyrgyzstan" },
                    new Country{ Shortcut="LA" , Name = "Lao People''s Democratic Republic" },
                    new Country{ Shortcut="LV" , Name = "Latvia" },
                    new Country{ Shortcut="LB" , Name = "Lebanon" },
                    new Country{ Shortcut="LS" , Name = "Lesotho" },
                    new Country{ Shortcut="LR" , Name = "Liberia" },
                    new Country{ Shortcut="LY" , Name = "Libyan Arab Jamahiriya" },
                    new Country{ Shortcut="LI" , Name = "Liechtenstein" },
                    new Country{ Shortcut="LT" , Name = "Lithuania" },
                    new Country{ Shortcut="LU" , Name = "Luxembourg" },
                    new Country{ Shortcut="MO" , Name = "Macau" },
                    new Country{ Shortcut="MK" , Name = "Macedonia" },
                    new Country{ Shortcut="MG" , Name = "Madagascar" },
                    new Country{ Shortcut="MW" , Name = "Malawi" },
                    new Country{ Shortcut="MY" , Name = "Malaysia" },
                    new Country{ Shortcut="MV" , Name = "Maldives" },
                    new Country{ Shortcut="ML" , Name = "Mali" },
                    new Country{ Shortcut="MT" , Name = "Malta" },
                    new Country{ Shortcut="MH" , Name = "Marshall Islands" },
                    new Country{ Shortcut="MQ" , Name = "Martinique" },
                    new Country{ Shortcut="MR" , Name = "Mauritania" },
                    new Country{ Shortcut="MU" , Name = "Mauritius" },
                    new Country{ Shortcut="TY" , Name = "Mayotte" },
                    new Country{ Shortcut="MX" , Name = "Mexico" },
                    new Country{ Shortcut="FM" , Name = "Micronesia, Federated States of" },
                    new Country{ Shortcut="MD" , Name = "Moldova, Republic of" },
                    new Country{ Shortcut="MC" , Name = "Monaco" },
                    new Country{ Shortcut="MN" , Name = "Mongolia" },
                    new Country{ Shortcut="ME" , Name = "Montenegro" },
                    new Country{ Shortcut="MS" , Name = "Montserrat" },
                    new Country{ Shortcut="MA" , Name = "Morocco" },
                    new Country{ Shortcut="MZ" , Name = "Mozambique" },
                    new Country{ Shortcut="MM" , Name = "Myanmar" },
                    new Country{ Shortcut="NA" , Name = "Namibia" },
                    new Country{ Shortcut="NR" , Name = "Nauru" },
                    new Country{ Shortcut="NP" , Name = "Nepal" },
                    new Country{ Shortcut="NL" , Name = "Netherlands" },
                    new Country{ Shortcut="AN" , Name = "Netherlands Antilles" },
                    new Country{ Shortcut="NC" , Name = "New Caledonia" },
                    new Country{ Shortcut="NZ" , Name = "New Zealand" },
                    new Country{ Shortcut="NI" , Name = "Nicaragua" },
                    new Country{ Shortcut="NE" , Name = "Niger" },
                    new Country{ Shortcut="NG" , Name = "Nigeria" },
                    new Country{ Shortcut="NU" , Name = "Niue" },
                    new Country{ Shortcut="NF" , Name = "Norfolk Island" },
                    new Country{ Shortcut="MP" , Name = "Northern Mariana Islands" },
                    new Country{ Shortcut="NO" , Name = "Norway" },
                    new Country{ Shortcut="OM" , Name = "Oman" },
                    new Country{ Shortcut="PK" , Name = "Pakistan" },
                    new Country{ Shortcut="PW" , Name = "Palau" },
                    new Country{ Shortcut="PS" , Name = "Palestine" },
                    new Country{ Shortcut="PA" , Name = "Panama" },
                    new Country{ Shortcut="PG" , Name = "Papua New Guinea" },
                    new Country{ Shortcut="PY" , Name = "Paraguay" },
                    new Country{ Shortcut="PE" , Name = "Peru" },
                    new Country{ Shortcut="PH" , Name = "Philippines" },
                    new Country{ Shortcut="PN" , Name = "Pitcairn" },
                    new Country{ Shortcut="PL" , Name = "Poland" },
                    new Country{ Shortcut="PT" , Name = "Portugal" },
                    new Country{ Shortcut="PR" , Name = "Puerto Rico" },
                    new Country{ Shortcut="QA" , Name = "Qatar" },
                    new Country{ Shortcut="RE" , Name = "Reunion" },
                    new Country{ Shortcut="RO" , Name = "Romania" },
                    new Country{ Shortcut="RU" , Name = "Russian Federation" },
                    new Country{ Shortcut="RW" , Name = "Rwanda" },
                    new Country{ Shortcut="KN" , Name = "Saint Kitts and Nevis" },
                    new Country{ Shortcut="LC" , Name = "Saint Lucia" },
                    new Country{ Shortcut="VC" , Name = "Saint Vincent and the Grenadines" },
                    new Country{ Shortcut="WS" , Name = "Samoa" },
                    new Country{ Shortcut="SM" , Name = "San Marino" },
                    new Country{ Shortcut="ST" , Name = "Sao Tome and Principe" },
                    new Country{ Shortcut="SA" , Name = "Saudi Arabia" },
                    new Country{ Shortcut="SN" , Name = "Senegal" },
                    new Country{ Shortcut="RS" , Name = "Serbia" },
                    new Country{ Shortcut="SC" , Name = "Seychelles" },
                    new Country{ Shortcut="SL" , Name = "Sierra Leone" },
                    new Country{ Shortcut="SG" , Name = "Singapore" },
                    new Country{ Shortcut="SK" , Name = "Slovakia" },
                    new Country{ Shortcut="SI" , Name = "Slovenia" },
                    new Country{ Shortcut="SB" , Name = "Solomon Islands" },
                    new Country{ Shortcut="SO" , Name = "Somalia" },
                    new Country{ Shortcut="ZA" , Name = "South Africa" },
                    new Country{ Shortcut="GS" , Name = "South Georgia South Sandwich Islands" },
                    new Country{ Shortcut="ES" , Name = "Spain" },
                    new Country{ Shortcut="LK" , Name = "Sri Lanka" },
                    new Country{ Shortcut="SH" , Name = "St. Helena" },
                    new Country{ Shortcut="PM" , Name = "St. Pierre and Miquelon" },
                    new Country{ Shortcut="SD" , Name = "Sudan" },
                    new Country{ Shortcut="SR" , Name = "Suriname" },
                    new Country{ Shortcut="SJ" , Name = "Svalbard and Jan Mayen Islands" },
                    new Country{ Shortcut="SZ" , Name = "Swaziland" },
                    new Country{ Shortcut="SE" , Name = "Sweden" },
                    new Country{ Shortcut="CH" , Name = "Switzerland" },
                    new Country{ Shortcut="SY" , Name = "Syrian Arab Republic" },
                    new Country{ Shortcut="TW" , Name = "Taiwan" },
                    new Country{ Shortcut="TJ" , Name = "Tajikistan" },
                    new Country{ Shortcut="TZ" , Name = "Tanzania, United Republic of" },
                    new Country{ Shortcut="TH" , Name = "Thailand" },
                    new Country{ Shortcut="TG" , Name = "Togo" },
                    new Country{ Shortcut="TK" , Name = "Tokelau" },
                    new Country{ Shortcut="TO" , Name = "Tonga" },
                    new Country{ Shortcut="TT" , Name = "Trinidad and Tobago" },
                    new Country{ Shortcut="TN" , Name = "Tunisia" },
                    new Country{ Shortcut="TR" , Name = "Turkey" },
                    new Country{ Shortcut="TM" , Name = "Turkmenistan" },
                    new Country{ Shortcut="TC" , Name = "Turks and Caicos Islands" },
                    new Country{ Shortcut="TV" , Name = "Tuvalu" },
                    new Country{ Shortcut="UG" , Name = "Uganda" },
                    new Country{ Shortcut="UA" , Name = "Ukraine" },
                    new Country{ Shortcut="AE" , Name = "United Arab Emirates" },
                    new Country{ Shortcut="GB" , Name = "United Kingdom" },
                    new Country{ Shortcut="US" , Name = "United States" },
                    new Country{ Shortcut="UM" , Name = "United States minor outlying islands" },
                    new Country{ Shortcut="UY" , Name = "Uruguay" },
                    new Country{ Shortcut="UZ" , Name = "Uzbekistan" },
                    new Country{ Shortcut="VU" , Name = "Vanuatu" },
                    new Country{ Shortcut="VA" , Name = "Vatican City State" },
                    new Country{ Shortcut="VE" , Name = "Venezuela" },
                    new Country{ Shortcut="VN" , Name = "Vietnam" },
                    new Country{ Shortcut="VG" , Name = "Virgin Islands (British)" },
                    new Country{ Shortcut="VI" , Name = "Virgin Islands (U.S.)" },
                    new Country{ Shortcut="WF" , Name = "Wallis and Futuna Islands" },
                    new Country{ Shortcut="EH" , Name = "Western Sahara" },
                    new Country{ Shortcut="YE" , Name = "Yemen" },
                    new Country{ Shortcut="ZR" , Name = "Zaire" },
                    new Country{ Shortcut="ZM" , Name = "Zambia" },
                    new Country{ Shortcut="ZW" , Name = "Zimbabwe" },
                    };
                context.AddRange(countryList);
                context.SaveChanges();
            };

            if (!context.Role.Any()) {
                var accountRoleList = new List<Role>() {
                    new Role { Name = "Admin"},
                    new Role { Name = "Moderator" },
                    new Role { Name = "User" }
                };

                context.AddRange(accountRoleList);
                context.SaveChanges();
            };

            if (!context.Product.Any()) {
                var productList = new List<Product>() {
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "Admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="carlsbergSpZoo.png",
                        Name="Carlsberg Polska Sp. z o.o.",
                        Description = "Carlsberg Polska Sp. z o.o. – polskie przedsiębiorstwo z branży piwowarskiej należące do duńskiego koncernu Carlsberg Group. Do Carlsberg Polska należy 15,3% udziałów w rynku piwa w Polsce.",
                        
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="harnasJasnePelne.png",
                        Name="Harnaś Jasne pełne",
                        Description = "Szlachetne męskie piwo pełne siły, humoru i pogody ducha. Orzeźwia i cieszy swoim wyjątkowym smakiem i aromatem. Idealne po pracy. ",
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="harnasOkocimski.png",
                        Name="Harnaś Okocimski",
                        Description = "Piwo jasne pełne, którego sprawdzona receptura jest sekretem jakości. To piwo stanowi doskonałe połączenie składników oraz gwarantuje jego głęboki i pełny smak. To oczywiście slogan producenta. Jest standardową propozycją, która nie odbiega znacząco od średniej. Producent piwa akcentuje, że kupując Harnasia wspierasz tatrzańskie drapieżniki.",

                    }
                };

                context.AddRange(productList);
                context.SaveChanges();

            };
            if (!context.Brewery.Any()) {
                var breweryList = new List<Brewery>(){
                    new Brewery {
                        ProductId = context.Product.First(x=>x.Picture == "carlsbergSpZoo.png").Id,
                        NumberOfBuilding = "34",
                        PostalCode = "02-255",
                        Place="Warszawa",
                        Street="Krakowiaków",
                        PostOffice="Warszawa",
                    },
                };
                context.AddRange(breweryList);
                context.SaveChanges();
            };

            if (!context.Beer.Any()) {
                var beerList = new List<Beer>(){
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        //BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 6.0,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                        //BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 6.0,
                    }
                };
                context.AddRange(beerList);
                context.SaveChanges();
            };

            if (!context.Comment.Any()) {
                var comment = new List<Comment>(){
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Zombie ipsum reversus ab viral inferno, nam rick grimes malum cerebro. De carne lumbering animata corpora quaeritis. Summus brains sit​​, morbo vel maleficia? De apocalypsi gorger omero undead survivor dictum mauris. Hi mindless mortuis soulless creaturas, imo evil stalking monstra adventus resi dentevil vultus comedat cerebella viventium. ",
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Tri-tip jerky beef ribs kevin ground round, pork loin kielbasa burgdoggen shoulder. Turkey flank short loin porchetta, chuck frankfurter sausage. Frankfurter leberkas buffalo, chicken tenderloin bacon shank turducken landjaeger beef ribs shankle corned beef. Pork ground round meatball beef meatloaf shoulder. Kielbasa landjaeger biltong tongue kevin alcatra, doner short loin frankfurter burgdoggen spare ribs fatback tenderloin ham corned beef. Cupim ham flank biltong pork belly pork burgdoggen ham hock filet mignon.",
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                    }
                };
                context.AddRange(comment);
                context.SaveChanges();
            };

            if (!context.Vote.Any()) {
                var voteList = new List<Vote>() {
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                        VoteValue = 4,
                    },
                };
            };
        }
    }
}
