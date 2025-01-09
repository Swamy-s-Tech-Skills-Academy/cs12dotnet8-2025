using System.Globalization;

ForegroundColor = ConsoleColor.DarkCyan;
NumberFormatInfo nfi = CultureInfo.InvariantCulture.NumberFormat; // Use invariant culture

#region Storing numbers

uint naturalNumber = 23;
int integerNumber = -23;
float realNumber = 2.3f;
double anotherRealNumber = 2.3;

WriteLine($"uint: {naturalNumber}, int: {integerNumber}, float: {realNumber:G}, double: {anotherRealNumber:G}"); // Use G format

#endregion

#region Three variables that store the number 2 million

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

WriteLine($"Decimal: {decimalNotation:N0}, Binary: {binaryNotation:N0}, Hexadecimal: {hexadecimalNotation:N0}"); // Combined output
WriteLine($"Decimal: {decimalNotation:X}, Binary: {binaryNotation:X}, Hexadecimal: {hexadecimalNotation:X}"); // Combined output

#endregion

#region Exploring whole numbers

WriteLine($"Decimal == Binary: {decimalNotation == binaryNotation}");
WriteLine($"Decimal == Hexadecimal: {decimalNotation == hexadecimalNotation}");

#endregion

#region Output the size and value ranges of common number types

WriteLine($"{"Type",-10} {"Bytes",6} {"Min",45} {"Max",45}");
WriteLine(new string('-', 104)); // Consistent separator

WriteLine($"{"int",-10} {sizeof(int),6} {int.MinValue.ToString("N0", nfi),45} {int.MaxValue.ToString("N0", nfi),45}");
WriteLine($"{"double",-10} {sizeof(double),6} {double.MinValue.ToString("N0", nfi),45} {double.MaxValue.ToString("N0", nfi),45}");
WriteLine($"{"decimal",-10} {sizeof(decimal),6} {decimal.MinValue.ToString("N0", nfi),45} {decimal.MaxValue.ToString("N0", nfi),45}");

#endregion

#region Comparing double and decimal types

WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
WriteLine($"{a} + {b} {(a + b == 0.3 ? "equals" : "does NOT equal")} {0.3}"); // Ternary operator

WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
WriteLine($"{c} + {d} {(c + d == 0.3M ? "equals" : "does NOT equal")} {0.3M}"); // Ternary operator

#endregion

#region Special float and double values

WriteLine($"double.Epsilon: {double.Epsilon:G}"); // Use G format
WriteLine($"double.Epsilon (full precision): {BitConverter.DoubleToInt64Bits(double.Epsilon)}");//Show full bits

const int col1 = 37;
const int col2 = 6;
string line = new string('-', col1 + col2 + 3);

WriteLine(line);
WriteLine($"{"Expression",-col1} | {"Value",col2}");
WriteLine(line);

// Use string interpolation and consistent formatting
WriteLine($"{nameof(double.NaN),-col1} | {double.NaN,col2:G}");
WriteLine($"{nameof(double.PositiveInfinity),-col1} | {double.PositiveInfinity,col2:G}");
WriteLine($"{nameof(double.NegativeInfinity),-col1} | {double.NegativeInfinity,col2:G}");
WriteLine(line);
WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2:G}");
WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2:G}");
WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2:G}");
WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {(3.0 / 0.0 == double.PositiveInfinity),col2}");
WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {(-3.0 / 0.0 == double.NegativeInfinity),col2}");
WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2:G}");
WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2:G}");
WriteLine(line);

#endregion

#region New number types and unsafe code

unsafe
{
    WriteLine($"{"Type",-10} {"Bytes",6} {"Min",45} {"Max",45}");
    WriteLine(new string('-', 104));
    WriteLine($"{"Half",-10} {sizeof(Half),6} {Half.MinValue.ToString("N0", nfi),45} {Half.MaxValue.ToString("N0", nfi),45}");
    WriteLine($"{"Int128",-10} {sizeof(Int128),6} {Int128.MinValue.ToString("N0", nfi),45} {Int128.MaxValue.ToString("N0", nfi),45}");
}

#endregion

ResetColor();

WriteLine("\nPress any key to exit...");
ReadKey(true);