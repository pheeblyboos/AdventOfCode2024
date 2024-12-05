using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public static class GenericHelpers
    {
        public static IEnumerable<int> ExtractEntriesByCondition(List<string> input, Func<int, bool> conditionalFunc)
        {
            return input
                            .Select((value, index) => (value, index))
                            .Where(x => conditionalFunc(x.index))
                            .Select(x => int.Parse(x.value))
                            .OrderBy(x => x);
        }
    }
}
