using AoCHelper;

namespace AdventOfCode {
    public class Day_02 : BaseDay {
        private readonly List<string> _inputLines;

        public Day_02() {
            if (!File.Exists(InputFilePath)) {
                throw new SolvingException($"Path {InputFilePath} not found for {GetType().Name}");
            }

            _inputLines = File.ReadAllLines(InputFilePath).ToList();
        }

        public override ValueTask<string> Solve_1() {
            int? solution = 0;
            int x = 0;
            int y = 0;

            foreach (var inputLine in _inputLines) {
                var command = inputLine.Split(' ');
                _ = int.TryParse(command[1], out var speed);

                switch (command[0]) {
                    case "forward":
                        x += speed;
                        break;
                    case "down":
                        y += speed;
                        break;
                    case "up":
                        y -= speed;
                        break;
                    default:
                        continue;
                }
            }

            solution = x * y;
            return new($"{solution.GetValueOrDefault()}");
        }

        public override ValueTask<string> Solve_2() {
            int? solution = 0;

            int x = 0;
            int y = 0;
            int aim = 0;

            foreach (var inputLine in _inputLines) {
                var command = inputLine.Split(' ');
                _ = int.TryParse(command[1], out var speed);

                switch (command[0]) {
                    case "forward":
                        x += speed;
                        y += aim * speed;
                        break;
                    case "down":
                        aim += speed;
                        break;
                    case "up":
                        aim -= speed;
                        break;
                    default:
                        continue;
                }
            }

            solution = x * y;
            return new($"{solution.GetValueOrDefault()}");
        }
    }
}
