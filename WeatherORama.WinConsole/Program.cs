using System;
using WeatherORama.WinConsole.Display;

namespace WeatherORama.WinConsole
{
    internal class Program
    {
        private static void Main()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurement(10, 90, 80);
            weatherData.SetMeasurement(12, 85, 75);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}