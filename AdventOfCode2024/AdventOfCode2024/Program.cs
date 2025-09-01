using AdventOfCode2024.Challenges;

namespace AdventOfCode2024
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Day<TwoStarOne>("DayTwo");
        }

        private static void Day<T>(string filePath)
        {
            var instance = Activator.CreateInstance(typeof(T));
            instance?.GetType()?.GetMethod("Run")?.Invoke(instance, [filePath]);
        }
    }
}
