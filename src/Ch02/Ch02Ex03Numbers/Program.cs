ForegroundColor = ConsoleColor.DarkCyan;

string rowSeparator = new('-', 104);
NumberFormatInfo nfi = CultureInfo.InvariantCulture.NumberFormat;

WriteLine(rowSeparator);
WriteLine($"{"Type",-10} {"Bytes",6} {"Min",45} {"Max",45}");
WriteLine(rowSeparator);

WriteLine($"{"sbyte",-10} {sizeof(sbyte),6} {sbyte.MinValue.ToString("G", nfi),45} {sbyte.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"byte",-10} {sizeof(byte),6} {byte.MinValue.ToString("G", nfi),45} {byte.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"short",-10} {sizeof(short),6} {short.MinValue.ToString("G", nfi),45} {short.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"ushort",-10} {sizeof(ushort),6} {ushort.MinValue.ToString("G", nfi),45} {ushort.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"int",-10} {sizeof(int),6} {int.MinValue.ToString("G", nfi),45} {int.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"uint",-10} {sizeof(uint),6} {uint.MinValue.ToString("G", nfi),45} {uint.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"long",-10} {sizeof(long),6} {long.MinValue.ToString("G", nfi),45} {long.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"ulong",-10} {sizeof(ulong),6} {ulong.MinValue.ToString("G", nfi),45} {ulong.MaxValue.ToString("G", nfi),45}");

unsafe
{
    WriteLine($"{"Int128",-10} {sizeof(Int128),6} {Int128.MinValue.ToString("G", nfi),45} {Int128.MaxValue.ToString("G", nfi),45}");
    WriteLine($"{"UInt128",-10} {sizeof(UInt128),6} {UInt128.MinValue.ToString("G", nfi),45} {UInt128.MaxValue.ToString("G", nfi),45}");
    WriteLine($"{"Half",-10} {sizeof(Half),6} {Half.MinValue.ToString("G", nfi),45} {Half.MaxValue.ToString("G", nfi),45}");
}

WriteLine($"{"float",-10} {sizeof(float),6} {float.MinValue.ToString("G", nfi),45} {float.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"double",-10} {sizeof(double),6} {double.MinValue.ToString("G", nfi),45} {double.MaxValue.ToString("G", nfi),45}");
WriteLine($"{"decimal",-10} {sizeof(decimal),6} {decimal.MinValue.ToString("G", nfi),45} {decimal.MaxValue.ToString("G", nfi),45}");

WriteLine(rowSeparator);

ResetColor();

WriteLine("\n\nPress any key to exit...");
ReadKey(true);
