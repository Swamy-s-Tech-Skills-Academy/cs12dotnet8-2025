ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

WriteLine($"We received {args?.Length ?? 0} arguments:");
if (args != null)
{
    foreach (string arg in args)
    {
        WriteLine(arg);
    }
}

WriteLine(Environment.NewLine + $"CurrentDirectory: {Env.CurrentDirectory}");
WriteLine($"OSVersion.VersionString: {Env.OSVersion.VersionString}");
WriteLine($"Namespace: {typeof(Program).Namespace ?? "None!"}");

ResetColor();

throw new Exception();
// Revealing the hidden code - Program.<Main>$(String[] args). Execute the program without debugging. 

