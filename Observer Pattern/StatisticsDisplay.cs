using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
  public class StatisticsDisplay : Observer, DisplayElement
  {


    public void display()
    {
      throw new NotImplementedException();
    }

    public void update(float temp, float humidity, float pressure)
    {
      throw new NotImplementedException();
    }
  }
}
