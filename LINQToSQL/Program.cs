using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
internal record Country(string name_country, string name_capital, int number, float area, string part)
{

}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Country> countries = GetCountriesData();

        DisplayAllCountriesInfo(countries);
        DisplayCountryNames(countries);
        DisplayCapitalNames(countries);
        DisplayEuropeanCountries(countries);
        DisplayLargeCountries(countries);
        DisplayCountriesWithAU(countries);
        DisplayCountriesWithLetterA(countries);
        DisplayMiddleSizedCountries(countries);
        DisplayPopulousCountries(countries);
        DisplayTop5CountriesByArea(countries);
        DisplayTop5CountriesByPopulation(countries);
        DisplayLargestCountryByArea(countries);
        DisplayLargestCountryByPopulation(countries);
        DisplaySmallestCountryInAfrica(countries);
        DisplayAverageAreaInAsia(countries);
    }

    private static List<Country> GetCountriesData()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Country india = new Country("India", "New Delhi", 1393409038, 3287263, "Asia");
        Country france = new Country("France", "Paris", 67406000, 551695, "Europe");
        Country germany = new Country("Germany", "Berlin", 83190556, 357022, "Europe");
        Country brazil = new Country("Brazil", "Brasilia", 213993437, 8515767, "South America");
        Country moldova = new Country("Moldova", "Chisinau", 3550900, 33846, "Europe");
        Country ukraine = new Country("Ukraine", "Kyiv", 41167300, 603628, "Europe");
        Country canada = new Country("Canada", "Ottawa", 38067906, 9984670, "North America");
        Country japan = new Country("Japan", "Tokyo", 125584838, 377975, "Asia");
        Country australia = new Country("Australia", "Canberra", 25788221, 7692024, "Oceania");
        Country egypt = new Country("Egypt", "Cairo", 104258327, 1002450, "Africa");
        Country iran = new Country("Iran", "Tehran", 1648000, 78408412, "Asia");
        return new List<Country> { india, france, germany, brazil, moldova, ukraine, canada, japan, australia, egypt, iran };
    }

    private static void DisplayAllCountriesInfo(List<Country> countries)
    {
        Console.WriteLine("Вся інформація про країни:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", "Назва країни", "Назва столиці", "Населення", "Площа", "Частина світу");
        Console.WriteLine();
        foreach (var country in countries)
        {
            Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", country.name_country, country.name_capital, country.number, country.area, country.part);
        }
        Console.WriteLine();
    }

    private static void DisplayCountryNames(List<Country> countries)
    {
        Console.WriteLine("Назви країн:");
        Console.WriteLine();
        foreach (var country in countries)
        {
            Console.WriteLine(country.name_country);
        }
        Console.WriteLine();
    }

    private static void DisplayCapitalNames(List<Country> countries)
    {
        Console.WriteLine("Назви столиць:");
        Console.WriteLine();
        foreach (var country in countries)
        {
            Console.WriteLine(country.name_capital);
        }
        Console.WriteLine();
    }

    private static void DisplayEuropeanCountries(List<Country> countries)
    {
        Console.WriteLine("Назви європейських країн:");
        Console.WriteLine();
        var EuropeCountries = countries.Where(c => c.part == "Europe");
        foreach (var country in EuropeCountries)
        {
            Console.WriteLine(country.name_country);
        }
        Console.WriteLine();
    }

    private static void DisplayLargeCountries(List<Country> countries)
    {
        Console.WriteLine("Назви країн, площа яких більше 1000000:");
        Console.WriteLine();
        var LargeCountries = countries.Where(c => c.area > 1000000);
        foreach (var country in LargeCountries)
        {
            Console.WriteLine(country.name_country);
        }
        Console.WriteLine();
    }

    private static void DisplayCountriesWithAU(List<Country> countries)
    {
        Console.WriteLine("Країни, в назвах яких є літери ‘a’ та ‘u’:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", "Назва країни", "Назва столиці", "Населення", "Площа", "Частина світу");
        Console.WriteLine();
        var AUContries = countries.Where(c => c.name_country.ToLower().Contains("a") && c.name_country.ToLower().Contains("u"));
        foreach (var country in AUContries)
        {
            Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", country.name_country, country.name_capital, country.number, country.area, country.part);
        }
        Console.WriteLine();
    }

    private static void DisplayCountriesWithLetterA(List<Country> countries)
    {
        Console.WriteLine("Країни, в назвах яких є літера ‘a’:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", "Назва країни", "Назва столиці", "Населення", "Площа", "Частина світу");
        Console.WriteLine();
        var AContries = countries.Where(c => c.name_country.ToLower().Contains("a"));
        foreach (var country in AContries)
        {
            Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-15} {4,-15}", country.name_country, country.name_capital, country.number, country.area, country.part);
        }
        Console.WriteLine();
    }

    private static void DisplayMiddleSizedCountries(List<Country> countries)
    {
        Console.WriteLine("Назви країн, площа яких в діапазоні 50 тис - 1 млн:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "Назва країни", "Площа");
        Console.WriteLine();
        var MidleCountries = countries.Where(c => c.area < 1000000 && c.area > 500000);
        foreach (var country in MidleCountries)
        {
            Console.WriteLine("{0,-25} {1,-20}", country.name_country, country.area);
        }
        Console.WriteLine();
    }

    private static void DisplayPopulousCountries(List<Country> countries)
    {
        Console.WriteLine("Назви країн, в яких населення більше 1 мільярда:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "Назва країни", "Населення");
        Console.WriteLine();
        var PopularCountries = countries.Where(c => c.number > 1000000000);
        foreach (var country in PopularCountries)
        {
            Console.WriteLine("{0,-28} {1}", country.name_country, country.number);
        }
        Console.WriteLine();
    }

    private static void DisplayTop5CountriesByArea(List<Country> countries)
    {
        Console.WriteLine("Топ-5 країни за площею:");
        Console.WriteLine();
        Console.WriteLine("{0,-28} {1}", "   Назва країни", "Площа");
        Console.WriteLine();
        var TheLargestCountries = countries.OrderByDescending(c => c.area).ToList();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}. {1,-28} {2}", i + 1, TheLargestCountries[i].name_country, TheLargestCountries[i].area);
        }
        Console.WriteLine();
    }

    private static void DisplayTop5CountriesByPopulation(List<Country> countries)
    {
        Console.WriteLine("Топ-5 країни за населенням:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "   Назва країни", "Населення");
        Console.WriteLine();
        var TheMostPopularCountries = countries.OrderByDescending(c => c.number).ToList();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}. {1,-25} {2,-20}", i + 1, TheMostPopularCountries[i].name_country, TheMostPopularCountries[i].number);
        }
        Console.WriteLine();
    }

    private static void DisplayLargestCountryByArea(List<Country> countries)
    {
        var TheLargestCountries = countries.OrderByDescending(c => c.number).ToList();
        Console.WriteLine("Найбільша країна за площею:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "Назва країни", "Площа");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", TheLargestCountries[0].name_country, TheLargestCountries[0].area);
        Console.WriteLine();
    }

    private static void DisplayLargestCountryByPopulation(List<Country> countries)
    {
        var TheMostPopularCountries = countries.OrderByDescending(c => c.number).ToList();
        Console.WriteLine("Найбільша країна за населенням:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "Назва країни", "Населення");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", TheMostPopularCountries[0].name_country, TheMostPopularCountries[0].number);
        Console.WriteLine();
    }

    private static void DisplaySmallestCountryInAfrica(List<Country> countries)
    {
        Console.WriteLine("Країна з найменшою площею в Африці:");
        Console.WriteLine();
        Console.WriteLine("{0,-25} {1,-20}", "Назва країни", "Площа");
        Console.WriteLine();
        var TheSmallestCountryInAfrika = countries.OrderBy(c => c.area).Where(c => c.part == "Africa").ToList();
        Console.WriteLine("{0,-25} {1,-20}", TheSmallestCountryInAfrika[0].name_country, TheSmallestCountryInAfrika[0].area);
        Console.WriteLine();
    }

    private static void DisplayAverageAreaInAsia(List<Country> countries)
    {
        var AverageAreaInAsia = countries.Where(c => c.part == "Asia").Average(c => c.area);
        Console.WriteLine("Cередня площа країн в Азії: " + AverageAreaInAsia);
    }
}

