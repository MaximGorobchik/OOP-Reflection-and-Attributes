public interface IWeapon
{
    string Name { get; }
    int MinDamage { get; set; }
    int MaxDamage { get; set; }
    IGem[] Sockets { get; set; }
    void AddGem(int index, IGem gem);
    void RemoveGem(int index);
    void AddRarityBonus();
}
