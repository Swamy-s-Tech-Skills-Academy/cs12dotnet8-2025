using CoreServices.Runner.Interfaces;

namespace Ch01.Runnables;

internal class HelloCSApp : IRunnable
{
    public string Title => "Hello, C# 12 - .Net 8";

    public void Run()
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("Hello, C# 12, and DotNet 8 !");

        string name = typeof(Program).Namespace ?? "None!";
        WriteLine($"Program.cs Namespace: {name}");

        name = typeof(HelloCSApp).Namespace ?? "None!";
        WriteLine($"HelloCSApp Namespace: {name}");
    }

}
