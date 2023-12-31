﻿using System.Diagnostics;

namespace Wow.SourceGenerators.Models;

[DebuggerDisplay("Name: {Name}, Type: {Type}, IsIndex: {IsIndex}, IsAutoGenerated: {IsAutoGenerated}, ArraySize: {ArraySize}")]
public sealed class DbcProperty
{
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public bool IsIndex { get; set; }
    
    public bool IsAutoGenerated { get; set; }
    
    public int ArraySize { get; set; }

    public DbcProperty(string name, string type, bool isIndex, bool isAutoGenerated, int arraySize)
    {
        Name = name;
        Type = type;
        IsIndex = isIndex;
        IsAutoGenerated = isAutoGenerated;
        ArraySize = arraySize;
    }
}