using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Net.Http;
using System.Net.Http.Json;

var summary = BenchmarkRunner.Run<ProductsBenchmark>();

[MemoryDiagnoser]
public class ProductsBenchmark
{
    private readonly HttpClient _legacy = new() { BaseAddress = new("http://localhost:5001") };
    private readonly HttpClient _modern = new() { BaseAddress = new("http://localhost:5000") };

    [Benchmark(Baseline = true)]
    public async Task Legacy() => await _legacy.GetStringAsync("/Products.aspx");

    [Benchmark]
    public async Task Modern() => await _modern.GetStringAsync("/Products");
}