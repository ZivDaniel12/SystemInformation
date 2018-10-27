using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.ViewModel
{
   
    public class MainViewModel
    {

        private PerformanceCounter cpuProccessTime = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter memoryCommittedInUse = new PerformanceCounter("Memory", "% Committed Bytes In Use", null);

        public string CPU
        {
            get { return $"{cpuProccessTime.NextValue().ToString("0.00")}%"; }
        }

        public string CPULabel
        {
            get { return $"CPU - {cpuProccessTime.CounterName}"; }
        }


        public string MemoryCommitted
        {
            get { return $"{memoryCommittedInUse.NextValue().ToString("0.00")}%"; }
        }

        public string MemoryCommittedLabel
        {
            get { return $"Memory - {memoryCommittedInUse.CounterName}"; }
        }

        public int ProccessNumber
        {
            get { return Environment.ProcessorCount; }
        }
        public string ProccessNumberLabel
        {
            get { return $"# of proccess"; }
        }
     
    }
}
