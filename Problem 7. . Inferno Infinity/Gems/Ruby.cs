using System.Runtime.CompilerServices;

public class Ruby : Gem
{
    
    public Ruby(string clarity) : base(clarity)
    {
        this.Strength = 7;
        this.Agility = 2;
        this.Vitality = 5;
        this.AddClarityBonus();
    }
}