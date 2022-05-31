using System;

namespace ExcelGosti
{
    public static class ColumnNames
    {
        public static string NightPriceSumColumnName { get => "Cijena Noćenja ((Br. Racuna) |||| Br. Gosti * Br. noćenja * Cijena noći)"; }
        public static string NameSurnameColumnName { get => "Prezime i ime"; }
        public static string DateOfArrivalColumnName { get => "Datum vrijeme dolaska"; }
        public static string DateOfDepartureColumnName { get => "Datum vrijeme odlaska"; }
        public static string NightsStayedColumnName { get => "Noćenja"; }

        public static CustomValueType[] AllColumnNames
        {
            get => new CustomValueType[]
          {
              new CustomValueType(){Value = NameSurnameColumnName, Type = typeof(string)},
              new CustomValueType(){Value = DateOfArrivalColumnName, Type = typeof(DateTime)},
              new CustomValueType(){Value = DateOfDepartureColumnName, Type = typeof(DateTime)},
              new CustomValueType(){Value = NightsStayedColumnName, Type = typeof(int)},
          };
        }

        public class CustomValueType
        {
            public string Value { get; set; }
            public Type Type { get; set; }
        }
    }
}
