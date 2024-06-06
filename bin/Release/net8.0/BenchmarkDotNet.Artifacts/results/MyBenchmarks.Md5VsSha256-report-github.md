```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22635.2915)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method           | Mean          | Error      | StdDev     | Allocated |
|----------------- |--------------:|-----------:|-----------:|----------:|
| Hormigas_uno     |     70.827 ns |  1.1603 ns |  1.5882 ns |         - |
| Hormigas_uno_dos |      1.035 ns |  0.0101 ns |  0.0085 ns |         - |
| Hormigas_uno_tre |      7.205 ns |  0.0348 ns |  0.0290 ns |         - |
| Md5              | 17,197.893 ns | 47.9674 ns | 44.8687 ns |      80 B |
