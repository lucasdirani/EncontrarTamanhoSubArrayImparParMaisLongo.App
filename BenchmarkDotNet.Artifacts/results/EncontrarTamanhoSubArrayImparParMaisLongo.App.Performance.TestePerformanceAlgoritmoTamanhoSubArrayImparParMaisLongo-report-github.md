``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3208/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                                                   Method |      Array |      Mean |     Error |    StdDev | Rank | Allocated |
|----------------------------------------------------------------------------------------- |----------- |----------:|----------:|----------:|-----:|----------:|
| **MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo** | **Int32[100]** | **380.24 ns** |  **7.525 ns** |  **8.666 ns** |    **6** |         **-** |
|     MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo | Int32[100] | 214.49 ns |  4.307 ns |  7.196 ns |    5 |         - |
| **MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo** |  **Int32[10]** |  **40.20 ns** |  **0.520 ns** |  **0.434 ns** |    **2** |         **-** |
|     MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo |  Int32[10] |  20.80 ns |  0.413 ns |  0.345 ns |    1 |         - |
| **MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo** | **Int32[200]** | **750.02 ns** | **14.840 ns** | **17.090 ns** |    **8** |         **-** |
|     MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo | Int32[200] | 438.82 ns |  8.813 ns |  9.796 ns |    7 |         - |
| **MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo** |  **Int32[50]** | **195.11 ns** |  **2.758 ns** |  **2.579 ns** |    **4** |         **-** |
|     MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo |  Int32[50] | 105.74 ns |  1.574 ns |  1.314 ns |    3 |         - |
