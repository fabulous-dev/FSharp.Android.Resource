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

3. Compile 2 times (first time will fail because FSharp.Android.Resource needs to generate the dll first)
4. If you're in an IDE, close/reopen either the Android project or the whole solution
5. Everything should be working, enjoy!
