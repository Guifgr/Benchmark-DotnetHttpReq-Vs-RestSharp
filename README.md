# Benchmark-DotnetHttpReq-Vs-RestSharp
## Results

<pre><code>
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1503 (20H2/October2020Update)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT DEBUG
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
</code></pre>

<table>
<thead><tr><th>  Method</th><th>Mean</th><th>Error</th><th>StdDev</th><th>Gen 0</th><th>Gen 1</th><th>Allocated</th>
</tr>
</thead><tbody><tr><td>RestSharpCall</td><td>1,190.8 μs</td><td>23.17 μs</td><td>31.72 μs</td><td>17.5781</td><td>7.8125</td><td>54 KB</td>
</tr><tr><td>DotNetHttpCall</td><td>140.7 μs</td><td>15.88 μs</td><td>45.05 μs</td><td>4.1504</td><td>1.0986</td><td>10 KB</td>
</tr></tbody></table>
