using System.Collections.Immutable;
using System.Diagnostics;

namespace Wow.Tools.ProtocolBuilder.Models;

[DebuggerDisplay("Name: {Name}, Properties: {Properties.Length}")]
public sealed record DbcClass(string Name, ImmutableArray<DbcProperty> Properties);