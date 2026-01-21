using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace Moroshka.{Name}.Benchmark;

[MemoryDiagnoser]
[RankColumn]
[SuppressMessage("Performance", "CA1822")]
public class Benchmark
{
}
