namespace HelloEnvironment;

class Program
{
    static void Main(string[] args)
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine($"Hello, C# 12, and DotNet 8 !");

        WriteLine($"We received {args?.Length ?? 0} arguments:");
        if (args != null) // null check, though unlikely in Main
        {
            foreach (string arg in args)
            {
                WriteLine(arg);
            }
        }

        WriteLine(Environment.NewLine + $"CurrentDirectory: {Env.CurrentDirectory}"); // Environment.NewLine
        WriteLine($"OSVersion.VersionString: {Env.OSVersion.VersionString}");
        WriteLine($"Namespace: {typeof(Program).Namespace ?? "None!"}");

        ResetColor();

        WriteLine("\n\nPress any key to exit...");
        ReadKey(true);
    }
}