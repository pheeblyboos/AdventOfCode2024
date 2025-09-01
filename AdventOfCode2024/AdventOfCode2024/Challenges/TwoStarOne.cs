namespace AdventOfCode2024.Challenges
{
    public class TwoStarOne : IChallenge
    {
        public int Run(string filePath)
        {
            var input = FileLoaderService.LoadFile(filePath)
                                .Split("\n")
                                .Select(x => x.TrimEnd().Split(" ").Select(y => int.Parse(y)).ToArray())
                                .ToArray();

            var result = new bool[input.Length];
            //var foo = input.Select((x) => x.Select((t, i) => (value: t, index: i)).Any(z => z.value - (z.index > x.Length-1 ? 0 : x[z.index + 1]) > 3 || z.value - (z.index > x.Length - 1 ? 0 : x[z.index + 1]) < -1));
            for (int i = 0; i < input.Length; i++)
            {
                bool safety = true;
                if (!Enumerable.SequenceEqual([.. input[i].OrderBy(x => x)], input[i]) && !Enumerable.SequenceEqual([.. input[i].OrderByDescending(x => x)], input[i]))
                {
                    safety = false;
                    continue;
                }
                for (int j = 1; j < input[i].Length; j++)
                {
                    var difference = Math.Max(input[i][j], input[i][j - 1]) - Math.Min(input[i][j], input[i][j - 1]);
                    if (difference < 1 || difference > 3)
                    {
                        safety = false;
                        break;
                    }
                }

                // is safe or unsafe
                result[i] = safety;
            }

            return result.Where(x => x == true).Count();        
        }
    }
}
