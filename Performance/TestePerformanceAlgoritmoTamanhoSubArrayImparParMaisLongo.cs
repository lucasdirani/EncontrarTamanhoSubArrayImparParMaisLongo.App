using BenchmarkDotNet.Attributes;
using EncontrarTamanhoSubArrayImparParMaisLongo.App.Algoritmos;

namespace EncontrarTamanhoSubArrayImparParMaisLongo.App.Performance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TestePerformanceAlgoritmoTamanhoSubArrayImparParMaisLongo
    {
        [Params(
            new int[] { 1, 2, 3, 4, 5, 7, 9, 11, 6, 15 },
            new int[] { 74, 94, 4, 60, 76, 72, 70, 17, 14, 66, 28, 65, 69, 12, 10, 68, 82, 89, 1, 15, 51, 11, 8, 21, 49, 56, 59, 54, 50, 81, 53, 79, 31, 96, 63, 88, 23, 2, 93, 55, 91, 27, 37, 78, 97, 84, 83, 90, 16, 99 },
            new int[] { 55, 53, 82, 27, 28, 87, 91, 15, 11, 43, 23, 9, 75, 18, 36, 7, 3, 54, 25, 73, 77, 71, 8, 52, 50, 94, 51, 97, 66, 69, 2, 70, 38, 89, 68, 19, 78, 42, 35, 20, 58, 12, 63, 33, 14, 34, 44, 90, 47, 40, 46, 48, 45, 39, 81, 31, 100, 74, 64, 4, 59, 29, 5, 62, 95, 22, 60, 92, 37, 49, 72, 1, 24, 93, 86, 13, 67, 80, 16, 56, 85, 41, 6, 98, 83, 30, 99, 21, 10, 84, 57, 17, 88, 76, 96, 65, 61, 79, 26, 32 },
            new int[] { 85, 47, 97, 10, 67, 30, 50, 23, 88, 91, 34, 57, 29, 19, 51, 27, 11, 1, 18, 71, 81, 61, 43, 80, 89, 65, 19, 43, 66, 33, 89, 28, 99, 36, 35, 94, 77, 56, 11, 99, 8, 62, 30, 18, 38, 31, 75, 58, 19, 13, 62, 93, 55, 66, 44, 92, 58, 88, 34, 80, 37, 73, 16, 86, 76, 57, 6, 13, 26, 8, 46, 98, 61, 33, 71, 83, 70, 53, 21, 57, 34, 70, 84, 72, 75, 52, 93, 8, 38, 89, 14, 78, 26, 6, 15, 59, 61, 95, 54, 1, 47, 84, 83, 11, 15, 70, 67, 58, 50, 77, 48, 86, 18, 4, 84, 62, 38, 27, 41, 68, 46, 12, 18, 93, 55, 72, 24, 17, 37, 25, 7, 36, 65, 5, 63, 32, 91, 23, 36, 96, 43, 81, 70, 60, 87, 53, 20, 20, 23, 68, 32, 46, 48, 8, 73, 26, 59, 12, 62, 17, 89, 68, 82, 31, 37, 68, 41, 14, 65, 93, 86, 18, 100, 22, 75, 36, 17, 46, 42, 63, 33, 40, 8, 36, 39, 97, 53, 29, 43, 6, 67, 73, 2, 40, 49, 30, 88, 81, 92, 25 })]
        public int[] Array { get; set; }

        [Benchmark]
        public void MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo()
        {
            _ = AlgoritmoTamanhoSubArrayImparParMaisLongo.EncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo(Array, Array.Length);
        }

        [Benchmark]
        public void MedirPerformanceEncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo()
        {
            _ = AlgoritmoTamanhoSubArrayImparParMaisLongo.EncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo(Array, Array.Length);
        }
    }
}