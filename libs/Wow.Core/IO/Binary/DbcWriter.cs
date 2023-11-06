using System.Text;

namespace Wow.Core.IO.Binary;

public sealed class DbcWriter : IDisposable
{
    private readonly BinaryWriter _writer;

    public long Length =>
        _writer.BaseStream.Length;

    public long Position
    {
        get => _writer.BaseStream.Position;
        set => _writer.BaseStream.Position = value;
    }

    public DbcWriter() =>
        _writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);

    public DbcWriter(byte[] buffer) =>
        _writer = new BinaryWriter(new MemoryStream(buffer), Encoding.UTF8);

    public byte[] ToArray() =>
        ((MemoryStream) _writer.BaseStream).ToArray();

    public void WriteUInt8(byte value) =>
        _writer.Write(value);

    public void WriteInt8(sbyte value) =>
        _writer.Write(value);

    public void WriteBoolean(bool value) =>
        _writer.Write(value);

    public void WriteUInt16(ushort value) =>
        _writer.Write(value);

    public void WriteInt16(short value) =>
        _writer.Write(value);

    public void WriteUInt32(uint value) =>
        _writer.Write(value);

    public void WriteInt32(int value) =>
        _writer.Write(value);

    public void WriteUInt64(ulong value) =>
        _writer.Write(value);

    public void WriteInt64(long value) =>
        _writer.Write(value);

    public void WriteSingle(float value) =>
        _writer.Write(value);

    public void WriteDouble(double value) =>
        _writer.Write(value);

    public void WriteString(string value) =>
        _writer.Write(value);

    public void WriteString(string value, int count) =>
        _writer.Write(Encoding.UTF8.GetBytes(value[..count]));

    public void WriteBytes(byte[] value) =>
        _writer.Write(value);

    public void WriteBytes(byte[] value, int count) =>
        _writer.Write(value[..count]);

    public void WriteBytes(byte[] value, int offset, int count) =>
        _writer.Write(value[offset..count]);

    public void WriteBytes(ReadOnlySpan<byte> value) =>
        _writer.Write(value.ToArray());

    public void WriteBytes(ReadOnlySpan<byte> value, int count) =>
        _writer.Write(value[..count].ToArray());

    public void WriteBytes(ReadOnlySpan<byte> value, int offset, int count) =>
        _writer.Write(value[offset..count].ToArray());
    
    public void Dispose() =>
        _writer.Dispose();
}