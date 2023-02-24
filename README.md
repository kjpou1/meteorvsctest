# meteorvsctest
test meteor with vscode and debug.writeline


# created with
```
> dotnet new maui -n meteorvsctest
   The template ".NET MAUI App" was created successfully.
```

# Add .NET Metero Debugger - launch.json

From Run and Debug click on link `create a launch.json file.`
   - Select `.NET Meteor Debugger` from selection list presented


# Add code to MauiProgram.cs

``` csharp
		Console.WriteLine("console.writeline");
		#if DEBUG
			Console.WriteLine("console.writeline debug");
		#endif
		Debug.WriteLine("debug.writeline");
```
