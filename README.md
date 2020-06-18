# DashedJsonNamingPolicy

This is a simple JSON naming policy implementing the abstract `System.Text.Json.JsonNamingPolicy` class where `IsEnabled` becomes `is-enabled`

[![nuget shield](https://img.shields.io/nuget/v/DashedJsonNamingPolicy)](https://www.nuget.org/packages/DashedJsonNamingPolicy)

## Usage

Add `DashedJsonNamingPolicy` during the initialization of an ASP.NET Core service container:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services
        .AddControllers()
        .AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.PropertyNamingPolicy = new DashedJsonNamingPolicy.DashedJsonNamingPolicy();
        });
}
```