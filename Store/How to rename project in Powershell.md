# How to rename project in Powershell

### Rename the project folder
```
Rename-Item -Path "OldProjectName" -NewName "NewProjectName"
```

### Change to the new project folder
```
Set-Location -Path "NewProjectName"
```

### Rename the .csproj file
```
Rename-Item -Path "OldProjectName.csproj" -NewName "NewProjectName.csproj"
```

### Update the project file references
```
(Get-Content "NewProjectName.csproj") -replace 'OldProjectName', 'NewProjectName' | Set-Content "NewProjectName.csproj"
```

### Update namespaces in .cs files
```
Get-ChildItem -Path . -Filter *.cs -Recurse | ForEach-Object {
    (Get-Content $_.FullName) -replace 'namespace OldProjectName', 'namespace NewProjectName' | Set-Content $_.FullName
}
```

### Restore and build the project
```
dotnet restore
dotnet build
```
