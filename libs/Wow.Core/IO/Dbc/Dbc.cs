using System.Data;
using Wow.Core.IO.Binary;

namespace Wow.Core.IO.Dbc;

public sealed class Dbc
{
    private const string HeaderSignature = "WDBC";
    
    public string FilePath { get; }
    
    public DbcHeader Header { get; }

    public Dbc(string filePath)
    {
        using var reader = new DbcReader(File.ReadAllBytes(filePath));
        
        if (reader.ReadString(4) is not HeaderSignature)
            throw new FileLoadException("Invalid DBC file signature.");
        
        FilePath = filePath;
        Header = new DbcHeader(reader, HeaderSignature);

        var position = reader.Position;
        
        var stringTableStart = reader.Position += Header.RecordCount * Header.RecordSize;

        var table = new Dictionary<int, string>();
        
        while (reader.Position < reader.Length)
            table[(int)(reader.Position - stringTableStart)] = reader.ReadStringNull();

        reader.Position = position;

        var recordCount = Math.Max(Header.OffsetLengths.Length, (int)Header.RecordCount);
        var recordSize = Header.RecordSize;

        var dataTable = new DataTable();

        for (var i = 0u; i < recordCount; i++)
        {
            var row = dataTable.NewRow();
            
            
        }
    }
}