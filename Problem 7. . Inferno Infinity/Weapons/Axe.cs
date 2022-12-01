public class Axe : Weapon
{
    private int MinDmg = 5;
    private int MaxDmg = 10;
    private int NumberofSockets = 4;
    public Axe(string name, string rarity) : base(name, rarity)
    {
        this.MinDamage = MinDmg;
        this.MaxDamage = MaxDmg;
        this.Sockets = new IGem[NumberofSockets];
        this.AddRarityBonus();
    }
}