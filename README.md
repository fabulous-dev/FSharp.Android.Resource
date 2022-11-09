FSharp.Android.Resource
--

MSBuild task to expose resources to F# .NET Fx / .NET 6 & 7 Android projects

### How to use

1. Replace the old type provider with the new package for your Android project

```diff
- <PackageReference Include="Xamarin.Android.FSharp.ResourceProvider" />
+ <PackageReference Include="FSharp.Android.Resource" />
```

2. Remove the following properties from your Android project fsproj file. 
   They are managed by FSharp.Android.Resource
   

```diff
<PropertyGroup>
-   <AndroidResgenFile>Resources/Resource.designer.cs</AndroidResgenFile>
-   <AndroidUseIntermediateDesignerFile>false</AndroidUseIntermediateDesignerFile>
</PropertyGroup>
```

3. Run the build one time; **it will fail but it's ok**. This generates the resource assembly.
4. Reload your project to be able to see the new resource assembly
5. Add `do Resource.UpdateIdValues()` to your MainActivity (or whichever activity is the first one to display)

```fsharp
type MainActivity() =
    inherit Activity()
    
    // This is required for the app to pick up the right resources
    do Resource.UpdateIdValues()
    
    member _.OnCreate(bundle) =
      base.OnCreate(bundle)
      
      // Now you can use Resource like usual
      this.SetContentView(Resource.Layout.Main)
```

6. Build one more time. This time it should complete successfully.
7. Everything should be working, enjoy!

### How to use in a Continuous Integration environment

Given the first build will always fail, you can use the following steps to workaround it:

1. Execute a build using the target `CompileResourceDesignerForFSharp`
2. Execute a normal build

```sh
msbuild -t:CompileResourceDesignerForFSharp
msbuild -t:Build
```
