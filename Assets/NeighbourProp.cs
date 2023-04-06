using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class NeighbourProp
{
    public List<Gem> gemms = new List<Gem>();
    public int bt { get; set; }
    public int MatchType;
    public IEnumerable<Gem> GetGems
    {
        get { return gemms.Distinct(); }
    }
    public void AddGemms(Gem gem)
    {
        if (!gemms.Contains(gem)) gemms.Add(gem);
    }
    public bool BonusTypeWhite(int bt1)
    {
        return bt1 == 1;
    }
}
