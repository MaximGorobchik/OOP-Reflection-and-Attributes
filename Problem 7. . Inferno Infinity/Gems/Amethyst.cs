using System.Runtime.CompilerServices;

public class Amethys : Gem
{

    public Amethys(string clarity) : base(clarity)
    {
        this.Strength = 2;
        this.Agility = 8;
        this.Vitality = 4;
        this.AddClarityBonus();
    }
}