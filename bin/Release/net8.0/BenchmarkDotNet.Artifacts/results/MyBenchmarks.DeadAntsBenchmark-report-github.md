```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22635.2915)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | _hormigas            | Mean       | Error      | StdDev    | Allocated |
|------------- |--------------------- |-----------:|-----------:|----------:|----------:|
| **Hormigas_uno** | **...an(...)nt..t [53]** |  **70.121 ns** | **13.1191 ns** | **0.7191 ns** |         **-** |
| **Hormigas_uno** | **...a(...)t..t [106]**  | **145.971 ns** | **31.8831 ns** | **1.7476 ns** |         **-** |
| **Hormigas_uno** | **a**                    |   **1.630 ns** | **10.1216 ns** | **0.5548 ns** |         **-** |
| **Hormigas_uno** | **ant**                  |   **6.630 ns** |  **0.4317 ns** | **0.0237 ns** |         **-** |
