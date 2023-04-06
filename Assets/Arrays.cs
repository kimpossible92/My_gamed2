using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Arrays : MonoBehaviour {
    [SerializeField] OpenAppLevel levelsManager2;
    public static Arrays THIS;
    public int SizeX = 9;
    public int SizeY = 11;
    public Gem[,] gems;
    Gem GetGem1;
    Gem GetGem2;
    public Gem this[int r, int c]
    {
        get { return gems[r, c]; }
        set { gems[r, c] = value; }
    }
    public HitCandy[] ingredientsGems;
    public HitCandy[] ingredientsGems2;
    public HitCandy IngredientCurrent;
    public Gem currentGem;
    // Use this for initialization
    void Start() {
    }
    private void Awake()
    {
        THIS = this;
        gems = new Gem[SizeY, SizeX];
        for (int row = 0; row < SizeY; row++)
        {
            for (int c = 0; c < SizeX; c++)
            {
                gems[row, c] = new Gem(row, c);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnSwapping(Gem gem1, Gem gem2)
    {
        GetGem1 = gem1;
        GetGem2 = gem2;

        HitCandy hitGem = gem1.hitGem;
        gem1.OnInit(gem2.hitGem);
        gem2.OnInit(hitGem);
    }
    public void Lastsp()
    {
        OnSwapping(GetGem1, GetGem2);
    }
    /// <summary>
    /// Ienumerable совпадений
    /// </summary>
    /// <param name="gemsIe"></param>
    /// <returns></returns>
    public IEnumerable<Gem> GetNeighbours(IEnumerable<Gem> gemsIe)
    {
        List<Gem> gemslist = new List<Gem>();
        foreach (var g in gemsIe)
        {
            gemslist.AddRange(GetProp(g).GetGems);
        }
        return gemslist.Distinct();
    }
    /// <summary>
    /// совпадения по вертикали и горизонтали
    /// </summary>
    /// <param name="gem"></param>
    /// <returns></returns>
    public NeighbourProp GetProp(Gem gem)
    {
        NeighbourProp neighbour = new NeighbourProp();
        IEnumerable<Gem> nhMatch = MatchesHorrizontally(gem);
        IEnumerable<Gem> nvMatch = MatchesVertically(gem);
        if (GetBonusType1(nhMatch))
        {
            if (neighbour.bt == 0) { neighbour.MatchType = 1; neighbour.bt = 1; }
        }
        if (GetBonusType1(nvMatch))
        {
            if (neighbour.bt == 0) { neighbour.MatchType = 2; neighbour.bt = 1; }
        }
        if (GetBonusType2(nhMatch))
        {
            nhMatch = GetEntireCol(gem);
        }
        if(GetBonusType2(nvMatch))
        {
            nvMatch = GetEntireRow(gem);
        }
        if(GetSwirlType1(nhMatch))
        {
            nhMatch = GetEntire5Match(gem);
        }
        if (GetSwirlType1(nvMatch))
        {
            nvMatch = GetEntire5Match(gem);
        }
        foreach (var g in nhMatch)
        {
            neighbour.gemms.Add(g);
        }
        foreach (var g in nvMatch)
        {
            neighbour.gemms.Add(g); //if (neighbour.gemms.Contains(g)) neighbour.gemms.Add(g);
        }        
        return neighbour;
    }
    /// <summary>
    /// добавить весь ряд
    /// </summary>
    /// <param name="gem"></param>
    /// <returns></returns>
    public IEnumerable<Gem> GetEntireRow(Gem gem)
    {
        List<Gem> vermatch = new List<Gem> { gem };
        int rower1 = gem.y;
        int col1 = gem.x;
        for (int row = 0; row < SizeY; row++)
        {
            if (IsNulls(row, col1) == false&&gems[row,col1].hitGem.type!= "ingredient"+0&& gems[row, col1].hitGem.type != "ingredient"+1) vermatch.Add(gems[row, col1]);
        }
        return vermatch;
    }
    /// <summary>
    /// добавить всю строку
    /// </summary>
    /// <param name="gem"></param>
    /// <returns></returns>
    public IEnumerable<Gem> GetEntireCol(Gem gem)
    {
        List<Gem> hormatch = new List<Gem> { gem };
        int row1 = gem.y;
        for (int col = 0; col < SizeX; col++)
        {
            if (IsNulls(row1, col) == false&&gems[row1,col].hitGem.type != "ingredient"+0&& gems[row1, col].hitGem.type != "ingredient" + 1) hormatch.Add(gems[row1, col]);
        }
        return hormatch;
    }
    public IEnumerable<Gem> GetEntireAlls(Gem gem)
    {
        List<Gem> matchesall = new List<Gem> { gem};
        int row1 = gem.y;
        int col1 = gem.x;
        for (int row = gem.y - 1; row < gem.y + 2; row++)
        {
            for (int col = gem.x - 1; col < gem.x + 2; col++)
            {
                if (gems[row, col] != null)
                {
                    if(IsNulls(row1, col) == false) matchesall.Add(gems[row, col]);
                }
            }
        }
        return matchesall;
    }
    public IEnumerable<Gem> GetEntire5Match(Gem gem)
    {
        List<Gem> matchesall = new List<Gem> { gem };
        for(int row=0;row<SizeY;row++)
        {
            for(int col=0;col<SizeX;col++)
            {
                if((gems[row,col]).match3(gem))
                {
                    if (IsNulls(row, col) == false) matchesall.Add(gems[row, col]);
                }
            }
        }
        return matchesall;
    }
    /// <summary>
    /// MatchesHorrizontally
    /// </summary>
    /// <param name="gem"></param>
    /// <returns></returns>
    private IEnumerable<Gem> MatchesHorrizontally(Gem gem)
    {
        List<Gem> hormatch = new List<Gem>();
        hormatch.Add(gem);
        if (gem.x != 0)
        {
            for (int col = gem.x - 1; col >= 0; col--)
            {
                Gem l = gems[gem.y, col];
                if (l.match3(gem))
                {
                    hormatch.Add(l);
                }
                else
                {
                    break;
                }
            }
        }
        if (gem.x != SizeX - 1)
        {
            for (int col = gem.x + 1; col < SizeX; col++)
            {
                Gem r = gems[gem.y, col];
                if (r.match3(gem))
                {
                    hormatch.Add(r);
                }
                else
                {
                    break;
                }
            }
        }
        if(hormatch.Count()>= 1 && GetSwirlType1(hormatch))
        {

        }
        else if (hormatch.Count() < 3)
        {
            hormatch.Clear();
        }
        return hormatch.Distinct();
    }
    /// <summary>
    /// MatchesVertically
    /// </summary>
    /// <param name="gem"></param>
    /// <returns></returns>
    private IEnumerable<Gem> MatchesVertically(Gem gem)
    {
        List<Gem> vermatch = new List<Gem>();

        vermatch.Add(gem);
        if (gem.y != 0)
        {
            for (int row = gem.y - 1; row >= 0; row--)
            {
                Gem down = gems[row, gem.x];
                if (down.match3(gem))
                {
                    vermatch.Add(down);
                }
                else
                {
                    break;
                }
            }
        }
        if (gem.y != SizeY - 1)
        {
            for (int row = gem.y + 1; row < SizeY; row++)
            {
                Gem up = gems[row, gem.x];
                if (up.match3(gem))
                {
                    vermatch.Add(up);
                }
                else
                {
                    break;
                }
            }
        }
        
        if(vermatch.Count()>=1&&GetSwirlType1(vermatch))
        {

        }
        else if (vermatch.Count() < 3)
        {
            vermatch.Clear();
        }
        return vermatch.Distinct();
    }
    /// <summary>
    /// Collapse
    /// </summary>
    /// <param name="colum"></param>
    /// <returns></returns>
    public UpdateAfterMatch UpdateAfter(IEnumerable<int> colum)
    {
        UpdateAfterMatch afterMatch = new UpdateAfterMatch();
        foreach (var c in colum)
        {
            for (int row = 0; row < SizeY - 1; row++)
            {
                if (gems[row, c].hitGem == null&&IsNulls(row, c) == false)
                {
                    for (int row2 = row + 1; row2 < SizeY; row2++)
                    {
                        if (!gems[row2, c].INull&& IsNulls(row2, c) == false)
                        {                            
                            Gem gem1 = gems[row, c];
                            Gem gem2 = gems[row2, c];
                            gem1.OnInit(gem2.hitGem);
                            gem2.Nil();
                            afterMatch.MaxDistance = Mathf.Max(row2 - row, afterMatch.MaxDistance);
                            afterMatch.AddGemms(gem1);
                            if (IsNulls(row, c) == true|| levelsManager2.blocksp[row * levelsManager2.MaxX + c].types == 0) Destroy(gems[row, c].hitGem.gameObject); 
                            if (IsNulls(row2, c) == true|| levelsManager2.blocksp[row2 * levelsManager2.MaxX + c].types == 0) Destroy(gems[row2, c].hitGem.gameObject); 
                            break;
                        }
                    }
                }
            }
        }

        return afterMatch;
    }
    public bool IsNulls(int row,int col)
    {
        if (levelsManager2.blocksp[row*levelsManager2.MaxX+col].types==0)
        {
            return true;
        }
        return false;
    }
    public IEnumerable<Gem> GetEmptyColumnsInfo(int column)
    {
        List<Gem> emptyMatches = new List<Gem>();
        for (int row = 0; row < SizeY; row++)
        {
            if (gems[row, column] == null) emptyMatches.Add(new Gem(row, column) { y = row, x = column });
        }
        return emptyMatches;
    }
    public IEnumerable<Gem> NullGemsonc(int collum)
    {
        List<Gem> gemsnull = new List<Gem>();
        for (int i = 0; i < SizeY; i++)
        {
            if (gems[i, collum].INull||IsNulls(i,collum)==true||levelsManager2.blocksp[i*levelsManager2.MaxX+collum].types==0)
            {
                gemsnull.Add(gems[i, collum]);
            }
        }
        return gemsnull;
    }
    public bool GetBonusType1(IEnumerable<Gem> gemses)
    {
        if(gemses.Count()>=4)
        {
            foreach(var g in gemses)
            {
                if (g.bonus == 0) return true;
            }
        }
        return false;
    }
    /// <summary>
    /// определяем бонус
    /// </summary>
    /// <param name="gemses"></param>
    /// <returns></returns>
    public bool GetBonusType2(IEnumerable<Gem> gemses)
    {
        if(gemses.Count()>=3)
        {
            foreach(var g in gemses)
            {
                if (g.hitGem.isBonus==true) { return true; }
            }
        }
        return false;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="gemses"></param>
    /// <returns></returns>
    public bool GetSwirlType1(IEnumerable<Gem> gemses)
    {
        if(gemses.Count()>=2)
        {
            foreach(var g in gemses)
            {
                if (g.hitGem.isSwirl == true) { return true; }
            }
        }
        return false;
    }
}