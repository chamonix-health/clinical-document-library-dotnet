del *.nupkg

dotnet pack .\CDA.Generator\CDA.Generator.csproj -c Release -o .
dotnet pack .\DigitalHealth.Hl7ToCdaTransformer\DigitalHealth.Hl7ToCdaTransformer.csproj -c Release -o .

pause

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -Source https://www.nuget.org/api/v2/package"
