using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EnricoApi
{
    public enum Region
    {
        #region Austrialia

        [EnumMember(Value = "Australian Capital Territory")]
        AustralianCapitalTerritory,
        [EnumMember(Value = "Queensland")]
        Queensland,
        [EnumMember(Value = "New South Wales")]
        NewSouthWales,
        [EnumMember(Value = "Northern Territory")]
        NorthernTerritory,
        [EnumMember(Value = "South Australia")]
        SouthAustralia,
        [EnumMember(Value = "Tasmania")]
        Tasmania,
        [EnumMember(Value = "Victoria")]
        Victoria,
        [EnumMember(Value = "Western Australia")]
        WesternAustralia,

        #endregion

        #region Canada

        [EnumMember(Value = "Alberta")]
        Alberta,
        [EnumMember(Value = "British Columbia")]
        BritishColumbia,
        [EnumMember(Value = "Manitoba")]
        Manitoba,
        [EnumMember(Value = "New Brunswick")]
        NewBrunswick,
        [EnumMember(Value = "Newfoundland and Labrador")]
        NewfoundlandAndLabrador,
        [EnumMember(Value = "Northwest Territories")]
        NorthwestTerritories,
        [EnumMember(Value = "Nova Scotia")]
        NovaScotia,
        [EnumMember(Value = "Nunavut")]
        Nunavut,
        [EnumMember(Value = "Ontario")]
        Ontario,
        [EnumMember(Value = "Prince Edward Island")]
        PrinceEdwardIsland,
        [EnumMember(Value = "Quebec")]
        Quebec,
        [EnumMember(Value = "Saskatchewan")]
        Saskatchewan,
        [EnumMember(Value = "Yukon")]
        Yukon,

        #endregion

        #region France

        [EnumMember(Value = "Alsace")]
        Alsace,
        [EnumMember(Value = "Moselle")]
        Moselle,

        #endregion

        #region Germany

        [EnumMember(Value = "Baden-Württemberg")]
        BadenWürttemberg,
        [EnumMember(Value = "Bavaria")]
        Bavaria,
        [EnumMember(Value = "Berlin")]
        Berlin,
        [EnumMember(Value = "Brandenburg")]
        Brandenburg,
        [EnumMember(Value = "Bremen")]
        Bremen,
        [EnumMember(Value = "Hamburg")]
        Hamburg,
        [EnumMember(Value = "Hesse")]
        Hesse,
        [EnumMember(Value = "Mecklenburg-Vorpommern")]
        MecklenburgVorpommern,
        [EnumMember(Value = "Lower Saxony")]
        LowerSaxony,
        [EnumMember(Value = "North Rhine-Westphalia")]
        NorthRhineWestphalia,
        [EnumMember(Value = "Saarland")]
        Saarland,
        [EnumMember(Value = "Saxony")]
        Saxony,
        [EnumMember(Value = "Saxony-Anhalt")]
        SaxonyAnhalt,
        [EnumMember(Value = "Schleswig-Holstein")]
        SchleswigHolstein,
        [EnumMember(Value = "Thuringia")]
        Thuringia,

        #endregion

        #region New Zealand

        [EnumMember(Value = "Auckland")]
        Auckland,
        [EnumMember(Value = "Canterbury")]
        Canterbury,
        [EnumMember(Value = "Chatham Islands")]
        ChathamIslands,
        [EnumMember(Value = "Hawkes' Bay")]
        HawkesBay,
        [EnumMember(Value = "Marlborough")]
        Marlborough,
        [EnumMember(Value = "Nelson")]
        Nelson,
        [EnumMember(Value = "Otago")]
        Otago,
        [EnumMember(Value = "South Canterbury")]
        SouthCanterbury,
        [EnumMember(Value = "Southland")]
        Southland,
        [EnumMember(Value = "Taranaki")]
        Taranaki,
        [EnumMember(Value = "Wellington")]
        Wellington,
        [EnumMember(Value = "Westland")]
        Westland,

        #endregion

        #region UnitedStatesOfAmerica

        [EnumMember(Value = "Alabama")]
        Alabama,
        [EnumMember(Value = "Alaska")]
        Alaska,
        [EnumMember(Value = "Arizona")]
        Arizona,
        [EnumMember(Value = "Arkansas")]
        Arkansas,
        [EnumMember(Value = "California")]
        California,
        [EnumMember(Value = "Colorado")]
        Colorado,
        [EnumMember(Value = "Connecticut")]
        Connecticut,
        [EnumMember(Value = "Delaware")]
        Delaware,
        [EnumMember(Value = "District Of Columbia")]
        DistrictOfColumbia,
        [EnumMember(Value = "Florida")]
        Florida,
        [EnumMember(Value = "Georgia")]
        Georgia,
        [EnumMember(Value = "Hawaii")]
        Hawaii,
        [EnumMember(Value = "Idaho")]
        Idaho,
        [EnumMember(Value = "Illinois")]
        Illinois,
        [EnumMember(Value = "Indiana")]
        Indiana,
        [EnumMember(Value = "Iowa")]
        Iowa,
        [EnumMember(Value = "Kansas")]
        Kansas,
        [EnumMember(Value = "Kentucky")]
        Kentucky,
        [EnumMember(Value = "Louisiana")]
        Louisiana,
        [EnumMember(Value = "Maine")]
        Maine,
        [EnumMember(Value = "Maryland")]
        Maryland,
        [EnumMember(Value = "Massachusetts")]
        Massachusetts,
        [EnumMember(Value = "Michigan")]
        Michigan,
        [EnumMember(Value = "Minnesota")]
        Minnesota,
        [EnumMember(Value = "Mississippi")]
        Mississippi,
        [EnumMember(Value = "Missouri")]
        Missouri,
        [EnumMember(Value = "Montana")]
        Montana,
        [EnumMember(Value = "Nebraska")]
        Nebraska,
        [EnumMember(Value = "Nevada")]
        Nevada,
        [EnumMember(Value = "New Hampshire")]
        NewHampshire,
        [EnumMember(Value = "New Jersey")]
        NewJersey,
        [EnumMember(Value = "New Mexico")]
        NewMexico,
        [EnumMember(Value = "New York")]
        NewYork,
        [EnumMember(Value = "North Carolina")]
        NorthCarolina,
        [EnumMember(Value = "North Dakota")]
        NorthDakota,
        [EnumMember(Value = "Ohio")]
        Ohio,
        [EnumMember(Value = "Oklahoma")]
        Oklahoma,
        [EnumMember(Value = "Oregon")]
        Oregon,
        [EnumMember(Value = "Pennsylvania")]
        Pennsylvania,
        [EnumMember(Value = "Rhode Island")]
        RhodeIsland,
        [EnumMember(Value = "South Carolina")]
        SouthCarolina,
        [EnumMember(Value = "South Dakota")]
        SouthDakota,
        [EnumMember(Value = "Tennessee")]
        Tennessee,
        [EnumMember(Value = "Texas")]
        Texas,
        [EnumMember(Value = "Utah")]
        Utah,
        [EnumMember(Value = "Vermont")]
        Vermont,
        [EnumMember(Value = "Virginia")]
        Virginia,
        [EnumMember(Value = "Washington")]
        Washington,
        [EnumMember(Value = "West Virginia")]
        WestVirginia,
        [EnumMember(Value = "Wisconsin")]
        Wisconsin,
        [EnumMember(Value = "Wyoming")]
        Wyoming

        #endregion
    }
}
