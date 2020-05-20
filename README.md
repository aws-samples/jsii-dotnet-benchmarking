# jsii-dotnet-benchmarking

> Benchmark jsii dotnet module vs native counterpart

## Run benchmarks

1. Ensure `dotnet` CLI is installed and added to the `PATH`
2. Run the below command from your favorite shell:

```bash
dotnet run --configuration Release --project AWSSamples.Jsii.Benchmarking/AWSSamples.Jsii.Benchmarking.csproj
```

## Results

The outputs from the run of [BenchmarkDotNet](https://benchmarkdotnet.org/) on both jsii and native implementations:

1. from an AWS Workspaces VM with 4 Cores and 8 GiB RAM running Windows 10

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.1098 (1809/October2018Update/Redstone5)
Intel Xeon CPU E5-2676 v3 2.40GHz, 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|               Method |          Mean |       Error |        StdDev |    •|
|--------------------- |--------------:|------------:|--------------:|----:|
|   JsiiImplementation | 16,034.767 μs | 697.0084 μs | 1,999.8477 μs | [![][nuget-jsii-image]][nuget-jsii-url] |
| NativeImplementation |      4.282 μs |   0.0586 μs |     0.0549 μs | [![][nuget-native-image]][nuget-native-url] |

2. from a 2019 Macbook Pro with 2.8 GHz Intel Core i7 and 16GiB RAM running macOS Mojave:

``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Mojave 10.14.6 (18G4032) [Darwin 18.7.0]
Intel Core i7-8569U CPU 2.80GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.102
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|               Method |         Mean |       Error |        StdDev |    •|
|--------------------- |-------------:|------------:|--------------:|----:|
|   JsiiImplementation | 8,067.421 μs | 468.4371 μs | 1,351.5481 μs | [![][nuget-jsii-image]][nuget-jsii-url] |
| NativeImplementation |     2.917 μs |   0.0581 μs |     0.0669 μs | [![][nuget-native-image]][nuget-native-url] |

## License

This library is licensed under the MIT-0 License. See the LICENSE file.

[nuget-jsii-image]: https://img.shields.io/nuget/v/AWSSamples.Jsii
[nuget-jsii-url]: https://www.nuget.org/packages/AWSSamples.Jsii/
[nuget-native-image]: https://img.shields.io/nuget/v/AWSSamples.Jsii.Native
[nuget-native-url]: https://www.nuget.org/packages/AWSSamples.Jsii.Native/