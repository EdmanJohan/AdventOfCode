using System;
using System.Linq;
using System.Threading.Tasks;
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
            int? solution = null;

            for (var i = 0; i < _inputNumbers.Count; i++) {
                for (var j = i + 1; j < _inputNumbers.Count; j++) {
                    if (_inputNumbers[i] + _inputNumbers[j] == 2020) {
                        return new($"{_inputNumbers[i] * _inputNumbers[j]}");
                    }
                }
            }

            return new($"{solution.GetValueOrDefault()}");
        }
        public override ValueTask<string> Solve_2() {
            int? solution = null;
            _inputNumbers.Sort();

            for (var i = 0; i < _inputNumbers.Count; i++) {
                var j = i + 1;
                int k = _inputNumbers.Count - 1;

                while (j < k) {
                    if (_inputNumbers[i] + _inputNumbers[j] + _inputNumbers[k] == 2020) {
                        return new($"{_inputNumbers[i] * _inputNumbers[j] * _inputNumbers[k]}");
                    } else if (_inputNumbers[i] + _inputNumbers[j] + _inputNumbers[k] < 2020) {
                        j++;
                    } else {
                        k--;
                    }
                }
            }

            return new($"{solution.GetValueOrDefault()}");
        }
    }
}