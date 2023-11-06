using System.Collections.Immutable;
using Wow.Tools.ProtocolBuilder.Models;

namespace Wow.Tools.ProtocolBuilder.Parsers.Datacenter;

public interface IDatacenterParser
{
    ImmutableArray<DbcClass> Parse(string fileName);
}