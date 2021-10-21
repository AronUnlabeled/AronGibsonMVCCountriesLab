using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonMVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> CountryDb = new List<Country> 
            {
                new Country("USA","North America",new List<string>{"Red","White","Blue" }),
                new Country("Germany","Europe",new List<string>{"Black","Red","Yellow" }),
                new Country("Japan","Asia",new List<string>{"Red","White" })
            };


            CountryController cc = new CountryController(CountryDb);
            cc.WelcomeAction();
        }
    }
}
