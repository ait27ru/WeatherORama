using System;
using WeatherORama.WinConsole.Interface;

namespace WeatherORama.WinConsole.Display
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;
        private double _humidity;
        private double _temperature;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}°C degrees and {_humidity}% humidity.");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}