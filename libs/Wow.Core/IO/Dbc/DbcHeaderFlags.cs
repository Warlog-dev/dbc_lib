namespace Wow.Core.IO.Dbc;

[Flags]
public enum DbcHeaderFlags : short
{
    None = 0x0,
    OffsetMap = 0x1,
    RelationshipData = 0x2,
    IndexMap = 0x4,
    Unknown = 0x8,
    Compressed = 0x10,
}