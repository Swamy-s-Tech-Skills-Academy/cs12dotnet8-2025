using CoreServices.Runner.Interfaces;

namespace Ch01.Runnables;

internal class HelloEnvironmentApp : IRunnable
{
    public string Title => "Hello, Environment";

    public void Run()
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("CurrentDirectory: {0}", Env.CurrentDirectory);
        WriteLine("OSVersion.VersionString: {0}", Env.OSVersion.VersionString);
        WriteLine("Namespace: {0}!", typeof(Program).Namespace);
    }

}
