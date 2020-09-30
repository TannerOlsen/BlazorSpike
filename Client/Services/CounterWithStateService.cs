using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSpike.Client.Services
{
    public class CounterWithStateService
    {
        public int Count { get; private set; }

        public void Increment()
        {
            Count++;
        }
    }
}
