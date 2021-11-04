

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

## Credits

[Newtonsoft.Json](https://www.newtonsoft.com/json)
[RestSharp](https://restsharp.dev/)  
[Tỉnh Thành Việt Nam](https://provinces.open-api.vn/)
And big thanks to [AlphaNecron](https://github.com/AlphaNecron) for helping me fixing some errors
