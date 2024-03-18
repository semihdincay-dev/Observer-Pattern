using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
  public class WeatherData : Subject 
  {
    // ArrayList will hold the observers
    private ArrayList observers; 

    private float temperature;
    private float humidity;
    private float pressure;


    public WeatherData()
    {
      // ArrayList will hold the observers
      observers = new ArrayList();
    }

    // When an observer registers, i add it to the end of the list
    public void registerObserver(Observer o)
    {
      observers.Add(o);
    }

    // When an observer wants to un-register, here just take it off the list
    public void removeObserver(Observer o)
    {
      int i = observers.IndexOf(o);
      if (i >= 0)
      {
        observers.Remove(i);
      }
    }
    // This is where we tell all the observers about the state.
    // Because they are all Observers, we know they all implement updsate(),
    // So we know how to notify them.
    public void notifyObservers()
    {
      for (int i = 0; i < observers.Count; i++)
      {
        Observer observer = (Observer)observers[i];
        observer.update(temperature, humidity, pressure);
      }
    }
    // This one notify the Observers when we get updated measurements from the Weather Station
    public void measurementsChanged()
    {
      notifyObservers();
    }

    public void setMeasurements(float temperature, float humidty, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidty;
      this.pressure = pressure;
      measurementsChanged();
    }
  }
}
