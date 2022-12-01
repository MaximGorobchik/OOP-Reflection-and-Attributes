public class WFactory
{
    public IWeapon CreateW(string type, string rarity,string name)
    {
        IWeapon weapon = null;
        if(type.Equals("Axe"))
        {
            weapon = new Axe(name,rarity);
        }
        if (type.Equals("Sword"))
        {
            weapon = new Sword(name, rarity);
        }
        if (type.Equals("Knife"))
        {
            weapon = new Knife(name, rarity);
        }
        return weapon;
    }
}