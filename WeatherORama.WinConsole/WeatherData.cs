using System.Collections.Generic;
using WeatherORama.WinConsole.Interface;

namespace WeatherORama.WinConsole
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private double _humidity;
        private double _pressure;
        private double _temperature;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var i = _observers.IndexOf(observer);
            if (i >= 0)
                _observers.RemoveAt(i);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurement(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}