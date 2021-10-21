using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonMVCCountriesLab
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string Name, string Continent, List<string> Colors) {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }
}
