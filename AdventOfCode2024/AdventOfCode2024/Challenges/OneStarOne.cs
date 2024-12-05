using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Challenges
{
    public class OneStarOne : IChallenge
    {
        public int Run(string filePath)
        {
            var input = FileLoaderService.LoadFile(filePath)
                                            .Replace("   ", "\n")
                                            .Split("\n")
                                            .Select(x => x.Trim())
                                            .ToList();

            var listRowOne = GenericHelpers.ExtractEntriesByCondition(input, x => x % 2f == 0f);
            var listRowTwo = GenericHelpers.ExtractEntriesByCondition(input, x => x % 2f != 0f);

            var result = listRowOne.Zip(listRowTwo, (x, y) => Math.Abs(x - y)).Sum();
            Console.WriteLine(result);

            return result;
        }
    }
}
