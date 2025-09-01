using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Challenges
{
    public class TwoStarTwo : IChallenge
    {


        public int Run(string filePath)
        {
            var input = FileLoaderService.LoadFile(filePath)
                        .Split("\n")
                        .Select(x => x.TrimEnd().Split(" ").Select(y => int.Parse(y)).ToArray())
                        .ToArray();

            var result = new bool[input.Length];
            
            for (int i = 0; i < input.Length; i++)
            {
                bool safety = true;
                //if (!Enumerable.SequenceEqual([.. input[i].OrderBy(x => x)], input[i]) && !Enumerable.SequenceEqual([.. input[i].OrderByDescending(x => x)], input[i]))
                //{
                //    safety = false;
                //    continue;
                //}
                for (int j = 2; j < input[i].Length; j++)
                {
                    var difference = (int a, int b) => Math.Max(input[i][j - a], input[i][j - b]) - Math.Min(input[i][j - a], input[i][j - b]);
                    
                    if ((difference(2, 1) < 1 || difference(2, 1) > 3) || input[i][j-2] > input[i][j-1])
                    {
                        if ((difference(0, 2) <= 3 && difference(0, 2) > 0) || input[i][j - 2] < input[i][j - 0])
                        {
                            continue;
                        }
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
