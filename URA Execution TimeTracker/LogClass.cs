using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace URA_Execution_TimeTracker
{
    public class LogDTO
    {

        public Guid id { get; set; }
        public long ExecutionTime { get; set; }
        public string AlgorithmName{ get; set; }
        public  string OS { get; set; }
        public string CPU_IDENTIFIER { get; set; }
        public string CPU_PROCESSORS { get; set; }
        public int NoProcessors { get; set; }
        public int[] inputArray { get; set; }
    }
}
