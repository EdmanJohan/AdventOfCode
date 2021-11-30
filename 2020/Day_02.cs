
using AoCHelper;

namespace AdventOfCode {
    public class Day_02 : BaseDay {

        private readonly string[] _inputLines;
        public Day_02() {
            if (!File.Exists(InputFilePath)) {
                throw new SolvingException($"Path {InputFilePath} not found for {GetType().Name}");
            }

            _inputLines = File.ReadAllLines(InputFilePath);
        }
        public override ValueTask<string> Solve_1() {
            int? solution = 0;
            // 1-3 a: abcde

            foreach(var line in _inputLines) {
                var splitted = line.Split(":"); // [0] - Integer rules, [1] - Password
                char passwordChar = char.Parse(splitted[0].Split(" ")[1]);
                var intLimits = splitted[0].Split(" ")[0].Split("-");
                
                _ = int.TryParse(intLimits[0], out var lowerBound);
                _ = int.TryParse(intLimits[1], out var upperBound);

                var charCount = 0;
                for (int i = 0; i < splitted[1].Length; i++) {                                       
                    /*
                    if (charCount > upperBound) {
                        break;
                    }
                    */

                    if (splitted[1][i] == passwordChar) {
                        charCount++;
                    }
                }

                if (charCount >= lowerBound && charCount <= upperBound) {
                    solution++;
                }
            }

            return new($"{solution.GetValueOrDefault()}");
        }

        public override ValueTask<string> Solve_2() {
            int? solution = 0;

            foreach(var line in _inputLines) {
                var splitted = line.Split(":"); // [0] - Integer rules, [1] - Password
                char passwordChar = char.Parse(splitted[0].Split(" ")[1]);
                var intLimits = splitted[0].Split(" ")[0].Split("-");
                
                _ = int.TryParse(intLimits[0], out var indexOne);
                _ = int.TryParse(intLimits[1], out var indexTwo);

                if (splitted[1][indexOne] == passwordChar ^ splitted[1][indexTwo] == passwordChar) {
                    solution++;
                }
            }

            return new($"{solution.GetValueOrDefault()}");
        }
    }
}