

# VN-Province-Open-API.NET
An API wrapper for Province Open API https://provinces.open-api.vn/


## Authors

- [@veeeleven](https://github.com/veeeleven)

  
## Usage/Example

```csharp
// Setup the API  
var api = new OpenProvinceAPI();  
            
// Get a list of provinces  
var list = api.GetProvinceList(1);
            
// Output the name of a province
Console.WriteLine(list[0].Name);
```

## Building

To Build This Project, run:

```bash
   nuget restore
   MSBuild.exe -property:Configuration=Release OpenWeatherMap.NET.csproj
```
