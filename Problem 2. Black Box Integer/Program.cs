using System.Reflection;
var box = typeof(BlackBoxInteger);
var innervalue = (BlackBoxInteger)Activator.CreateInstance(box, true);
var inputline = Console.ReadLine();
while (!inputline.Equals("END"))
{
    var input_info = inputline.Split("_");
    var method = box.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
    var this_method = method.FirstOrDefault(x => x.Name.Equals(input_info[0]));
    this_method?.Invoke(innervalue, new object[] { int.Parse(input_info[1]) });
    var innerValue = box.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(x => x.Name.Equals("innerValue")).GetValue(innervalue);
    Console.WriteLine(innerValue);
    inputline = Console.ReadLine();
}