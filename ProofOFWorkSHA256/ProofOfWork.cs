using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProofOFWorkSHA256
{
    public class ProofOfWork
    {
        public static StorageOfData StartProofOfWork(string testData, int startingZeros)
        {
            var resultData = new StorageOfData();

            // startingZeros - number of starting zero bits resulting SHA256 block hash should contain
            var expectedResult = new string('0', startingZeros);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            resultData.HashData = string.Empty;
            while (true)
            {
                if (stopwatch.Elapsed.TotalSeconds > 5)
                {
                    MessageBox.Show("Too hard to find hash with that count of zero bits");
                    break;
                }
                if ((!resultData.HashData.StartsWith(expectedResult)))
                {
                    resultData.NumberOfIterations++;
                    resultData.Data = testData + RandomStringGenerator.GenerateByLen(10);
                    resultData.HashData = HashOperations.GenerateSha256String(resultData.Data);
                    resultData.Time = stopwatch.Elapsed.TotalSeconds;
                }
                else
                {
                    break;
                }
            }
            resultData.Time = stopwatch.Elapsed.TotalSeconds;
            return resultData;
        }
    }
}
