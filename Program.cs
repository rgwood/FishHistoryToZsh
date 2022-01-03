using System.Text;
using YamlDotNet.Serialization;

var fishHistory = File.ReadAllText("fish_history");

var deserializer = new DeserializerBuilder()
	.IgnoreUnmatchedProperties()
 	.Build();

var deserialized = deserializer.Deserialize<List<FishHistoryEntry>>(fishHistory);
var output = new StringBuilder();

foreach (var item in deserialized)
{
    //zsh format:
    //: 1640546806:0;cd src

    output.AppendLine($": {item.when}:0;{item.cmd}");
}

File.WriteAllText("fish_history_in_zsh_format", output.ToString());
Console.WriteLine("Finished!");
