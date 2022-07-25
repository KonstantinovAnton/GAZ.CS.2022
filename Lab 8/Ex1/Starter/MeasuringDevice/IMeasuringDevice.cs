using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    // TODO: Implement the IMeasuringDevice interface.
    public interface IMeasuringDevice
    {
        decimal MetricValue();

        decimal ImperialValue();

        void StartCollecting();

        int[] GetRawData();
    }
}
