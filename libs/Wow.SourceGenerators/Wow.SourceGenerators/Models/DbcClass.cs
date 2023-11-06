using System.Collections.Immutable;
using System.Diagnostics;

namespace Wow.SourceGenerators.Models;

[DebuggerDisplay("Name: {Name}, Properties: {Properties.Length}")]
public sealed class DbcClass
{
    public string Name { get; set; }
    
    public ImmutableArray<DbcProperty> Properties { get; set; }
    
    public DbcClass(string name, ImmutableArray<DbcProperty> properties)
    {
        Name = name;
        Properties = properties;
    }
}