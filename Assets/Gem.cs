using UnityEngine;
using System.Collections;

public class Gem
{
    public int x { get; set; }
    public int y { get; set; }
    public int bonus { get; set; }
    public HitCandy hitGem { get; private set; }
    public bool INull { get { return hitGem == null; } }
    public Gem(int yr, int xc)
    {
        y = yr;
        x = xc;
    }
    public void OnInit(HitCandy hitI)
    {
        hitGem = hitI;
        hitGem.isGem(this);
    }
    public bool match3(Gem g)
    {
        return !INull && !g.INull && hitGem.isequal(g.hitGem);//&& hitGem.type != "ingredient" + 0 && hitGem.type != "ingredient" + 1;
    }
    public void Nil()
    {
        hitGem = null;
    }
}

