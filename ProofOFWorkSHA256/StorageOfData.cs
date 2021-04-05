using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOFWorkSHA256
{
    public class StorageOfData
    {
        // string that we use as data
        public string Data { get; set; }
     
        public double Time { get; set; }
        // hash of data
        public string HashData { get; set; }

        public int NumberOfIterations { get; set; }
    }
}
