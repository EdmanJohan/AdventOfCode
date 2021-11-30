using AoCHelper;

namespace AdventOfCode {
    public class Day_0X : BaseDay {
        private readonly String _input;

        public Day_03() {
            if (!File.Exists(InputFilePath)) {
                throw new SolvingException($"Path {InputFilePath} not found for {GetType().Name}");
            }

            _input = File.ReadAllText(InputFilePath);

        }
        public override ValueTask<string> Solve_1() {
            int? solution = null;

            return new($"{solution.GetValueOrDefault()}");
        }
        public override ValueTask<string> Solve_2() {
            int? solution = null;

            return new($"{solution.GetValueOrDefault()}");
        }
    }
}