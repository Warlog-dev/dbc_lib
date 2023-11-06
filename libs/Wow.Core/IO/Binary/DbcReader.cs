using System.Text;

namespace Wow.Core.IO.Binary;

public sealed class DbcReader : IDisposable
{
    private readonly BinaryReader _reader;

    public long Length =>
        _reader.BaseStream.Length;

    public long Position
    {
        get => _reader.BaseStream.Position;
        set => _reader.BaseStream.Position = value;
    }
    
    public long BytesAvailable =>
        Length - Position;
    
    public DbcReader(byte[] buffer) =>
        _reader = new BinaryReader(new MemoryStream(buffer), Encoding.UTF8);
    
    public byte ReadUInt8() =>
        _reader.ReadByte();
    
    public sbyte ReadInt8() =>
        _reader.ReadSByte();
    
    public bool ReadBoolean() =>
        _reader.ReadBoolean();
    
    public ushort ReadUInt16() =>
        _reader.ReadUInt16();
    
    public short ReadInt16() =>
        _reader.ReadInt16();
    
    public uint ReadUInt32() =>
        _reader.ReadUInt32();
    
    public int ReadInt32() =>
        _reader.ReadInt32();
    
    public ulong ReadUInt64() =>
        _reader.ReadUInt64();
    
    public long ReadInt64() =>
        _reader.ReadInt64();
    
    public float ReadSingle() =>
        _reader.ReadSingle();
    
    public double ReadDouble() =>
        _reader.ReadDouble();
    
    public string ReadString() =>
        _reader.ReadString();
    
    public string ReadString(int count) =>
        Encoding.UTF8.GetString(ReadBytes(count));

    public string ReadStringNull()
    {
        byte b;

        var result = new List<byte>();

        while ((b = _reader.ReadByte()) is not 0)
            result.Add(b);
        
        return Encoding.UTF8.GetString(result.ToArray());
    }

    public byte[] ReadUInt8Array(int count)
    {
        var result = new byte[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadUInt8();
        
        return result;
    }

    public sbyte[] ReadInt8Array(int count)
    {
        var result = new sbyte[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadInt8();
        
        return result;
    }
    
    public ushort[] ReadUInt16Array(int count)
    {
        var result = new ushort[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadUInt16();
        
        return result;
    }
    
    public short[] ReadInt16Array(int count)
    {
        var result = new short[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadInt16();
        
        return result;
    }
    
    public uint[] ReadUInt32Array(int count)
    {
        var result = new uint[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadUInt32();
        
        return result;
    }
    
    public int[] ReadInt32Array(int count)
    {
        var result = new int[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadInt32();
        
        return result;
    }
    
    public ulong[] ReadUInt64Array(int count)
    {
        var result = new ulong[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadUInt64();
        
        return result;
    }
    
    public long[] ReadInt64Array(int count)
    {
        var result = new long[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadInt64();
        
        return result;
    }
    
    public float[] ReadSingleArray(int count)
    {
        var result = new float[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadSingle();
        
        return result;
    }
    
    public double[] ReadDoubleArray(int count)
    {
        var result = new double[count];
        
        for (var i = 0; i < count; i++)
            result[i] = ReadDouble();
        
        return result;
    }
    
    public byte[] ReadBytes(int count) =>
        _reader.ReadBytes(count);

    public void Dispose() =>
        _reader.Dispose();
}