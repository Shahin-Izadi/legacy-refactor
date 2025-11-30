using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Net.Http;
using System.Net.Http.Json;

var summary = BenchmarkRunner.Run<ProductsBenchmark>();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

[MemoryDiagnoser]
public class ProductsBenchmark
{
    
    //dear github users . if the performance demo is failing its most likely due to wrong ports 
    //being given in the next two lines . To fix , run the legacy and the mordern projects and
    //paste their http ports in place of the ones im using 
    private readonly HttpClient _legacy = new() { BaseAddress = new("http://localhost:5001") };
    private readonly HttpClient _modern = new() { BaseAddress = new("http://localhost:5145") };

    [Benchmark(Baseline = true)]
    public async Task Legacy() => await _legacy.GetStringAsync("/Products.aspx");

    [Benchmark]
    public async Task Modern() => await _modern.GetStringAsync("/Products");


}