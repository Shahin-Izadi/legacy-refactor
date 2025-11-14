using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class LoadBenchmark
{
    private readonly HttpClient _client = new() { BaseAddress = new Uri("http://localhost:5000") };

    [Benchmark(Baseline = true)]
    public async Task Legacy() => await _client.GetAsync("/LegacyWebForms/Products.aspx");

    [Benchmark]
    public async Task Modern() => await _client.GetAsync("/Products");
}