# Benchmarks

```bash {linenos=false}
// * Detailed results *
Benchmarks.E0: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 43.538 ns, StdErr = 0.134 ns (0.31%), N = 15, StdDev = 0.520 ns
Min = 42.885 ns, Q1 = 43.056 ns, Median = 43.526 ns, Q3 = 43.913 ns, Max = 44.548 ns
IQR = 0.858 ns, LowerFence = 41.769 ns, UpperFence = 45.200 ns
ConfidenceInterval = [42.982 ns; 44.094 ns] (CI 99.9%), Margin = 0.556 ns (1.28% of Mean)
Skewness = 0.44, Kurtosis = 1.82, MValue = 2
-------------------- Histogram --------------------
[42.855 ns ; 44.825 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.E1: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 127.640 ns, StdErr = 0.342 ns (0.27%), N = 15, StdDev = 1.326 ns
Min = 125.443 ns, Q1 = 126.740 ns, Median = 127.558 ns, Q3 = 128.505 ns, Max = 130.549 ns
IQR = 1.766 ns, LowerFence = 124.091 ns, UpperFence = 131.154 ns
ConfidenceInterval = [126.222 ns; 129.058 ns] (CI 99.9%), Margin = 1.418 ns (1.11% of Mean)
Skewness = 0.42, Kurtosis = 2.49, MValue = 2
-------------------- Histogram --------------------
[124.738 ns ; 128.415 ns) | @@@@@@@@@@@
[128.415 ns ; 131.255 ns) | @@@@
---------------------------------------------------

Benchmarks.E2: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 146.952 ns, StdErr = 2.408 ns (1.64%), N = 100, StdDev = 24.079 ns
Min = 118.193 ns, Q1 = 120.620 ns, Median = 162.361 ns, Q3 = 166.336 ns, Max = 229.939 ns
IQR = 45.716 ns, LowerFence = 52.046 ns, UpperFence = 234.909 ns
ConfidenceInterval = [138.786 ns; 155.119 ns] (CI 99.9%), Margin = 8.166 ns (5.56% of Mean)
Skewness = 0.14, Kurtosis = 2.28, MValue = 3.64
-------------------- Histogram --------------------
[117.340 ns ; 130.958 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[130.958 ns ; 144.576 ns) |
[144.576 ns ; 159.761 ns) |
[159.761 ns ; 173.378 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[173.378 ns ; 186.996 ns) |
[186.996 ns ; 200.614 ns) |
[200.614 ns ; 214.231 ns) |
[214.231 ns ; 223.130 ns) |
[223.130 ns ; 236.748 ns) | @
---------------------------------------------------

Benchmarks.E0d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 37.637 ns, StdErr = 0.080 ns (0.21%), N = 13, StdDev = 0.289 ns
Min = 37.240 ns, Q1 = 37.451 ns, Median = 37.676 ns, Q3 = 37.794 ns, Max = 38.248 ns
IQR = 0.343 ns, LowerFence = 36.937 ns, UpperFence = 38.308 ns
ConfidenceInterval = [37.292 ns; 37.983 ns] (CI 99.9%), Margin = 0.346 ns (0.92% of Mean)
Skewness = 0.43, Kurtosis = 2.29, MValue = 2
-------------------- Histogram --------------------
[37.205 ns ; 38.409 ns) | @@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.E1d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 93.791 ns, StdErr = 0.256 ns (0.27%), N = 15, StdDev = 0.992 ns
Min = 92.505 ns, Q1 = 93.033 ns, Median = 93.562 ns, Q3 = 94.768 ns, Max = 95.404 ns
IQR = 1.735 ns, LowerFence = 90.429 ns, UpperFence = 97.371 ns
ConfidenceInterval = [92.731 ns; 94.851 ns] (CI 99.9%), Margin = 1.060 ns (1.13% of Mean)
Skewness = 0.3, Kurtosis = 1.38, MValue = 2
-------------------- Histogram --------------------
[92.160 ns ; 95.931 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.E2d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 155.544 ns, StdErr = 0.821 ns (0.53%), N = 26, StdDev = 4.186 ns
Min = 136.503 ns, Q1 = 154.648 ns, Median = 156.191 ns, Q3 = 157.722 ns, Max = 158.932 ns
IQR = 3.075 ns, LowerFence = 150.036 ns, UpperFence = 162.334 ns
ConfidenceInterval = [152.486 ns; 158.602 ns] (CI 99.9%), Margin = 3.058 ns (1.97% of Mean)
Skewness = -3.53, Kurtosis = 16.54, MValue = 2
-------------------- Histogram --------------------
[134.648 ns ; 138.357 ns) | @
[138.357 ns ; 142.066 ns) |
[142.066 ns ; 145.775 ns) |
[145.775 ns ; 149.484 ns) |
[149.484 ns ; 154.238 ns) | @
[154.238 ns ; 160.787 ns) | @@@@@@@@@@@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg0: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 9.802 ns, StdErr = 0.020 ns (0.21%), N = 14, StdDev = 0.076 ns
Min = 9.720 ns, Q1 = 9.745 ns, Median = 9.773 ns, Q3 = 9.845 ns, Max = 9.995 ns
IQR = 0.100 ns, LowerFence = 9.595 ns, UpperFence = 9.996 ns
ConfidenceInterval = [9.716 ns; 9.888 ns] (CI 99.9%), Margin = 0.086 ns (0.88% of Mean)
Skewness = 1.03, Kurtosis = 3.31, MValue = 2
-------------------- Histogram --------------------
[9.678 ns ; 10.037 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg1: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 9.686 ns, StdErr = 0.021 ns (0.21%), N = 15, StdDev = 0.080 ns
Min = 9.574 ns, Q1 = 9.607 ns, Median = 9.705 ns, Q3 = 9.748 ns, Max = 9.807 ns
IQR = 0.141 ns, LowerFence = 9.396 ns, UpperFence = 9.959 ns
ConfidenceInterval = [9.600 ns; 9.772 ns] (CI 99.9%), Margin = 0.086 ns (0.89% of Mean)
Skewness = 0.04, Kurtosis = 1.37, MValue = 2
-------------------- Histogram --------------------
[9.531 ns ; 9.850 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg2: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 10.020 ns, StdErr = 0.039 ns (0.39%), N = 15, StdDev = 0.151 ns
Min = 9.878 ns, Q1 = 9.918 ns, Median = 9.952 ns, Q3 = 10.091 ns, Max = 10.300 ns
IQR = 0.174 ns, LowerFence = 9.657 ns, UpperFence = 10.352 ns
ConfidenceInterval = [9.858 ns; 10.181 ns] (CI 99.9%), Margin = 0.161 ns (1.61% of Mean)
Skewness = 0.89, Kurtosis = 2.1, MValue = 2
-------------------- Histogram --------------------
[9.859 ns ; 10.325 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg0d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 9.866 ns, StdErr = 0.025 ns (0.25%), N = 14, StdDev = 0.093 ns
Min = 9.743 ns, Q1 = 9.786 ns, Median = 9.866 ns, Q3 = 9.903 ns, Max = 10.048 ns
IQR = 0.117 ns, LowerFence = 9.610 ns, UpperFence = 10.080 ns
ConfidenceInterval = [9.762 ns; 9.971 ns] (CI 99.9%), Margin = 0.105 ns (1.06% of Mean)
Skewness = 0.47, Kurtosis = 2.2, MValue = 2
-------------------- Histogram --------------------
[9.692 ns ; 10.098 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg1d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 9.744 ns, StdErr = 0.032 ns (0.33%), N = 15, StdDev = 0.126 ns
Min = 9.618 ns, Q1 = 9.644 ns, Median = 9.704 ns, Q3 = 9.853 ns, Max = 9.978 ns
IQR = 0.209 ns, LowerFence = 9.331 ns, UpperFence = 10.166 ns
ConfidenceInterval = [9.610 ns; 9.878 ns] (CI 99.9%), Margin = 0.134 ns (1.38% of Mean)
Skewness = 0.62, Kurtosis = 1.68, MValue = 2
-------------------- Histogram --------------------
[9.572 ns ; 10.032 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

Benchmarks.Sg2d: DefaultJob
Runtime = .NET 7.0.0 (7.0.22.51805), X64 RyuJIT; GC = Concurrent Workstation
Mean = 6.534 ns, StdErr = 0.040 ns (0.62%), N = 15, StdDev = 0.156 ns
Min = 6.372 ns, Q1 = 6.428 ns, Median = 6.460 ns, Q3 = 6.652 ns, Max = 6.883 ns
IQR = 0.223 ns, LowerFence = 6.093 ns, UpperFence = 6.987 ns
ConfidenceInterval = [6.367 ns; 6.701 ns] (CI 99.9%), Margin = 0.167 ns (2.56% of Mean)
Skewness = 0.88, Kurtosis = 2.29, MValue = 2
-------------------- Histogram --------------------
[6.346 ns ; 6.513 ns) | @@@@@@@@@@
[6.513 ns ; 6.774 ns) | @@@@
[6.774 ns ; 6.966 ns) | @
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2364 (21H2)
Intel Core i7-3632QM CPU 2.20GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


| Method |       Mean |     Error |     StdDev |     Median |  Gen 0 | Allocated |
|------- |-----------:|----------:|-----------:|-----------:|-------:|----------:|
|     E0 |  43.538 ns | 0.5560 ns |  0.5201 ns |  43.526 ns |      - |         - |
|     E1 | 127.640 ns | 1.4176 ns |  1.3260 ns | 127.558 ns | 0.0178 |      56 B |
|     E2 | 146.952 ns | 8.1665 ns | 24.0790 ns | 162.361 ns | 0.0279 |      88 B |
|    E0d |  37.637 ns | 0.3457 ns |  0.2887 ns |  37.676 ns |      - |         - |
|    E1d |  93.791 ns | 1.0600 ns |  0.9916 ns |  93.562 ns | 0.0178 |      56 B |
|    E2d | 155.544 ns | 3.0579 ns |  4.1857 ns | 156.191 ns | 0.0280 |      88 B |
|    Sg0 |   9.802 ns | 0.0858 ns |  0.0761 ns |   9.773 ns |      - |         - |
|    Sg1 |   9.686 ns | 0.0859 ns |  0.0804 ns |   9.705 ns |      - |         - |
|    Sg2 |  10.020 ns | 0.1613 ns |  0.1509 ns |   9.952 ns |      - |         - |
|   Sg0d |   9.866 ns | 0.1048 ns |  0.0929 ns |   9.866 ns |      - |         - |
|   Sg1d |   9.744 ns | 0.1343 ns |  0.1256 ns |   9.704 ns |      - |         - |
|   Sg2d |   6.534 ns | 0.1671 ns |  0.1563 ns |   6.460 ns |      - |         - |

// * Warnings *
MultimodalDistribution
  Benchmarks.E2: Default -> It seems that the distribution is bimodal (mValue = 3.64)

// * Hints *
Outliers
  Benchmarks.E0d: Default  -> 2 outliers were removed (41.61 ns, 42.07 ns)
  Benchmarks.E2d: Default  -> 1 outlier  was  detected (138.88 ns)
  Benchmarks.Sg0: Default  -> 1 outlier  was  removed (13.11 ns)
  Benchmarks.Sg0d: Default -> 1 outlier  was  removed (13.10 ns)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Gen 0     : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
// ** Remained 0 benchmark(s) to run **
Run time: 00:06:17 (377.77 sec), executed benchmarks: 12

Global total time: 00:06:44 (404.49 sec), executed benchmarks: 12
// * Artifacts cleanup *
```