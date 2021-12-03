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
│ Day 1 │ Part 2   │ 1275        │ 0,53 ms      │
│ Day 1 │ Total    │ ----------- │ 3 ms         │
│       │          │             │              │
│ Day 2 │ Day_02() │ ----------- │ 0,27 ms      │
│ Day 2 │ Part 1   │ 1561344     │ 0,98 ms      │
│ Day 2 │ Part 2   │ 1848454425  │ 0,85 ms      │
│ Day 2 │ Total    │ ----------- │ 2 ms         │
│       │          │             │              │
│ Day 3 │ Day_03() │ ----------- │ 0,21 ms      │
│ Day 3 │ Part 1   │ 3882564     │ 0,67 ms      │
│ Day 3 │ Part 2   │ 3385170     │ 0,73 ms      │
│ Day 3 │ Total    │ ----------- │ 2 ms         │
│       │          │             │              │
╰───────┴──────────┴─────────────┴──────────────╯
┌─────── Overall results ───────┐
│                               │
│ Total (3 days)        7 ms    │
│ Total constructors    3 ms    │
│ Total parts 1         2 ms    │
│ Total parts 2         2 ms    │
│                               │
│ Mean (per day)        2 ms    │
│ Mean constructors     0,94 ms │
│ Mean parts 1          0,71 ms │
│ Mean parts 2          0,71 ms │
└───────────────────────────────┘
```

#### Acknowledgements
Shoutout to these awesome projects that this repository uses, which make the dabbling around in C# easier and quicker,  
✨ [AoCHelper](https://github.com/eduherminio/AoCHelper)  
✨ [AdventOfCode.Template](https://github.com/eduherminio/AdventOfCode.Template)  




