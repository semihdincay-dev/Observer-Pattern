using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
  public interface Observer
  {
    public void update(float temp, float humidity, float pressure);
  }
}
