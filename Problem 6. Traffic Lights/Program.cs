var inputline = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(Console.ReadLine());
List<TrafficLights> trafficLights= new List<TrafficLights>();
foreach(string color in inputline)
{
    var light = new TrafficLights(color);
    trafficLights.Add(light);
}
for (int i = 0; i < n; i++)
{
    foreach (var light in trafficLights)
    {
        light.Update();
    }
    Console.WriteLine(string.Join(" ", trafficLights));
}