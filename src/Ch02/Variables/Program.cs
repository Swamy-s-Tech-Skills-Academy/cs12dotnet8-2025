using System.Xml;

ForegroundColor = ConsoleColor.DarkCyan;

#region Storing any type of object

object height = 1.88;
object name = "Amir";
WriteLine($"{name} is {height} metres tall.");

// Use pattern matching instead of casting
if (name is string nameAsString)
{
    WriteLine($"{name} has {nameAsString.Length} characters.");
}

#endregion

#region Storing dynamic types

dynamic something = new[] { 3, 5, 7 }; // Initialize at declaration

WriteLine($"The length of something is {something.Length}");

WriteLine($"something is an {something.GetType()}");

// Example of how dynamic can cause runtime exceptions
something = 12;
try
{
    WriteLine($"The length of something is {something.Length}"); // This will throw an exception
}
catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
{
    WriteLine($"Error: {ex.Message}"); // Handle exception
}

something = "Ahmed";
WriteLine($"The length of something is {something.Length}");
WriteLine($"something is an {something.GetType()}");

#endregion

#region Specifying the type of a local variable

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

WriteLine($"{population:N0} people, weight: {weight:N2} kg, price: {price:C}."); // Format output
WriteLine($"{fruit} is the letter {letter} and it is {happy} that you like them."); // More natural wording

#endregion

#region Inferring the type of a local variable

// Good use of var
var xml1 = new XmlDocument();

// Still good to be explicit here for clarity, especially in larger scopes
using StreamWriter file2 = File.CreateText("something2.txt"); // Using statement

// Example of bad usage and how to fix it
var file3 = new FileStream("something3.txt", FileMode.Create); // Type is not clear from the initializer
using FileStream file4 = new("something4.txt", FileMode.Create); // Correct usage

#endregion

#region Getting and setting the default values for types

WriteLine($"default(int) = {default(int)}");
WriteLine($"default(bool) = {default(bool)}");
WriteLine($"default(DateTime) = {default(DateTime):O}"); // Use round-trip format for DateTime
WriteLine($"default(string) = {(default(string) == null ? "null" : default(string))}"); // Explicitly show null

int number = 13;
WriteLine($"number set to: {number}");
number = default;
WriteLine($"number reset to its default: {number}");

#endregion

ResetColor();

WriteLine("\nPress any key to exit...");
ReadKey(true);