using Newtonsoft.Json.Linq;
using System;

namespace WeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string myKey = File.ReadAllText("appsettings.json");
            string APIKey = (string)JObject.Parse(myKey).GetValue("APIKey").ToString();

            Console.WriteLine("Please Enter Your Zip Code");
            var cityName = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={APIKey}";

            Console.WriteLine("--------");

            Console.WriteLine($"It's currently {WeatherMap.MyTemp(apiCall)} degrees Farenheit in your location");
        }
    }
}
