using Wow.Tools.ProtocolBuilder.Parsers.Datacenter;
using Wow.Tools.ProtocolBuilder.Renderers.Datacenter;

var xmlFileNames = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml").First();

if (Directory.Exists("Output"))
    Directory.Delete("Output", true);

Directory.CreateDirectory("Output");

var datacenterParser = new DatacenterParser();
var datacenterRenderer = new DatacenterRenderer();

var dbcClasses = new Dictionary<string, string>();


foreach (var dbcClass in datacenterParser.Parse(xmlFileNames))
{
    var content = datacenterRenderer.Render(dbcClass);
    
    dbcClasses.Add(dbcClass.Name, content);
}

const string correctPath = @"R:\Warlog\Wow\libs\Wow.Protocol\Datacenter";


foreach (var (name, content) in dbcClasses)
    File.WriteAllText($"{correctPath}/{name}.cs", content);
/*
foreach (var (name, content) in dbcClasses)
    File.WriteAllText($"Output/{name}.cs", content);
*/
Console.WriteLine("Done!");