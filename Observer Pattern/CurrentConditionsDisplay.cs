using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
  public class CurrentConditionsDisplay : Observer, DisplayElement
  {
    private float temperature;
    private float humidity;
    private Subject weatherData;
    // Why did i store a reference to the Subject?
    // For un-register ourselves as an observer and it would be usefull to already have a refence to the subject

    public CurrentConditionsDisplay(Subject weatherData)
    {
      this.weatherData = weatherData;
      weatherData.registerObserver(this);
    }
    public void update(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      display();
    }

    public void display()
    {
      Console.WriteLine("Current conditions: " + temperature
        + "F degrees and " + humidity + "% humidity");

    }

    
  }
}
