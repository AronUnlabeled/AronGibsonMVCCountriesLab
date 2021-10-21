using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonMVCCountriesLab
{
    class CountryController
    {
        List<Country> CountryDb { set; get; }

        public CountryController(List<Country> CountryDb) {
            this.CountryDb = CountryDb;
        }

        public void CountryAction(Country c) {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void CountryListAction(CountryListView cl) {
            
            do {
                cl.Display();
                int index = Validate.ValidateIndex(CountryDb.Count);
                CountryAction(CountryDb[index]);

                Console.WriteLine("Would you like to learn about another country? y or n");
                string again = Validate.ValidateAgain();
                if (again == "n")
                    break;

            } while (true);
        }
        
        
        public void WelcomeAction() {
            CountryListView cl = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:" );
            CountryListAction(cl);
        }
    }
}
