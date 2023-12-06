using Contentful.Core.Models;
using System;

namespace case_study_6_michiel_van_loy.Models
{
    public class Race
    {
        public string name { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public Asset countryFlag { get; set; }
        public int length { get; set; }
        public Asset layout { get; set; }
    }
}
