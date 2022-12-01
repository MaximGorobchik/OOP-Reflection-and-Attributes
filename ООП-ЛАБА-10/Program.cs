using System.Reflection;
using System.Security.Cryptography.X509Certificates;

Type harvestfields_type = typeof(HarvestingFields);
var inputline = Console.ReadLine();
while (!inputline.Equals("HARVEST"))
{
    var input_info = inputline.Split();
    if (input_info[0].Equals("public"))
    {
        var str = " ";
        str = "public";
        foreach(FieldInfo fields in harvestfields_type.GetFields(BindingFlags.Instance | BindingFlags.Public))
        {
            Console.WriteLine($"{str} {fields.FieldType} {fields.Name}");
        }
    }
    if (input_info[0].Equals("protected"))
    {
        var str = " ";
        str = "protected";
        foreach (FieldInfo fields in harvestfields_type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
        { 
            if(fields.IsFamily)
            {
                Console.WriteLine($"{str} {fields.FieldType} {fields.Name}");
            }
        }
    }
    if (input_info[0].Equals("private"))
    {
        var str = " ";
        str = "private";
        foreach (FieldInfo fields in harvestfields_type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
        {
            if (fields.IsPrivate)
            {
                Console.WriteLine($"{str} {fields.FieldType} {fields.Name}");
            }
        }
    }
    if (input_info[0].Equals("all"))
    {
        var str = " ";
        foreach (FieldInfo fields in harvestfields_type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        {
            if (fields.IsPublic)
            {
                str = "public";
            }
            if (fields.IsFamily)
            {
                str = "protected";
            }
            if (fields.IsPrivate)
            {
                str = "private";
            }
            Console.WriteLine($"{str} {fields.FieldType} {fields.Name}");
        }
    }
    inputline = Console.ReadLine();
}