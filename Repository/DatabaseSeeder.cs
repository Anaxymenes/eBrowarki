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
                        new BeerType{ Name = "Pszeniczne"},
                        new BeerType{ Name = "Pilzner"},
                        new BeerType{ Name = "Lager"},
                        new BeerType{ Name = "Ice Lager"},
                        new BeerType{ Name = "Pale Lager"},
                        new BeerType{ Name = "International Pale Lager"},
                        new BeerType{ Name = "Premium Lager"},
                        new BeerType{ Name = "Strong Pale Lager"},
                        new BeerType{ Name = "Sour Ale" },
                        new BeerType{ Name = "Christmas/Winter Specialty Spiced Beer"},
                        new BeerType{ Name = "Pilzner czeski"},
                        new BeerType{ Name = "Pilzner niemiecki"},
                        new BeerType{ Name = "Pilzner amerykański"},
                        new BeerType{ Name = "Ciemny lager"},
                        new BeerType{ Name = "Monachijskie ciemne"},
                        new BeerType{ Name = "Ciemny amerykański lager"},
                        new BeerType{ Name = "Czarne"},
                        new BeerType{ Name = "Czarne czeskie"},
                        new BeerType{ Name = "Czarne niemieckie"},
                        new BeerType{ Name = "Półciemny lager"},
                        new BeerType{ Name = "Koźlak"},
                        new BeerType{ Name = "Koźlak tradycyjny"},
                        new BeerType{ Name = "Koźlak majowy"},
                        new BeerType{ Name = "Koźlak dubeltowy/podwójny"},
                        new BeerType{ Name = "Koźlak lodowy (Eisbock)"},
                        new BeerType{ Name = "Robust Porter"},
                        new BeerType{ Name = "Hefeweizen"},
                        new BeerType{ Name = "Dunkelweizen"},
                        new BeerType{ Name = "Pszeniczne kryształowe"},
                        new BeerType{ Name = "Witbier"},
                        new BeerType{ Name = "Koźlak pszeniczny"},
                        new BeerType{ Name = "Amber Ale"},
                        new BeerType{ Name = "Golden Ale"},
                        new BeerType{ Name = "Belgian Pale Ale"},
                        new BeerType{ Name = "Saison"},
                        new BeerType{ Name = "Bière de Garde"},
                        new BeerType{ Name = "Blond Ale"},
                        new BeerType{ Name = "India Pale Ale"},
                        new BeerType{ Name = "English India Pale Ale"},
                        new BeerType{ Name = "American India Pale Ale"},
                        new BeerType{ Name = "Imperial India Pale Ale"},
                        new BeerType{ Name = "English Pale Ale/Bitter"},
                        new BeerType{ Name = "Dry Stout"},
                        new BeerType{ Name = "Sweet Stout"},
                        new BeerType{ Name = "Stout aromatyzowany"},
                        new BeerType{ Name = "Stout owsiany"},
                        new BeerType{ Name = "Stout czekoladowy"},
                        new BeerType{ Name = "Stout mleczny"},
                        new BeerType{ Name = "Stout kawowy"},
                        new BeerType{ Name = "Stout ostrygowy"},
                        new BeerType{ Name = "Foreign Stout"},
                        new BeerType{ Name = "Russian Imperial Stout"},
                        new BeerType{ Name = "Klasztorne"},
                        new BeerType{ Name = "Dubbel"},
                        new BeerType{ Name = "Tripel"},
                        new BeerType{ Name = "Quadrupel"},
                        new BeerType{ Name = "English Brown"},
                        new BeerType{ Name = "English Mild"},
                        new BeerType{ Name = "Cream Ale"},
                        new BeerType{ Name = "Kölsch"},
                        new BeerType{ Name = "Lambic"},
                        new BeerType{ Name = "Lambic łamany"},
                        new BeerType{ Name = "Gueuze"},
                        new BeerType{ Name = "Faro"},
                        new BeerType{ Name = "Lambic owocowy"},
                        new BeerType{ Name = "Kriek"},
                        new BeerType{ Name = "Framboise"},
                        new BeerType{ Name = "Gose"},
                        new BeerType{ Name = "Berliner Weisse"},
                        new BeerType{ Name = "Oud Bruin"},
                        new BeerType{ Name = "Fruit Beer"},
                        new BeerType{ Name = "Spice, Herb, or Vegetable Beer"},
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
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="carlsbergSpZoo.png",
                        Name="Carlsberg Polska Sp. z o.o.",
                        Description = "Carlsberg Polska Sp. z o.o. – polskie przedsiębiorstwo z branży piwowarskiej należące do duńskiego koncernu Carlsberg Group. Do Carlsberg Polska należy 15,3% udziałów w rynku piwa w Polsce.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="kompaniaPiwowarska.png",
                        Name="Kompania Piwowarska",
                        Description = "Kompania Piwowarska - grupa piwowarska z siedzibą w Poznaniu, należąca w 100% do japońskiego koncernu piwowarskiego Asahi.Kompania Piwowarska posiada obecnie trzy browary: Lech Browary Wielkopolski w Poznaniu, Browar Książęcy w Tychach i Dojlidy w Białymstoku. Do jej portfela należą najpopularniejsze piwa sprzedawane na terenie Polski, m.in. Tyskie, Żubr, Lech, Dębowe Mocne, Redd’s.Firma posiada ok. 33 % udziałów w polskim rynku piwa i zatrudnia ponad 3200 osób.Sumaryczna roczna produkcja browarów Kompanii Piwowarskiej wynosi ok. 14 milionów hektolitrów. Wielkość sprzedaży osiągniętej przez KP w roku finansowym zakończonym 31 marca 2014 r.wyniosła 13,3 mln hektolitrów piwa.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="vph.png",
                        Name="VPH SA",
                        Description = "VPH SA – polski producent piwa i napojów bezalkoholowych otrzymywanych na bazie słodu. Spółka została założona w 1989 roku jako polsko-niemieckie joint venture pod nazwą Van Pur. Do przedsiębiorstwa należy pięć zakładów piwowarskich (Jędrzejów, Koszalin, Łomża, Rakszawa, Zabrze).",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="grupaZywiec.png",
                        Name="Grupa Żywiec",
                        Description = "Grupa Żywiec S.A. – spółka giełdowa zajmująca się produkcją piwa. Obejmuje pięć browarów: w Cieszynie, Elblągu, Leżajsku, Warce i Żywcu. Wcześniej w skład grupy wchodziły także browary w Bielsku-Białej, Braniewie, Bydgoszczy, Gdańsku, Łańcucie i Warszawie. Należy do Grupy Heineken.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=false,
                        Picture="browaryRegionalneJakubiak.png",
                        Name="Browary Regionalne Jakubiak",
                        Description = "Browary Regionalne Jakubiak Sp. z o.o. (BRJ) – polski producent piwa, napojów słodowych i destylatów. Jej założycielem i właścicielem jest warszawski przedsiębiorca Marek Jakubiak. Siedziba spółki BRJ mieści się w Dziekanowie Nowym pod Warszawą.",
                        Approved = true
                    },

                    //Beers
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="harnasJasnePelne.png",
                        Name="Harnaś Jasne pełne",
                        Description = "Szlachetne męskie piwo pełne siły, humoru i pogody ducha. Orzeźwia i cieszy swoim wyjątkowym smakiem i aromatem. Idealne po pracy. ",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="harnasOkocimski.png",
                        Name="Harnaś Okocimski",
                        Description = "Piwo jasne pełne, którego sprawdzona receptura jest sekretem jakości. To piwo stanowi doskonałe połączenie składników oraz gwarantuje jego głęboki i pełny smak. To oczywiście slogan producenta. Jest standardową propozycją, która nie odbiega znacząco od średniej. Producent piwa akcentuje, że kupując Harnasia wspierasz tatrzańskie drapieżniki.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="harnasGrzaniec.png",
                        Name="Harnaś Grzaniec",
                        Description = "Piwo idealne na zimę ! Dostępne tylko w sieci Lidl. Producent mówi o tym piwie, że jest znakomite do wypicia zarówno na zimno, jak i w postaci grzańca. Kolor ciemnozłoty, wręcz rdzawy. Piana wysoka i dosyć gęsta, szybko opada do cieniutkiej warstwy; koloru kremowobiałego. Nasycenie dosyć spore, nie szczypie jednak w język. Zapach wyraźny, intensywny. Mieszają się w nim nuty cynamonowo-goździkowe, nieco ziołowy. W zapachu i smaku niestety wyczuwa się alkohol. Poza tym pojawiają się w smaku nuty goździkowe, cynamonowe, owocowe i lekka goryczka chmielowa. Poza tym piwo jest intensywnie słodkie. Jest to piwo z zaprawą o smaku korzennym, według informacji producenta.",
                        Approved = false
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="okocim.png",
                        Name="Okocim",
                        Description = "Wywodził się z bawarskiego rodu browarników, od najmłodszych lat zbierał doświadczenia i pobierał nauki zdobywając kolejne etapy browarniczego wtajemniczenia. Pierwsze piwo w browarze należącym do spółki Neumann-Goetz uwarzono wiosną 1846 roku. Receptura oparta była o metodę bawarską, zgodnie z najnowszymi trendami i osiągnięciami sztuki browarniczej. Gdy zmarł jego wspólnik, Jan Ewangelista Goetz mógł sam rozwijać projekt życia zgodnie z zasadą: “najlepsze z najlepszego” i warzyć pierwszego na dzisiejszych ziemiach polskich Lagera. Receptura była prosta, tylko 3 składniki: woda, słód jęczmienny i chmiel. Zasady i dzieło ojca kultywował i rozwijał syn Jan Albin Goetz, który w roku 1911 przyjął polskie nazwisko Okocimski i od tego czasu znany był jako baron Jan Goetz-Okocimski (1864-1935) z dewizą herbową “Pracą i Prawdą”. Jego życie to rozwój browaru i czas świetności Okocimia.",
                        Approved = false
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="kasztelanJasnePelne.png",
                        Name="Kasztelan Jasne Pełne",
                        Description = "Jasnobursztynowa barwa, pełna klarowność, kusząca piana, intensywna goryczka i jedyna w swoim rodzaju chmielowa nuta bukietu zapachowego, a wszystko to z czystego ekologicznie terenu Mazowsza i Kujaw, z najlepszych naturalnych składników (własny słód, woda oligoceńska). Kasztelan Jasne Pełne to ulubiony trunek piwoszy szukających szlachetnego smaku i dobrej zabawy. Piwo to było wielokrotnie nagradzane medalami, w tym złotym na Ogólnopolskiej Degustacji Piwa \"Chmielaki\".",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="kasztelanNiepasteryzowane.png",
                        Name="Kasztelan Niepasteryzowane",
                        Description = "Naturalne składniki, tradycyjna receptura, brak pasteryzacji to sekrety wyjątkowego smaku piwa Kasztelan Niepasteryzowane.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="kasztelanMocne.png",
                        Name="Kasztelan Mocne",
                        Description = "Barwa ciemnego bursztynu, intensywna goryczka i obfita gęsta piana wraz z dużą zawartością ekstraktu i alkoholu sprawiają, że Kasztelan Mocne jest lubiany przez tych miłośników piwa, dla których ważny jest nie tylko smak, ale też moc piwa. Piwo to produkowane jest z najlepszych naturalnych składników pochodzących z terenu Mazowsza i Kujaw, jako nieodłączny składnik biesiad idealnie nadaje się do spotkań w szerszym gronie.Piwo Kasztelan Mocne zostało nagrodzone złotym medalem w międzynarodowym konkursie Monde Selection 2010 w Brukseli.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="tyskie.png",
                        Name="Tyskie",
                        Description = "Tyskie jest niekwestionowanym liderem polskiego rynku piwa.Od lat zdobywa uznanie zarówno w kraju jak i zagranicą. Wielokrotnie zostało uhonorowane najbardziej prestiżowymi laurami branży piwowarskiej. Koneserzy piwa cenią w Tyskim łagodny chmielowy zapach, złocisty kolor oraz gęstą białą pianę.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="zubr.png",
                        Name="Żubr",
                        Description = "Żubr kojarzony jest z nieskażoną przyrodą, której bliskość wpływa na jego niepowtarzalny smak. Warzony z naturalnych składników od ponad 200 lat na skraju Puszczy Białowieskiej, jest idealny na zakończenie każdego dnia. Żubr jest pełen spokoju i harmonii, znakomity w czasie relaksu na świeżym powietrzu po trudach tygodnia. To druga pod względem wielkości sprzedaży marka piwa w Polsce.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="lechPremium.png",
                        Name="Lech Premium",
                        Description = "Lech Premium to jedna z czołowych marek Kompanii Piwowarskiej, która istnieje na rynku już od początku lat osiemdziesiątych. Doprowadzony do perfekcji proces produkcji Lecha w poznańskim browarze, jednym z najnowocześniejszych browarów w Europie, jest gwarancją najwyższej jakości piwa Lech. Piwo Lech Premium to harmonia smaku i odpowiedniego nagazowania, które nadają mu doskonałych właściwości orzeźwiających, idealne połączenie mocy ze szlachetną goryczą dojrzałego chmielu. Piwo warzone z naturalnych składników.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="reddsApple.png",
                        Name="Redd's Apple",
                        Description = "Redd's to marka inna niż wszystkie, której walory doceniają osoby poszukujące wyjątkowych doznań. Redds Apple to wyjątkowy smak i unikalny jabłkowy aromat. Redds Apple najlepiej gasi pragnienie w upalne dni dzięki swoim orzeźwiającym właściwościom. Redds Apple to piwo dla tych, którzy pragną czegoś odmiennego, wyjątkowego i poszukują nowych doznań. Podawać mocno schłodzone, szczególnie polecane w upalne letnie dni i wieczory.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="lomzaExport.png",
                        Name="Łomża Export",
                        Description = "Nazwa Export stanowi nawiązanie do obecności marki na rynkach zagranicznych, zwłaszcza w Stanach Zjednoczonych, dokąd jest eksportowane od 1997 roku. Wyjątkowy smak i jakość piwa Łomża zawdzięcza powolnemu dojrzewaniu, z dala od wielkomiejskiego zgiełku. Prawdziwie regionalne piwo.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="rybnickiFull.png",
                        Name="Rybnicki Full",
                        Description = "Rybnicki Full to tradycyjne piwo z kategorii piw jasnych, pełnych. Lokalna marka dostępna wyłącznie na terenie dawnego Rybnickiego Okręgu Węglowego. Stanowi esencję śląskiej kultury picia piwa, przenoszonej z pokolenia na pokolenie przez całe rzesze górników tradycyjnie spotykających się po szychcie przy kuflach Rybnickiego Fulla. Warzenie naszego piwa odbywa się w poszanowaniu tradycji Browaru Rybnickiego Herman Muller.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="koronaKsiazeca.png",
                        Name="Korona Książęca",
                        Description = "Nowoczesny wygląd opakowania, przystępna cena oraz najwyższa, charakterystyczna dla piw Browaru Łomża jakość produktu sprawiają, że w pełni odpowiada ona oczekiwaniom nawet najbardziej wymagających miłośników chmielowego trunku. Można ją nabyć w centralnej, wschodniej i południowej Polsce, gdzie firma Royal Unibrew prowadzi aktywną dystrybucję. Piwo Korona Książęca, zajęło 1 miejsce w Otwartym Konkursie Piw Gali Browarników 2009 w kategorii piwo jasne pełne o zawartości ekstraktu w brzeczce 10.2-11.1º blg.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="zywiecJasnePelne.png",
                        Name="Żywiec Jasne Pełne",
                        Description = "Piwo Żywiec od momentu powstania w 1856 r. jest warzone stale i niezmiennie w tym samym miejscu – browarze w Żywcu. Najsłynniejsze polskie piwo typu pilzneńskiego. Absolutna klasyka gatunku i idealne połączenie tradycji z nowoczesnością.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="heineken.png",
                        Name="Heineken",
                        Description = "Heineken, w charakterystycznej zielonej butelce, jest jedną z najsilniejszych międzynarodowych marek piwa. Jest sprzedawany na każdym kontynencie w ponad 180 krajach świata. W Polsce Heineken jest największą marką w segmencie International Premium, cenioną przez osoby szukające piwa najwyższej jakości. Na polskim rynku Heineken pojawił się oficjalnie w 1994. Od stycznia 2000 stał się częścią oferty handlowej Grupy Żywiec. Od czerwca 2001 wedle tradycyjnej receptury, przy zachowaniu najwyższych standardów browarniczych, Heineken warzony jest w browarze w Żywcu.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="zywiecPorter.png",
                        Name="Żywiec Porter",
                        Description = "Żywiec Porter jest bardzo mocnym i treściwym piwem charakteryzującym się posmakiem palonego słodu z nutami kawowo-karmelowymi. Produkowany jest ze słodu monachijskiego oraz kombinacji słodów jasnych i specjalnych, fermentowany w otwartych kadziach i poddawany długiemu okresowi leżakowania, który może trwać do 6 miesięcy. Recepturę piwa Żywiec Porter wymyślił w 1881 r. Juliusz Wagner, który był naczelnym piwowarem Arcyksiążęcego Browaru w Żywcu. Od tego roku piwo Żywiec Porter produkowane było w Żywcu. W związku jednak ze zmianą systemu produkcji w żywieckim browarze i wprowadzeniem technologii HGB na początku XXI wieku, w latach 2003-2004 Grupa Żywiec przeniosła wyrób Portera do Cieszyna, gdzie zostały zachowane dawne urządzenia piwowarskie.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="tatraJasnePelne.png",
                        Name="Tatra Jasne Pełne",
                        Description = "Tatra to marka znana i ceniona przez piwoszy w Polsce, a jej popularność stale rośnie. Warzone jest w renomowanych browarach Grupy Żywiec. Tatra Jasne Pełne to klasyczne piwo typu pilzneńskiego o wyraźnym aromacie i doskonałym, orzeźwiającym smaku.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="ciechanMiodowe.png",
                        Name="Ciechan Miodowe",
                        Description = "Browar w Ciechanowie jako pierwszy w Polsce wyprodukował piwo tego typu metodą tradycyjną przy zachowaniu starych receptur. Tradycyjne procesy warzenia gwarantują niepowtarzalny aromat i smak. Piwo Miodowe to napój posiadający wyjątkowe walory smakowe, odżywcze i zdrowotne. Orzeźwia i pobudza apetyt, działa rozgrzewająco. Cudowny złocisty kolor i miodowy aromat nadają mu absolutną unikalność i wyjątkowość. Ulubione przez płeć Piękną . Można je spożywać w postaci „grzańca”.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="ciechanMocne.png",
                        Name="Ciechan Mocne",
                        Description = "Piwo Ciechan Mocne Niepasteryzowane produkowane przez Browar Ciechan jest warzone metodą dekokcyjną przy zachowaniu starych receptur. Tradycyjne procesy warzenia gwarantują niepowtarzalny aromat, klarowność i smak. W Warszawie i okolicach znane było jako Mocny Król. Piwo Ciechan Mocne Niepasteryzowane jest filtrowane, posiada wyjątkowe walory smakowe, odżywcze i zdrowotne.",
                        Approved = true
                    },
                    new Product {
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        Date = DateTime.Now,
                        CountryId = context.Country.First(x=>x.Name=="Poland").Id,
                        IsBeer=true,
                        Picture="bojanStrazackie.png",
                        Name="Bojan Strażackie",
                        Description = "Strażackie to niefiltrowany Lager, do stworzenia którego użyto czterech odmian chmieli: Marynka, Lubelski, Amarillo, Sybilla. Gęsta drobnopęcherzykowa piana opada do cienkiego kożuszka, pozostawiając obrączki na szkle. W zapachu akcenty owocowe i żywiczne.Smak orzeźwiający, lekko kwaskowe z owocowymi nutami. Goryczka niezbyt intensywna i nie trwała.",
                        Approved = true
                    },
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
                    new Brewery {
                        ProductId = context.Product.First(x=>x.Picture == "kompaniaPiwowarska.png").Id,
                        NumberOfBuilding = "11",
                        PostalCode = "61-286",
                        Place="Poznań",
                        Street="Szwajcarska",
                        PostOffice="Poznań",
                    },
                    new Brewery {
                        ProductId = context.Product.First(x=>x.Picture == "vph.png").Id,
                        NumberOfBuilding = "7",
                        PostalCode = "02-677",
                        Place="Warszawa",
                        Street="Cybernetyki",
                        PostOffice="Warszawa",
                    },
                    new Brewery {
                        ProductId = context.Product.First(x=>x.Picture == "browaryRegionalneJakubiak.png").Id,
                        NumberOfBuilding = "400",
                        PostalCode = "05-092",
                        Place="Dziekanów Nowy",
                        Street="Kolejowa",
                        PostOffice="Dziekanów Nowy",
                    },
                    new Brewery {
                        ProductId = context.Product.First(x=>x.Picture == "grupaZywiec.png").Id,
                        NumberOfBuilding = "88",
                        PostalCode = "34-300",
                        Place="Żywiec",
                        Street="Browarna",
                        PostOffice="Żywiec",
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
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="harnasGrzaniec.png").Id,
                        //BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 6.0,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="okocim.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 5.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 5.7,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 5.7,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Carlsberg Polska Sp. z o.o.").Id).Id,
                        Alcohol = 6.8,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Kompania Piwowarska").Id).Id,
                        Alcohol = 5.6,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Kompania Piwowarska").Id).Id,
                        Alcohol = 6.0,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Kompania Piwowarska").Id).Id,
                        Alcohol = 5.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="reddsApple.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Kompania Piwowarska").Id).Id,
                        Alcohol = 4.5,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="lomzaExport.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "VPH SA").Id).Id,
                        Alcohol = 5.7,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="rybnickiFull.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "VPH SA").Id).Id,
                        Alcohol = 5.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="koronaKsiazeca.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "VPH SA").Id).Id,
                        Alcohol = 5.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="zywiecJasnePelne.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Grupa Żywiec").Id).Id,
                        Alcohol = 5.6,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Grupa Żywiec").Id).Id,
                        Alcohol = 5.0,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="zywiecPorter.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Grupa Żywiec").Id).Id,
                        Alcohol = 9.5,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="tatraJasnePelne.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Grupa Żywiec").Id).Id,
                        Alcohol = 6.0,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="ciechanMiodowe.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Browary Regionalne Jakubiak").Id).Id,
                        Alcohol = 6.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="ciechanMocne.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Browary Regionalne Jakubiak").Id).Id,
                        Alcohol = 6.2,
                    },
                    new Beer {
                        ProductId = context.Product.First(x=>x.Picture=="bojanStrazackie.png").Id,
                        BreweryId = context.Brewery.First(x=>x.ProductId == context.Product.First(z=>z.Name == "Browary Regionalne Jakubiak").Id).Id,
                        Alcohol = 5.0,
                    },
                };
                context.AddRange(beerList);
                context.SaveChanges();
            };

            if (!context.BeerTypeBeer.Any()) {
                var beerTypeBeerList = new List<BeerTypeBeer>() {
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="harnasGrzaniec.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Christmas/Winter Specialty Spiced Beer").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="okocim.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Strong Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Strong Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Premium Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="reddsApple.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Fruit Beer").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="lomzaExport.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Premium Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="rybnickiFull.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Premium Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="koronaKsiazeca.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="zywiecJasnePelne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "International Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="zywiecPorter.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Porter Bałtycki").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="tatraJasnePelne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="ciechanMiodowe.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Spice, Herb, or Vegetable Beer").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="ciechanMocne.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Strong Pale Lager").Id
                    },
                    new BeerTypeBeer { ProductId = context.Product.First(x=>x.Picture=="bojanStrazackie.png").Id,
                                        BeerTypeId = context.BeerType.First(x=>x.Name == "Premium Lager").Id
                    },
                };
                context.AddRange(beerTypeBeerList);
                context.SaveChanges();
            };

            if (!context.Comment.Any()) {
                var comment = new List<Comment>(){
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Moje ulubione piwo. Pije codziennie.",
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Okropne.",
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Kiedyś piłem perle, nic mi w życiu nie wychodziło, nie zdałem prawka, dziewczyna mnie zdradziła. Zrezygnowany życiem poszedłem jak to mialem w zwyczaju do żabki i wtedy zobaczyłem ten cud piwowarstwa w postaci 3 sztuk za 5 złoty. Zakochałem się od razu w jego niepowtarzalnym smaku pieszczącym migdałki oraz aromatowi pobudzającym zmysły. Najlepsze piwko, zmieniło moje życie, polecam wsystkim mocno.",
                        ProductId = context.Product.First(x=>x.Picture=="harnasGrzaniec.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Przyjemne zaskoczenie. Gęsta piana, która długo nie znika, przypomina lody. Smak rewelacyjny, aż za dobry, przypomina gęstą, gorzką kawę, espresso. Po chwili gorycz zanika, pojawia się słodki posmak (karmel?). W porównaniu z innymi porterami znanych marek, ten jest wyjątkowo udany. Trudno się do czegoś przyczepić. Np. porter Żywca jest męczący przy drugiej butelce, a ten nie. Chociaż ma sporo alkoholu to nie czuć go w smaku, tylko w głowie :)",
                        ProductId = context.Product.First(x=>x.Picture=="okocim.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Całkiem dobry koncerniak. Śmiało może rywalizować z Perłą Chmielową, Lezajskiem albo Bosmanem. Tylko napis \"piwo regionalne\" jest już chyba trochę przesadzone odkąd warzy je Carlsberg.",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Według mnie Kasztelan Jasne Pełne i Bosman Full to dokładnie to samo piwo. Obydwa mają po 5.7%, smakują tak samo, są produkowane w tym samym miejscu i mają identyczne promocyjne zawleczki od puszek. Piwo jest dobre, ale według mnie to oszustwo sprzedawać to samo piwo jako dwie różne marki.",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Nie da się tego pić. Sam spiryt.",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Reklamowy chwyt ostatnich lat, piwo niepasteryzowane, i co z tego skoro jest mikrofiltrowane. Typowy koncerniak, nastawiony na dużą sprzedaż napędzaną reklamą. Jak komuś smakuje niech pije, dla mnie to piwo drugiego, a trzeciego wyboru.",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Czuć spirytem...",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Na pohybel wszystkim przeciwnikom tego browaru - od lat dla mnie jedno z najlepszych piw w Polsce (mowa o koncerniakach).",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Jest to jedyny Kasztelan ktory przypomina te piwo ktore browar warzyl w latach 90 tych przed zepsuciem smaku przez koncern Calsberga",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "dobre piwko polecam",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Zachowane elegancko, tak jakie jak kiedyś",
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Typowy niedobry koncerniak, unikam jak ognia.",
                        ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Ostatnio hejtowalem na Tyskie, ale musze sie z tego wycofac. Powiem tak: Podany pelny sklad (wielki plus), a w tym skladzie brak syrou glukozowego, glukozowo-fruktozowego ani kukurydzy! Rzetelna informacja i to sie ceni. Woda, slod i chmiel! Tak ma byc! Od razu odczuwam skok jakosci w gore. Musze uczciwie dac 6/10. Do tego wygrane piwo. Kupie ponownie.",
                        ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "woda z farbkom",
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "bardzo lubię żubra, ale oszukują klientów z wygraną i to moje ostatnie piwa. Nie tylko moje. Na 15 krat (300 piw) 0 wygranych",
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Szczerze to w ciągu roku wygrałem 6 Żubrów. myślę, że nie źle a piwko wypiję 2-4 w ciągu weekendu. Co do smaku to fakt, od miesiąca-dwóch coś się zepsuło... Głowa boli po nim ;/",
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "dobre",
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Co partia to inny smak. Raz się takie paskudne trafiło, walilo chemią, jakby z płukanki, że poszło do zlewu.",
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Teraz znowu jest dobre. Uczciwy skład (woda, słody, chmiel), znowu jest goryczka.",
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Pachnie ziołem po otwarciu xd",
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Wygląd puszki po małym liftingu. Parę lat temu było z tym kiepsko, a teraz całkiem pijalny koncerniak.",
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Do grilla pasuje, szalu nie robi ale ładny zapach po otwarciu butelki",
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Smak to jeden wielki syyyf. Kupiłem w lidlu",
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Zanim kraft zagościł w Polsce był to dla mnie synonim \"prestiżu\" i mam do Heniutka pewen sentyment.",
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                    },
                    new Comment {
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        Date = DateTime.Now,
                        Content = "Piłem Heńka 2 lata temu w Holandii w knajpie, z kufla i był nie dobry, coś ala ten z biedry może trochę mniej wadliwy i słodszy.",
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                    },
                };
                context.AddRange(comment);
                context.SaveChanges();
            };

            if (!context.Vote.Any()) {
                var voteList = new List<Vote>() {
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        VoteValue = 1,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        VoteValue = 2,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "moderator").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasJasnePelne.png").Id,
                        VoteValue = 1,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                        VoteValue = 1,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="harnasOkocimski.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="okocim.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="okocim.png").Id,
                        VoteValue = 2,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanJasnePelne.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                        VoteValue = 2,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanNiepasteryzowane.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                        VoteValue = 1,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="kasztelanMocne.png").Id,
                        VoteValue = 2,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="tyskie.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="zubr.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="lechPremium.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="reddsApple.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="reddsApple.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="lomzaExport.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="lomzaExport.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="rybnickiFull.png").Id,
                        VoteValue = 2,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="rybnickiFull.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="koronaKsiazeca.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="zywiecJasnePelne.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="zywiecJasnePelne.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                        VoteValue = 3,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="heineken.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="zywiecPorter.png").Id,
                        VoteValue = 4,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="tatraJasnePelne.png").Id,
                        VoteValue = 1,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "user").Id,
                        ProductId = context.Product.First(x=>x.Picture=="ciechanMiodowe.png").Id,
                        VoteValue = 5,
                    },
                    new Vote{
                        AccountId = context.Account.First(x=>x.Username == "admin").Id,
                        ProductId = context.Product.First(x=>x.Picture=="ciechanMiodowe.png").Id,
                        VoteValue = 4,
                    },
                };
                context.AddRange(voteList);
                context.SaveChanges();
            };
        }
    }
}
