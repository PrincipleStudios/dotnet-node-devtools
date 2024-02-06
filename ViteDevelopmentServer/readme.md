# PrincipleStudios.ViteDevelopmentServer

A Vite development server for use with .NET Spa Services.

Usage:

```csharp
app.UseSpa(spa => {
    spa.Options.SourcePath = "./path-to-react-source";

#if DEBUG
    if (env.IsDevelopment())
    {
        spa.UseViteDevelopmentServer(
            // The bin path to run to launch the server from the SourcePath.
            // This is typically "node_modules/.bin/vite", but if you wrap Vite
            // a different path may be necessary
            "node_modules/.bin/vite",
            // Command line arguments to the script.
            // `{port}` will be replaced with an unused port.
            "--port {port}"
        );
    }
#endif
});
```