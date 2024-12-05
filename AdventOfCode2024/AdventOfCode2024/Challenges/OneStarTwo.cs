using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Challenges
{
    public class OneStarTwo : IChallenge
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

            var occurrenceMapping = listRowTwo.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return listRowOne.Select(x => occurrenceMapping.ContainsKey(x) ? x * occurrenceMapping[x] : 0).Sum();
        }
    }
}
