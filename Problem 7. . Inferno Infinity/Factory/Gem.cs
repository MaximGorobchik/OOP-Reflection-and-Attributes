public class GFactory
{
    public IGem CreateG(string type, string clarity)
    {
        IGem gem = null;
        if(type.Equals("Ruby"))
        {
            gem = new Ruby(clarity);
        }
        if (type.Equals("Emerald"))
        {
            gem = new Emerald(clarity);
        }
        if (type.Equals("Amethyst"))
        {
            gem = new Amethys(clarity);
        }
        return gem;
    }
}