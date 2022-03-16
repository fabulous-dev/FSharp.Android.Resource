FSharp.Android.Resource
--

MSBuild task to expose resources to F# .NET Fx / .NET 6 Android projects

### How to use

1. Replace the old type provider with the new package in your Android project
```diff
- <PackageReference Include="Xamarin.Android.FSharp.ResourceProvider" />
+ <PackageReference Include="FSharp.Android.Resource" />
```

2. Remove old properties from the Android fsproj
```diff
<PropertyGroup>
-   <AndroidResgenFile>Resources/Resource.designer.cs</AndroidResgenFile>
-   <AndroidUseIntermediateDesignerFile>false</AndroidUseIntermediateDesignerFile>
</PropertyGroup>
```

3. (macOS only) If you're in an IDE and you see errors, unload/reload the Android project
4. Everything should be working, enjoy!
