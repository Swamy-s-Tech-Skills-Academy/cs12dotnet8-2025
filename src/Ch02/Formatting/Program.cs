ForegroundColor = ConsoleColor.DarkCyan;

#region Formatting using numbered positional arguments

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;//Use current culture

// Use string interpolation where possible
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// For cases where string.Format is necessary (e.g., localization), use it correctly
string formatted = string.Format(nfi, // Add NumberFormatInfo
    "{0} apples cost {1:C}",
    numberOfApples,
    pricePerApple * numberOfApples);
WriteLine(formatted);

// Named arguments are generally less readable than interpolation for simple cases
// Use interpolation if you can
WriteLine($"{"Roger"} {"Cevung"} lived in {"Stockholm"}.");

// For more than 3 arguments, interpolation is almost always preferred
WriteLine($"{"Roger"} {"Cevung"} lived in {"Stockholm"} and worked in the {"Education"} team at {"Optimizely"}.");

#endregion

#region Formatting using interpolated strings (already well-done)

// No changes needed here, good use of interpolation
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

#endregion

#region Understanding format strings

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();

// Improved header spacing for better alignment
WriteLine($"{"Name",-10} {"Count",10:N0}"); // Use interpolation and format specifier in the header

WriteLine($"{applesText,-10} {applesCount,10:N0}");
WriteLine($"{bananasText,-10} {bananasCount,10:N0}");

#endregion

#region Getting text input from the user

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type your age and press ENTER: ");
string? ageInput = ReadLine(); // Use a nullable string

if (int.TryParse(ageInput, out int age)) // Validate input
{
    WriteLine($"Hello {firstName}, you look good for {age}.");
}
else
{
    WriteLine("Invalid age entered. Please enter a number.");
}

#endregion

#region Getting key input from the user

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey(intercept: true); // Don't echo the key
WriteLine();
WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");

#endregion

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine(grinningEmoji);

ResetColor();

WriteLine("\n\nPress any key to exit...");
ReadKey(true);
