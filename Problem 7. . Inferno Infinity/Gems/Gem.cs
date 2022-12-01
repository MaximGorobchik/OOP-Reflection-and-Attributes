public abstract class Gem : IGem
{
    protected Gem(string clarity)
    {
        this.Clarity = Enum.Parse<Clarity>(clarity);
    }

    public int Strength { get; set; }

    public int Agility { get; set; }

    public int Vitality { get; set; }

    public Clarity Clarity { get; set; }

    public void AddClarityBonus()
    {
        this.Strength += (int)this.Clarity;
        this.Agility += (int)this.Clarity;
        this.Vitality += (int)this.Clarity;
    }
}