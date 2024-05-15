// Serializacion y deserializacion
using System.Text.Json;


var sergio = new People()
{
    Name = "Sergio",
    Age = 27,
};
string json = JsonSerializer.Serialize(sergio); // convirtiendolo a un json
Console.WriteLine(json);

string myJson = @"{
    ""Name"":""Fernando"",
    ""Age"":27
    }";
People? fernando = JsonSerializer.Deserialize<People>(myJson); // Convirtiendo de Json a clase
Console.WriteLine(fernando?.Name);
Console.WriteLine(fernando?.Age);
public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}