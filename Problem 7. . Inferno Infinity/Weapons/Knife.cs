public class Knife : Weapon
{
    private int MinDmg = 3;
    private int MaxDmg = 4;
    private int NumberofSockets = 2;
    public Knife(string name, string rarity) : base(name, rarity)
    {
        this.MinDamage = MinDmg;
        this.MaxDamage = MaxDmg;
        this.Sockets = new IGem[NumberofSockets];
        this.AddRarityBonus();
    }
}
