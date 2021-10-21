using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonMVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry) {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {
            Console.WriteLine("Name: "+DisplayCountry.Name);
            Console.WriteLine("Continent: "+DisplayCountry.Continent);
            Console.WriteLine("Colors: ");
            foreach (string c in DisplayCountry.Colors)
                Console.WriteLine(c);
        }

    }
}
