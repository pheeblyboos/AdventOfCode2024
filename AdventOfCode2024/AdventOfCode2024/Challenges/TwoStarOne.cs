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

            var foo = input.Select((x) => x.Select((t, i) => (value: t, index: i)).Any(z => z.value - (z.index > x.Length-1 ? 0 : x[z.index + 1]) > 3 || z.value - (z.index > x.Length - 1 ? 0 : x[z.index + 1]) < -1));

            return 0;        
        }
    }
}
