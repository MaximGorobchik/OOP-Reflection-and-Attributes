public class Sword : Weapon
{
    private int MinDmg = 4;
    private int MaxDmg = 6;
    private int NumberofSockets = 3;
    public Sword(string name, string rarity) : base(name, rarity)
    {
        this.MinDamage = MinDmg;
        this.MaxDamage = MaxDmg;
        this.Sockets = new IGem[NumberofSockets];
        this.AddRarityBonus();
    }
}