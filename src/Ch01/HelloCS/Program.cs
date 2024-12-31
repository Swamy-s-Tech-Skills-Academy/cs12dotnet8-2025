ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

WriteLine("We received {0} arguments:", args.Length);
foreach (string arg in args)
{
    WriteLine(arg);
}

WriteLine("CurrentDirectory: {0}", Env.CurrentDirectory);
WriteLine("OSVersion.VersionString: {0}", Env.OSVersion.VersionString);
WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "None!");

ResetColor();

throw new Exception();
// Revealing the hidden code - Program.<Main>$(String[] args). Execute the program without debugging. 

