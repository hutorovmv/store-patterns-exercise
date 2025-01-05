## Executed commands log

```
dotnet --version
dotnet --list-runtimes
dotnet --info

dotnet new sln --output Store
cd Store

dotnet new list
dotnet new classlib --output Store.Dal
dotnet new classlib --output Store.Bll
dotnet new webapi --output Store.Api
dotnet new xunit --output Store.Tests

dotnet list Store.Dal package
dotnet list Store.Bll package
dotnet list Store.Api package
dotnet list Store.Tests package

dotnet add Store.Bll reference Store.Dal
dotnet list Store.Bll reference

dotnet add Store.Api reference Store.Dal
dotnet add Store.Bll reference Store.Dal
dotnet list Store.Api reference

dotnet add Store.Tests reference Store.Dal
dotnet add Store.Tests reference Store.Dal
dotnet list Store.Tests reference


dotnet sln add Store.Dal/Store.Dal.csproj
dotnet sln add Store.Bll/Store.Bll.csproj
dotnet sln add Store.Api/Store.Api.csproj
dotnet sln add Store.Tests/Store.Tests.csproj
dotnet sln list

cd Store.Dal
rm Class1.cs
ni Product.cs
code Product.cs

dotnet add Store.Dal package Newtonsoft.Json
dotnet list package

cd ../Store.Tests
Remove-Item UnitTest1.cs
New-Item Product -ItemType Directory
cd Product
New-Item ProductTest.cs -ItemType File
code ProductTest.cs

dotnet build Store.Tests.csproj
dotnet test

cd ..
dotnet build Store.Api\Store.Api.csproj
dotnet run Store.Api\Store.Api.csproj
cd Store.Api
dotnet add Store.Api.csproj package Swashbuckle.AspNetCore
dotnet watch Store.Api.csproj
```
