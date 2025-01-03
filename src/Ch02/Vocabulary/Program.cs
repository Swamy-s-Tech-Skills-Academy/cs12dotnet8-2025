using System.Data;
using System.Reflection;

ForegroundColor = ConsoleColor.DarkCyan;

// See https://aka.ms/new-console-template for more information
//#error version
WriteLine($"Computer named {Env.MachineName} says \"No.\"");

DataSet ds = new();
WriteLine($"DataSet Name: {ds.DataSetName}");

HttpClient client = new();
WriteLine($"Default Request Version: {client.DefaultRequestVersion}\n");

// Get the assembly that is the entry point for this app.
Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly is null)
{
    WriteLine($"Assembly: {assembly} is NULL.");
    return;
}

// Loop through the assemblies that my app references.
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }

    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", a.DefinedTypes.Count(), methodCount, name.Name);
}

ResetColor();

WriteLine("Press any key ...");
ReadKey();
