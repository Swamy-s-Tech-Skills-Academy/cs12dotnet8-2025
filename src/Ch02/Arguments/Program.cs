ForegroundColor = ConsoleColor.DarkCyan;

if (args.Length != 3)
{
    ForegroundColor = ConsoleColor.Red;

    WriteLine("\nUsage: dotnet run <foreground_color> <background_color> <cursor_size>");
    WriteLine("Example: dotnet run Red Yellow 50");
    WriteLine("Available colors: Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White");
    
    ResetColor();

    return;
}

WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    Write($"{arg} :: ");
}

if (!Enum.TryParse(args[0], true, out ConsoleColor foregroundColor))
{
    WriteLine($"Invalid foreground color: {args[0]}");

    return;
}

if (!Enum.TryParse(args[1], true, out ConsoleColor backgroundColor))
{
    WriteLine($"Invalid background color: {args[1]}");

    return;
}

if (!int.TryParse(args[2], out int cursorSize) || cursorSize < 1 || cursorSize > 100)
{
    WriteLine($"Invalid cursor size. Must be a number between 1 and 100: {args[2]}");

    return;
}

ForegroundColor = foregroundColor;
BackgroundColor = backgroundColor;

try
{
    CursorSize = cursorSize;
}
catch (PlatformNotSupportedException)
{
    WriteLine("\nChanging the cursor size is not supported on this platform.");
}

WriteLine($"\nForeground Color: {ForegroundColor}");
WriteLine($"Background Color: {BackgroundColor}");
WriteLine($"Cursor Size: {CursorSize}");

ResetColor();