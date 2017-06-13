﻿namespace WeatherORama.WinConsole.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver(IObserver observer);
    }
}