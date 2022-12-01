using System.Runtime.CompilerServices;
WFactory wFactory = new WFactory();
GFactory gFactory = new GFactory();
var weapons = new Weapon();
var inputline = Console.ReadLine();
while (!inputline.Equals("END"))
{
    var input_info = inputline.Split(";",StringSplitOptions.RemoveEmptyEntries);
    if (input_info[0].Equals("Create"))
    {
        Create(input_info);
    }
    if (input_info[0].Equals("Add"))
    {
        Add(input_info);
    }
    if (input_info[0].Equals("Remove"))
    {
        Remove(input_info);
    }
    if (input_info[0].Equals("Print"))
    {
        Print(input_info);
    }
    inputline = Console.ReadLine();
}
void Create(string[] x)
{
    string[] rarity_type = x[1].Split(" ");
    string rarity = rarity_type[0];
    string type = rarity_type[1];
    string name = x[2];
    IWeapon weapon = wFactory.CreateW(type, rarity, name);
}
void Add(string[]x)
{
    string name = x[1];
    int index = int.Parse(x[2]);
    string[] clarity_gem = x[3].Split(' ');
    string clarity = clarity_gem[0];
    string gem = clarity_gem[1];
    IGem gems = gFactory.CreateG(gem, clarity);
    weapons.AddGem(index, gems);
}
void Remove(string[]x)
{
    string name = x[1];
    int index = int.Parse(x[2]);
    weapons.RemoveGem(index);
}
void Print(string[]x)
{
    string name = x[1];
    Console.WriteLine($"{weapons}");
}