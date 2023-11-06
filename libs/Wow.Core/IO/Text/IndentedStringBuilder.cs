using System.Diagnostics;
using System.Text;

namespace Wow.Core.IO.Text;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IndentedStringBuilder
{
    private readonly StringBuilder _builder;

    private string? _cached;
    private int _indentation;
    
    public IndentedStringBuilder() =>
        _builder = new StringBuilder();

    public IndentedStringBuilder Indent()
    {
        _indentation++;
        return this;
    }

    public IndentedStringBuilder UnIndent()
    {
        _indentation = Math.Max(_indentation - 1, 0);
        return this;
    }

    public IndentedStringBuilder Append(char value)
    {
        _builder.Append(value);
        return this;
    }
    
    public IndentedStringBuilder Append(string value)
    {
        _builder.Append(value);
        return this;
    }

    public IndentedStringBuilder Append(string value, params object[] args)
    {
        _builder.Append(string.Format(value, args));
        return this;
    }
    
    public IndentedStringBuilder AppendIndented(char value)
    {
        _builder
            .Append(new string('\t', _indentation))
            .Append(value);
        return this;
    }
    
    public IndentedStringBuilder AppendIndented(string value)
    {
        _builder
            .Append(new string('\t', _indentation))
            .Append(value);
        return this;
    }
    
    public IndentedStringBuilder AppendIndented(string value, params object[] args)
    {
        _builder
            .Append(new string('\t', _indentation))
            .Append(string.Format(value, args));
        return this;
    }

    public IndentedStringBuilder AppendLine()
    {
        _builder.AppendLine();
        return this;
    }
    
    public IndentedStringBuilder AppendLine(char value)
    {
        _builder
            .Append(value)
            .AppendLine();
        return this;
    }
    
    public IndentedStringBuilder AppendLine(string value)
    {
        _builder.AppendLine(value);
        return this;
    }
    
    public IndentedStringBuilder AppendLine(string value, params object[] args)
    {
        _builder.AppendLine(string.Format(value, args));
        return this;
    }
    
    public IndentedStringBuilder AppendLineIndented(char value)
    {
        _builder
            .Append(new string('\t', _indentation))
            .Append(value)
            .AppendLine();
        return this;
    }
    
    public IndentedStringBuilder AppendLineIndented(string value)
    {
        _builder
            .Append(new string('\t', _indentation))
            .AppendLine(value);
        return this;
    }
    
    public IndentedStringBuilder AppendLineIndented(string value, params object[] args)
    {
        _builder
            .Append(new string('\t', _indentation))
            .AppendLine(string.Format(value, args));
        return this;
    }
    
    public override string ToString() =>
        _cached ??= _builder.ToString();
}