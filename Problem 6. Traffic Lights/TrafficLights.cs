public class TrafficLights
{
    public Color Color { get; protected set; }
    public TrafficLights(string color)
    {
        this.Color = Enum.Parse<Color>(color);
    }
    public void Update()
    {
        this.Color += 1;
        if((int)this.Color > 2)
        {
            this.Color = 0;
        }
    }
    public override string ToString()
    {
        return $"{this.Color}";
    }
}
