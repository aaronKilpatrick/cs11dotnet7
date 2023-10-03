string border = new('-', 77);

WriteLine(border);
WriteLine(
    format: "{0, -8}{1, -3}{2, 20}{3, 32}",
    "Type",
    "Byte(s) of Memory",
    "Min",
    "Max"
);
WriteLine(border);

WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "sbyte",
    sizeof(sbyte),
    sbyte.MinValue,
    sbyte.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "byte",
    sizeof(byte),
    byte.MinValue,
    byte.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "short",
    sizeof(short),
    short.MinValue,
    short.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "ushort",
    sizeof(ushort),
    ushort.MinValue,
    ushort.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "int",
    sizeof(int),
    int.MinValue,
    int.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "uint",
    sizeof(uint),
    uint.MinValue,
    uint.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "long",
    sizeof(long),
    long.MinValue,
    long.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "ulong",
    sizeof(ulong),
    ulong.MinValue,
    ulong.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "float",
    sizeof(float),
    float.MinValue,
    float.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "double",
    sizeof(double),
    double.MinValue,
    double.MaxValue
);
WriteLine(
    format: "{0, -8}{1, -3}{2, 34}{3, 32}",
    "decimal",
    sizeof(decimal),
    decimal.MinValue,
    decimal.MaxValue
);
WriteLine(border);