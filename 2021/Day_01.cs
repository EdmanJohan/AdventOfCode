using AoCHelper;

namespace AdventOfCode {
    public class Day_01 : BaseDay {
        private readonly List<int> _inputNumbers;

        public Day_01() {
            if (!File.Exists(InputFilePath)) {
                throw new SolvingException($"Path {InputFilePath} not found for {GetType().Name}");
            }

            _inputNumbers = File.ReadAllLines(InputFilePath).Where(x => int.TryParse(x, out var tempInt)).Select(t => int.Parse(t.Trim())).ToList();
        }
        
        public override ValueTask<string> Solve_1() {
            int? solution = 0;

            int previousMeasurement = _inputNumbers[0];
            for (var i = 1; i < _inputNumbers.Count; i++) {
                var currentMeasurement = _inputNumbers[i];
                if (currentMeasurement > previousMeasurement) {
                    solution++;
                }

                previousMeasurement = currentMeasurement;
            }

            return new($"{solution.GetValueOrDefault()}");
        }

        public override ValueTask<string> Solve_2() {
            int? solution = 0;

            int previousWindow = _inputNumbers[0] + _inputNumbers[1] + _inputNumbers[2];
            for (var i = 1; i <_inputNumbers.Count - 2; i++) {
                int currentWindow = _inputNumbers[i] + _inputNumbers[i + 1] + _inputNumbers[i + 2];

                if (currentWindow > previousWindow) {
                    solution++;
                }

                previousWindow = currentWindow;
            }
            
            return new($"{solution.GetValueOrDefault()}");
        }
    }
}
