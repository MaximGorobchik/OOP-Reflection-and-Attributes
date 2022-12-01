public class Weapon : IWeapon
{
    public string Name { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public IGem[] Sockets { get; set; }
    public Rarity Rarity{ get; set; }
    protected Weapon(string name, string rarity)
    { 
        this.Name = name;
        this.Rarity = Enum.Parse<Rarity>(rarity);
    }
    public Weapon()
    { }
    private bool SocketExist(int socketIndex)
    {
        if (socketIndex < 0 | socketIndex > this.Sockets.Length - 1)
        {
            return false;
        }
        return true;
    }
    public void AddGem(int index, IGem gem)
    {
        if(this.SocketExist(index))
        {
            this.Sockets[index] = gem;
        }
    }
    public void RemoveGem(int index)
    {
        if(this.SocketExist(index))
        {
            if (this.Sockets[index] != null)
            this.Sockets[index] = null;
        }
    }
    public void AddRarityBonus()
    {
        this.MinDamage += (int)this.Rarity;
        this.MaxDamage += (int)this.Rarity;
    }
    public override string ToString()
    {
        int minDamage = this.MinDamage;
        int maxDamage = this.MaxDamage;
        int strength = 0;
        int agility = 0;
        int vitality = 0;

        foreach (IGem gem in this.Sockets.Where(x => x != null))
        {
            strength += gem.Strength;
            agility += gem.Agility;
            vitality += gem.Vitality;
            minDamage += (gem.Strength * 2) + (gem.Agility * 1);
            maxDamage += (gem.Strength * 3) + (gem.Agility * 4);
        }

        return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
    }
}
