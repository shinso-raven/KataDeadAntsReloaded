```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22635.2915)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method | Mean     | Error    | StdDev   | Allocated |
|------- |---------:|---------:|---------:|----------:|
| Sha256 | 41.56 μs | 0.373 μs | 0.331 μs |     112 B |
| Md5    | 17.21 μs | 0.071 μs | 0.066 μs |      80 B |
