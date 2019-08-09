## EnumMapper

This is a tool to convert enums to other enums using the name instead of the value.

It's just a fancy way of making a `Enum.Parse(typeof(TestEnum2), TestEnum1.First.ToString())`

## Benckmark

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.202
  [Host]     : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT


|     Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|  EnumParse | 193.3 ns | 0.3376 ns | 0.2993 ns | 0.0076 |     - |     - |      48 B |
| EnumMapper | 104.4 ns | 1.5005 ns | 1.2530 ns | 0.0037 |     - |     - |      24 B |