using Wow.Tools.ProtocolBuilder.Models;

namespace Wow.Tools.ProtocolBuilder.Renderers.Datacenter;

public interface IDatacenterRenderer
{
    string Render(DbcClass dbcClass);
}