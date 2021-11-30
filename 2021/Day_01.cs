using System;
using AoCHelper;

namespace AdventOfCode {
    public class Day_01 : BaseDay {
        private readonly string _input;

        public Day_01() {
            _input = File.ReadAllText(InputFilePath);
        }

        public override ValueTask<string> Solve_1() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 1");

        public override async ValueTask<string> Solve_2() => new();

        private async Task<string> CalculateIndex() {
            await Task.Delay(200);
            return "Solution 2";
        }


    }
}
