# Advent of Code 
The one repository for all the years! (is the ambition at least...).  
Trying to make my way through [C# 10 and .NET 6](https://isbnsearch.org/isbn/9781801077361) and learn as this goes along.

### Requirements
Requires: [dotnet 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)

### Basic usage
In the main directory: `dotnet restore`  
Then enter a year subdirectory and run: `dotnet run -c release {all}`

### Statistics
Because data is nice.

#### 🎄 2021 Statistics 🎄
```
╭───────┬──────────┬─────────────┬──────────────╮
│ Day   │ Part     │ Solution    │ Elapsed time │
├───────┼──────────┼─────────────┼──────────────┤
│ Day 1 │ Day_01() │ ----------- │ 2 ms         │
│ Day 1 │ Part 1   │ 1233        │ 0,48 ms      │
│ Day 1 │ Part 2   │ 1275        │ 0,54 ms      │
│ Day 1 │ Total    │ ----------- │ 3 ms         │
│       │          │             │              │
│ Day 2 │ Day_02() │ ----------- │ 0,29 ms      │
│ Day 2 │ Part 1   │ 1561344     │ 0,88 ms      │
│ Day 2 │ Part 2   │ 1848454425  │ 0,83 ms      │
│ Day 2 │ Total    │ ----------- │ 2 ms         │
│       │          │             │              │
╰───────┴──────────┴─────────────┴──────────────╯
┌─────── Overall results ───────┐
│                               │
│ Total (2 days)        5 ms    │
│ Total constructors    3 ms    │
│ Total parts 1         1 ms    │
│ Total parts 2         1 ms    │
│                               │
│ Mean (per day)        3 ms    │
│ Mean constructors     1 ms    │
│ Mean parts 1          0,68 ms │
│ Mean parts 2          0,68 ms │
└───────────────────────────────┘
```

#### Acknowledgements
Shoutout to these awesome projects that this repository uses, which make the dabbling around in C# easier and quicker,  
✨ [AoCHelper](https://github.com/eduherminio/AoCHelper)  
✨ [AdventOfCode.Template](https://github.com/eduherminio/AdventOfCode.Template)  




