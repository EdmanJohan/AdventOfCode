using AoCHelper;

namespace AdventOfCode {
    public class Day_03 : BaseDay {
        [Flags]
        enum SystemType {
            OxygenGenerator = 0b_1,
            CO2Scrubber = 0b_0
        }

        private readonly List<string> _inputLines;
        private readonly int bitNumLength;

        public Day_03() {
            if (!File.Exists(InputFilePath)) {
                throw new SolvingException($"Path {InputFilePath} not found for {GetType().Name}");
            }

            _inputLines = File.ReadAllLines(InputFilePath).ToList();
            bitNumLength = _inputLines[0].Length;
        }

        public override ValueTask<string> Solve_1() {
            int? solution = null;

            var gammaBits = Enumerable.Range(0, bitNumLength)
                .Aggregate("", (str, i) => str + GetMostCommonBit(_inputLines, i, SystemType.OxygenGenerator));

            var gammaNumber = Convert.ToInt32(gammaBits, 2);
            var epsilonNumber = ~gammaNumber & 0xFFF;

            solution = gammaNumber * epsilonNumber;
            return new($"{solution.GetValueOrDefault()}");
        }

        public override ValueTask<string> Solve_2() {
            int? solution;

            var O2Rating = GetSystemRating(SystemType.OxygenGenerator, _inputLines);
            var CO2Rating = GetSystemRating(SystemType.CO2Scrubber, _inputLines);

            Console.WriteLine($"O2 Rating: {O2Rating} CO2 Rating: {CO2Rating}");
            solution = O2Rating * CO2Rating;
            return new($"{solution.GetValueOrDefault()}");
        }

        private int GetSystemRating(SystemType systemType, List<string> inputLines) {
            var bitLines = inputLines.ToList();

            for (var bitPos = 0; bitPos < bitNumLength; bitPos++) {
                var mostCommon = GetMostCommonBit(bitLines, bitPos, systemType);
                bitLines = bitLines.Where(bitLine => bitLine[bitPos] == mostCommon).ToList();

                if (bitLines.Count == 1) {
                    return Convert.ToInt32(bitLines[0], 2);
                }
            }

            return 0;

        }
        private static char GetMostCommonBit(List<string> inputLines, int bitPos, SystemType systemType) {
            var occCount = inputLines.Count(line => line[bitPos] == '1');

            return (systemType == SystemType.OxygenGenerator == 2 * occCount >= inputLines.Count) ? '1' : '0';
        }

    }
}
