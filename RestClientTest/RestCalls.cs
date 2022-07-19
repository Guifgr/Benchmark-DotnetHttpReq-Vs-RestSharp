using BenchmarkDotNet.Attributes;
using RestSharp;

namespace RestClientTest;

[MemoryDiagnoser(true)]
[HtmlExporter]
public class RestCalls
{
  private const string Url = "INSERT SOME API URL HERE";
  // I recommend .net minimal Apis

  [Benchmark]
  public void RestSharpCall()
  {
    var client = new RestClient();
    var request = new RestRequest(Url);
    client.Execute(request);
  }

  [Benchmark]
  public void DotNetHttpCall()
  {
    var httpClient = new HttpClient();
    httpClient.GetAsync(Url);
  }
}