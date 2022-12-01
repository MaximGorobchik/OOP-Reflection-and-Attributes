using System.Runtime.CompilerServices;

public class Emerald : Gem
{

    public Emerald(string clarity) : base(clarity)
    {
        this.Strength = 1;
        this.Agility = 4;
        this.Vitality = 9;
        this.AddClarityBonus();
    }
}