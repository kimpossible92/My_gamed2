using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveLayer : MonoBehaviour {
    public static MoveLayer THIS;
    public string Name;
    public string urlOnTournament;
    [HideInInspector] public int movecount;
    [HideInInspector] public int limitMove;
    public UnityEngine.UI.Text GetTextMove;
    public int state = 0;
    Vector2[] visibleSize;
    private int SizeX;
    private int SizeY;
    public GameObject[] bug;
    [SerializeField] List<Vector2> ylist2 = new List<Vector2>();
    [SerializeField] Arrays GetArrays;
    [SerializeField] HitCandy[] GetCandyPrefab;
    [SerializeField] HitCandy[] GetCandieSecons;
    [SerializeField] OpenAppLevel levelsApps;
    [SerializeField] OpenAppLevel AppLevel;
    HitCandy GetHitGem;
    [SerializeField] Sprite sprite12;
    [SerializeField] HitCandy[] GetBonusPrefab;
    [SerializeField] HitCandy swirlPrefab;
    [SerializeField] Sprite[] GetIngredientSprite;
    [SerializeField]GameObject plus5Seconds;
    bool load;
    int Ending=0;
    public int End() {return Ending; }
    public bool loaldo() { return load; }
    public void loadMove(bool load1)
    {
        load = load1;
    }
    // Use this for initialization
    void Start()
    {
        
    }
    /// <summary>
    /// restart
    /// </summary>
    public void restarting()
    {
        SizeX = AppLevel.MaxX;
        SizeY = AppLevel.MaxY;
        Gems();
    }
    // Update is called once per frame
    void Update()
    {
        GetTextMove.text = string.Format("{0}", movecount);
        if (movecount != limitMove)
        {
            GetTextMove.gameObject.SetActive(true);//
            switch (state)
            {
                case 0:
                    if(levelsApps.modeLvl==2) StartCoroutine(IngredientScale());
                    if (Input.GetMouseButtonDown(0))
                    {
                        var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
                        if (hit.collider != null)
                        {
                            GetHitGem = hit.collider.GetComponent<HitCandy>();
                            state = 1;
                            if((uint)levelsApps.ltype==1)
                            {
                                //levelsApps.GetPause();
                            }
                        }
                    }
                    break;
                case 1:
                    if (Input.GetMouseButtonUp(0))
                    {
                        var hits = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
                        if (hits.collider != null && GetHitGem != hits.collider.gameObject)
                        {
                            HitCandy GetHitGem2 = hits.collider.gameObject.GetComponent<HitCandy>();
                            if (!((GetHitGem.GetGem.x == GetHitGem2.GetGem.x || GetHitGem.GetGem.y == GetHitGem.GetGem.y) && (Mathf.Abs(GetHitGem.GetGem.x - GetHitGem2.GetGem.x) <= 1 && Mathf.Abs(GetHitGem.GetGem.y - GetHitGem2.GetGem.y) <= 1)))
                            {
                                state = 0;
                            }
                            else
                            {
                                state = 2;
                                if (movecount == 1) { Ending = 1; }
                                movecount -= 1;
                                StartCoroutine(TryMatch(hits));
                            }
                        }
                    }
                    break;
            }
        }

    }
    [SerializeField] List<List<Vector2>> xlist1 = new List<List<Vector2>>();
    public List<string> vslist;
    List<Gem> matchesOne(Gem[,] gemmall, int row, int col)
    {
        List<Gem> match = new List<Gem>();
        vslist.Clear();
        if (col <= GetArrays.SizeX - 2 && gemmall[row, col].match3(gemmall[row, col + 1]))//
        {
            if (row > 0 && col < GetArrays.SizeX - 2 && gemmall[row, col].match3(gemmall[row - 1, col + 2]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row, col + 1]);
                match.Add(gemmall[row - 1, col + 2]);
                Debug.Log("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row - 1) + "," + (col + 2));
                vslist.Add("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row - 1) + "," + (col + 2));
                List<Vector2> vsadd = new List<Vector2>();
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2(col * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 1) * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 2) * 0.6f, (row - 1) * 0.6f)));
                xlist1.Add(vsadd);
            }
        }
        return match;
    }
    List<Gem> matchesTwo(Gem[,] gemmall, int row, int col)//
    {
        List<Gem> match = new List<Gem>();
        if (col <= GetArrays.SizeX - 2 && gemmall[row, col].match3(gemmall[row, col + 1]))//
        {
            if (row <= GetArrays.SizeY - 2 && col < GetArrays.SizeX - 2 && gemmall[row, col].match3(gemmall[row + 1, col + 2]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row, col + 1]);
                match.Add(gemmall[row + 1, col + 2]);
                Debug.Log("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row + 1) + "," + (col + 2));
                vslist.Add("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row + 1) + "," + (col + 2));
                List<Vector2> vsadd = new List<Vector2>();
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2(col * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 1) * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 2) * 0.6f, (row + 1) * 0.6f)));
                xlist1.Add(vsadd);
            }
        }
        return match;//
    }
    List<Gem> matchesThree(Gem[,] gemmall, int row, int col)//
    {
        List<Gem> match = new List<Gem>();
        if (col <= 2 && gemmall[row, col].match3(gemmall[row, col + 1]))//
        {
            //if (row >=2 && col<GetArrayMatch.SizeX - 2 && gemmall[row, col].match3(gemmall[row - 1, col + 2]) ||
            //row >= GetArrayMatch.SizeY - 2 && gemmall[row, col].match3(gemmall[row + 1, col + 2]))
            //{
            if (row > 0 && col >= 2 && gemmall[row, col].match3(gemmall[row - 1, col + 2]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row, col + 1]);
                match.Add(gemmall[row - 1, col + 2]);
                //match.Add(match1);
                Debug.Log("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row - 1) + "," + (col + 2));
                vslist.Add("match:" + row + "," + col + ";" + (row) + "," + (col + 1) + ";" + (row - 1) + "," + (col + 2));
                List<Vector2> vsadd = new List<Vector2>();
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2(col * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 1) * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 2) * 0.6f, (row - 1) * 0.6f)));
                xlist1.Add(vsadd);
            }
        }
        return match;//
    }
    List<Gem> matchesFour(Gem[,] gemmall, int row, int col)//
    {
        List<Gem> match = new List<Gem>();
        if (col <= 2 && gemmall[row, col].match3(gemmall[row, col - 1]))
        {
            if (row < GetArrays.SizeY - 2 && col >= 2 && gemmall[row, col].match3(gemmall[row + 1, col - 2]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row, col + 1]);
                match.Add(gemmall[row + 1, col - 2]);
                print("gem:" + gemmall[row, col].x + gemmall[row, col].y);


            }
        }
        return match;
    }
    List<Gem> matchesFive(Gem[,] gemmall, int row, int col)
    {
        List<Gem> match = new List<Gem>();
        if (row < GetArrays.SizeY - 2 && gemmall[row, col].match3(gemmall[row + 1, col]))
        {
            if (row < GetArrays.SizeY - 2 && col > 0 && gemmall[row, col].match3(gemmall[row + 2, col - 1]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row + 1, col]);
                match.Add(gemmall[row + 2, col - 1]);
                vslist.Add("match:" + row + "," + col + ";" + (row + 1) + "," + col + ";" + (row + 2) + "," + (col - 1) + ";");
                List<Vector2> vsadd = new List<Vector2>();
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2(col * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col) * 0.6f, (row + 1) * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col - 1) * 0.6f, (row + 2) * 0.6f)));
                xlist1.Add(vsadd);
            }
        }
        return match;
    }
    List<Gem> matchesSix(Gem[,] gemmall, int row, int col)
    {
        List<Gem> match = new List<Gem>();
        if (row < GetArrays.SizeY - 2 && gemmall[row, col].match3(gemmall[row + 1, col]))
        {
            if (row < GetArrays.SizeY - 2 && col < GetArrays.SizeX - 2 && gemmall[row, col].match3(gemmall[row + 2, col + 1]))
            {
                match.Add(gemmall[row, col]);
                match.Add(gemmall[row + 1, col]);
                match.Add(gemmall[row + 2, col + 1]);
                vslist.Add("match:" + row + "," + col + ";" + (row + 1) + "," + col + ";" + (row + 2) + "," + (col + 1) + ";");
                List<Vector2> vsadd = new List<Vector2>();
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2(col * 0.6f, row * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col) * 0.6f, (row + 1) * 0.6f)));
                vsadd.Add(new Vector2(-2.37f, -4.27f) + (new Vector2((col + 1) * 0.6f, (row + 2) * 0.6f)));
                xlist1.Add(vsadd);
            }
        }
        return match;
    }
    List<Gem> matches1(Gem[,] gemmall)
    {
        List<List<Gem>> match = new List<List<Gem>>();
        for (int row = 0; row < GetArrays.SizeY; row++)
        {
            for (int col = 0; col < GetArrays.SizeX; col++)
            {
                match.Add(matchesOne(gemmall, row, col));
                match.Add(matchesTwo(gemmall, row, col));
                match.Add(matchesThree(gemmall, row, col));
                //match.Add(matchesFour(gemmall, row, col));
                match.Add(matchesFive(gemmall, row, col));
                match.Add(matchesSix(gemmall, row, col));
            }
        }
        ylist2 = xlist1[Random.Range(0, xlist1.Count)];//
        return match[Random.Range(0, match.Count)];
    }
    public void LoadHelp()
    {
        xlist1.Clear();
        foreach (var gem123 in matches1(GetArrays.gems))
        {

        }//
        for (int i = 0; i < bug.Length; i++)
        {
            bug[i].transform.position = ylist2[i];
        }
    }
    public IEnumerator IngredientScale()
    {
        IEnumerable<Gem> matchs = null;
        List<Gem> ScaleIngr = new List<Gem>();
        IEnumerable<Gem> matchs2 = null;
        for (int i = 0; i < SizeX; i++)
        {
            if (GetArrays.gems[0, i].hitGem.type == "ingredient" + 0&& levelsApps.ingCtar[0]!=0)//
            { ScaleIngr.Add(GetArrays.gems[0, i]); levelsApps.ingCtar[0] -= 1; }
            if (GetArrays.gems[0, i].hitGem.type == "ingredient" + 1&& levelsApps.ingCtar[1] != 0) {
                ScaleIngr.Add(GetArrays.gems[0, i]); levelsApps.ingCtar[1] -= 1; }
        }
        matchs = ScaleIngr;
        foreach (var k in ScaleIngr)
        {
            ScaleMatch(k.hitGem);
        }
        var bottom = matchs.Select(gem => gem.x).Distinct();
        var updateafterMatch = GetArrays.UpdateAfter(bottom);
        var newSpawn = GetNeighbourProp(bottom);
        int maxDistance = Mathf.Max(updateafterMatch.MaxDistance, newSpawn.MaxDistance);
        Moved(maxDistance, newSpawn.GetGems);
        Moved(maxDistance, updateafterMatch.GetGems);
        yield return new WaitForSeconds(0.05f * Mathf.Max(updateafterMatch.MaxDistance, newSpawn.MaxDistance));
        matchs2 = GetArrays.GetNeighbours(newSpawn.GetGems).Union(GetArrays.GetNeighbours(updateafterMatch.GetGems)).Distinct();
        while(matchs2.Count()>=3)
        {
            foreach(var k2 in matchs2)
            {
                ScaleMatch(k2.hitGem);
            }
            var bottom2 = matchs2.Select(gem => gem.x).Distinct();
            var updateafterMatch2 = GetArrays.UpdateAfter(bottom);
            var newSpawn2 = GetNeighbourProp(bottom2);
            int maxDistance2 = Mathf.Max(updateafterMatch.MaxDistance, newSpawn2.MaxDistance);
            Moved(maxDistance, newSpawn2.GetGems);
            Moved(maxDistance, updateafterMatch2.GetGems);
            yield return new WaitForSeconds(0.05f * maxDistance2);
            matchs2 = GetArrays.GetNeighbours(newSpawn2.GetGems).Union(GetArrays.GetNeighbours(updateafterMatch2.GetGems)).Distinct();
        }
    }
    public Gem IngredientPosition(int ingr1,int ingr2)
    {
        int[] IngredientXPosition = { SizeX / 2, (SizeX / 2) + 1, SizeX / 2 - 1 };
        Gem[] genIngr0 = new Gem[ingr1];
        Gem[] gemIngr1 = new Gem[ingr2];
        int randpos;
        for (int i = 0; i < ingr1; i++)
        {
            randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
            if (IsNulls((SizeY - 1) - i, randpos) == true)
            {
                randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
            }
            genIngr0[i] = GetArrays.gems[(SizeY - 1) - i, randpos];
            genIngr0[i].hitGem.type = "ingredient" + 0;
            genIngr0[i].hitGem.GetComponent<SpriteRenderer>().sprite = GetIngredientSprite[0];
        }
        for (int i = 0; i < ingr2; i++)
        {
            randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
            if (GetArrays.gems[(SizeY / 2) - i, randpos].hitGem.type == "ingredient" + 0) randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
            if (IsNulls((SizeY / 2) - i, randpos) == true)
            {
                randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
                if (GetArrays.gems[(SizeY / 2) - i, randpos].hitGem.type == "ingredient" + 0) randpos = IngredientXPosition[Random.Range(0, IngredientXPosition.Length)];
            }
            gemIngr1[i] = GetArrays.gems[(SizeY / 2) - i, IngredientXPosition[Random.Range(0, IngredientXPosition.Length)]];
            gemIngr1[i].hitGem.type = "ingredient" + 1;
            gemIngr1[i].hitGem.GetComponent<SpriteRenderer>().sprite = GetIngredientSprite[1];
        }
        GetArrays.ingredientsGems = new HitCandy[genIngr0.Length];
        GetArrays.ingredientsGems2 = new HitCandy[gemIngr1.Length];//
        for (int k = 0; k < genIngr0.Length; k++) { GetArrays.ingredientsGems[k] = genIngr0[k].hitGem; }
        for (int k = 0; k < gemIngr1.Length; k++) { GetArrays.ingredientsGems2[k] = gemIngr1[k].hitGem; }
        //GetArrays.ingredientsGems2 = gemIngr1[0].hitGem;//
        return gemIngr1[0];
    }
    public void GetDestroyAlls()
    {
        for (int row = 0; row < GetArrays.SizeY; row++)
        {
            for (int col = 0; col < GetArrays.SizeX; col++)
            {
                if (GetArrays[row, col].INull == false)
                {
                    Destroy(obj: GetArrays[row, col].hitGem.gameObject);
                }
            }
        }
    }
    /// <summary>
    /// начало
    /// </summary>
    private void Gems()
    {
        float xc = levelsApps.blckWH();//
        float yr = levelsApps.blckWH();//
        for (int row = 0; row < GetArrays.SizeY; row++)
        {
            for (int col = 0; col < GetArrays.SizeX; col++)
            {
                if (GetArrays[row, col].INull == false)
                {
                    Destroy(obj: GetArrays[row, col].hitGem.gameObject);
                }
            }
        }
        for (int row = 0; row < SizeY; row++)
        {
            for (int col = 0; col < SizeX; col++)
            {
                GetArrays.gems[row, col].Nil();
            }
        }
        int g = SizeX;
        visibleSize = new Vector2[g];
        
        for (int row = 0; row < SizeY; row++)
        {
            for (int col = 0; col < SizeX; col++)
            {

                HitCandy hitCandy = GetCandyPrefab[Random.Range(0, GetCandyPrefab.Length)];
                while (col >= 2 && GetArrays[row, col - 1].hitGem.isequal(hitCandy) && GetArrays[row, col - 2].hitGem.isequal(hitCandy))//&& levelsManager.squaresArray[(row) * levelsManager.maxCols + (col-1)].types != SquareTypes.NONE&& levelsManager.squaresArray[(row) * levelsManager.maxCols + (col-1)].types != SquareTypes.NONE)
                {
                    hitCandy = GetCandyPrefab[Random.Range(0, GetCandyPrefab.Length)];
                }
                while (row >= 2 && GetArrays[row - 1, col].hitGem.isequal(hitCandy) && GetArrays[row - 2, col].hitGem.isequal(hitCandy))//&& levelsManager.squaresArray[(row - 1) * levelsManager.maxCols + col].types != SquareTypes.NONE && levelsManager.squaresArray[(row-2)*levelsManager.maxCols+col].types!=SquareTypes.NONE)
                {
                    hitCandy = GetCandyPrefab[Random.Range(0, GetCandyPrefab.Length)];
                }
                CreateGem(row, col, hitCandy);
            }
        }

        for (int i = 0; i < SizeX; i++)
        {
            visibleSize[i] = levelsApps.vector2position + new Vector2(i * xc, SizeY * yr); //new Vector2(-2.37f, -4.27f) + new Vector2(i * 0.7f, SizeY * 0.7f);
        }
        if(levelsApps.modeLvl!=2)LoadHelp();
        levelsApps.printScores = 0;
    }
    public bool IsNulls(int row, int col)
    {
        if (levelsApps.blocksp[row* levelsApps.MaxX+col].types==0)
        {
            return true;
        }
        return false;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="row"></param>
    /// <param name="c"></param>
    /// <param name="hgem"></param>
    public void CreateGem(int row, int c, HitCandy hgem)
    {
        int[] randomplus5sec = {0,1,2,3,4,5,6,7,8};
        int plus5sec = randomplus5sec[Random.Range(0, randomplus5sec.Length)];
        if ((int)levelsApps.ltype==1&&plus5sec == c) { hgem = GetCandieSecons[Random.Range(0, GetCandieSecons.Length)]; }
        float xc = levelsApps.blckWH();
        float yr = levelsApps.blckWH();
        Vector2 vectorgem = levelsApps.vector2position + (new Vector2(c * xc, row * yr));
        HitCandy gemit = ((GameObject)Instantiate(hgem.gameObject, new Vector3(vectorgem.x, vectorgem.y, -0.1f), Quaternion.identity)).GetComponent<HitCandy>();
        gemit.transform.SetParent(GetArrays.transform);
        GetArrays[row, c].OnInit(gemit);
        if (IsNulls(row, c) == true) { Destroy(gemit.gameObject); }
    }
    /// <summary>
    /// новые Конфеты
    /// </summary>
    /// <param name="colls"></param>
    /// <returns></returns>
    private UpdateAfterMatch GetNeighbourProp(IEnumerable<int> colls)
    {
        UpdateAfterMatch afterMatch = new UpdateAfterMatch();
        foreach (int coll in colls)
        {
            var emptyGems = GetArrays.NullGemsonc(coll);
            foreach (var g in emptyGems)
            {
                if (IsNulls(g.y, coll)==false)
                {
                    var pref = GetCandyPrefab[Random.Range(0, GetCandyPrefab.Length)];
                    if ((int)levelsApps.ltype == 1)
                    {
                        int[] randomplus5sec = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
                        int plus5sec = randomplus5sec[Random.Range(0, randomplus5sec.Length)];
                        if ((int)levelsApps.ltype == 1 && plus5sec == coll) { pref = GetCandieSecons[Random.Range(0, GetCandieSecons.Length)]; }
                    }
                    var initgem = ((GameObject)Instantiate(pref.gameObject, new Vector3(visibleSize[coll].x, visibleSize[coll].y, -0.1f), Quaternion.identity)).GetComponent<HitCandy>();
                    initgem.transform.SetParent(GetArrays.transform);
                    g.OnInit(initgem);
                    if (GetArrays.SizeY - g.y > afterMatch.MaxDistance)
                    {
                        afterMatch.MaxDistance = GetArrays.SizeY - g.y;
                    }
                    afterMatch.AddGemms(g);
                }
                if (IsNulls(g.y, coll) == true)
                {
                    if (GetArrays.gems[g.y, coll].hitGem.type == "ingredient" + 0)
                    { levelsApps.ingCtar[0] -= 1; }
                    if (GetArrays.gems[g.y, coll].hitGem.type == "ingredient"+1)
                    { levelsApps.ingCtar[0] -= 1; }
                    //Destroy(GetArrays.gems[g.y, coll].hitGem.gameObject);
                }
            }
        }
        return afterMatch;
    }
    /// <summary>
    /// Начинаем собирать совпадения
    /// </summary>
    /// <param name="raycast2"></param>
    /// <returns></returns>
    IEnumerator TryMatch(RaycastHit2D raycast2)
    {
        HitCandy GetHitGem2 = raycast2.collider.gameObject.GetComponent<HitCandy>();
        if(GetHitGem.type=="swirl"&&GetHitGem2.type!= "ingredient"+0&&GetHitGem2.type != "ingredient" + 1)
        {
            GetHitGem.type = GetHitGem2.type;
        }
        if (GetHitGem2.type == "swirl"&& GetHitGem.type != "ingredient" + 0&&GetHitGem.type != "ingredient"+1)
        {
            GetHitGem2.type = GetHitGem.type;
        }
        GetArrays.OnSwapping(GetHitGem.GetGem, GetHitGem2.GetGem);
        GetHitGem.transform.TweenPosition(0.2f, GetHitGem2.transform.position);
        GetHitGem2.transform.TweenPosition(0.2f, GetHitGem.transform.position);
        yield return new WaitForSeconds(0.2f);
        var GetHitGemNeigbours = GetArrays.GetProp(GetHitGem.GetGem);
        var GetHitGemNeigbours2 = GetArrays.GetProp(GetHitGem2.GetGem);        
        var matchs = GetHitGemNeigbours.GetGems.Union(GetHitGemNeigbours2.GetGems).Distinct();        
        if (matchs.Count() < 3)
        {
            GetHitGem.transform.TweenPosition(0.2f, GetHitGem2.transform.position);
            GetHitGem2.transform.TweenPosition(0.2f, GetHitGem.transform.position);
            yield return new WaitForSeconds(0.2f);
            GetArrays.Lastsp();
            movecount += 1;
            if (Ending==1)
            {
                Ending = 0;
            }
        }
        string typebonus="";
        Gem bonusGem = null;
        bool addsquareBonus=false;
        bool addswirlBonus = matchs.Count() == 5 && GetHitGemNeigbours.bt == 1 || GetHitGemNeigbours2.bt == 1;
        bool addBonus = matchs.Count() >= 4 && GetHitGemNeigbours.bt == 1 || GetHitGemNeigbours2.bt == 1;
        if(addBonus)
        {
            var sameTypeGem = GetHitGemNeigbours.gemms.Count() > 0 ? GetHitGem : GetHitGem2;
            bonusGem = sameTypeGem.GetGem;
            if(matchs.Count()==5)
            {
                sameTypeGem.type = "swirl";
            }
            typebonus = sameTypeGem.type;
            OpenAppLevel.THIS.StripeGameCount += 1;
        }
        while(matchs.Count()>=3)
        {
            foreach(var i in matchs)
            {
                ScaleMatch(i.hitGem);
            }
            //ScaleMatch()
            if (addBonus)
            {
                CreateBonus(bonusGem,typebonus);
            }
            addBonus = false;
            
            var bottom = matchs.Select(gem => gem.x).Distinct();
            var updateafterMatch = GetArrays.UpdateAfter(bottom);
            var newSpawn = GetNeighbourProp(bottom);
            int maxDistance = Mathf.Max(updateafterMatch.MaxDistance, newSpawn.MaxDistance);            
            Moved(maxDistance, newSpawn.GetGems);
            Moved(maxDistance, updateafterMatch.GetGems);
            yield return new WaitForSeconds(0.05f * Mathf.Max(updateafterMatch.MaxDistance, newSpawn.MaxDistance));            
            matchs = GetArrays.GetNeighbours(newSpawn.GetGems).Union(GetArrays.GetNeighbours(updateafterMatch.GetGems)).Distinct();
        }
        if (Ending==1)
        {
            levelsApps.LoadLB();
            Ending = 2;
        }
        for (int i = 0; i < bug.Length; i++)
        {
            bug[i].transform.position = new Vector3(0, -123, 0);
        }
        state = 0;
        //levelsApps.GetPause();
    }
    public void ender()
    {
        Ending = 0;
    }
    void Moved(int dist,IEnumerable<Gem> gemsie)
    {
        float xc = levelsApps.blckWH();
        float yr = levelsApps.blckWH();
        foreach (var j in gemsie)
        {
                j.hitGem.transform.TweenPosition(0.05f * dist, (new Vector3(levelsApps.vector2position.x,levelsApps.vector2position.y)) + (new Vector3(j.x * xc, j.y * yr,-0.1f)));// new Vector2(-2.37f, -4.27f) + new Vector2(j.x * 0.7f, j.y * 0.7f));//
        }
    }
    /// <summary>
    /// уночтожить совпадения
    /// </summary>
    /// <param name="hitmatchs"></param>
    public void ScaleMatch(HitCandy hitmatchs)
    {
        if ((int)levelsApps.ltype == 1 && hitmatchs.seconds != 0) levelsApps.Limit += hitmatchs.seconds;
        if (levelsApps.modeLvl == 1)
        {
            string[] CollectItemsfromcolor = { "", "red", "purple", "blue1", "blue2" };
            for (int i = 0; i < CollectItemsfromcolor.Count(); i++)
            {
                if (hitmatchs.type == CollectItemsfromcolor[i])
                {
                    if (i == (int)levelsApps.collectItems[0]) { if(levelsApps.ingCtar[0]> 0) levelsApps.ingCtar[0] -= 1; }
                    if (i == (int)levelsApps.collectItems[1]) { if (levelsApps.ingCtar[1]> 0) levelsApps.ingCtar[1] -= 1; }
                }
            }
        }
        
        levelsApps.printScores += 10;
        
        if (levelsApps.blocksp[hitmatchs.GetGem.y * levelsApps.MaxX + hitmatchs.GetGem.x].modelvlsquare == 3)
        {
            levelsApps.NotColorSquare(hitmatchs.GetGem.x, hitmatchs.GetGem.y, sprite12);
            levelsApps.blockscount -= 1;
        }
        if (levelsApps.blocksp[hitmatchs.GetGem.y * levelsApps.MaxX + hitmatchs.GetGem.x].types != 0)
        {
            hitmatchs.GetGem.Nil();
            Destroy(hitmatchs.gameObject);
        }
    }
    /// <summary>
    /// создать бонус
    /// </summary>
    /// <param name="bgem"></param>
    /// <param name="type"></param>
    public void CreateBonus(Gem bgem,string type)
    {
        float xc = levelsApps.blckWH();
        float yr = levelsApps.blckWH();
        HitCandy hitCandynew = null;
        if (type == "swirl")
        {
            hitCandynew = swirlPrefab;
        }
        else
        {
            for (int i = 0; i < GetBonusPrefab.Length; i++)
            {
                if (GetBonusPrefab[i].type == type)
                {
                    hitCandynew = GetBonusPrefab[i];
                }
            }
        }        
        Vector2 vectorgem = levelsApps.vector2position + (new Vector2(bgem.x * xc, bgem.y * yr));
        HitCandy bonuses = ((GameObject)Instantiate(hitCandynew.gameObject, new Vector3(vectorgem.x, vectorgem.y, -0.1f), Quaternion.identity)).GetComponent<HitCandy>();
        bonuses.transform.SetParent(GetArrays.transform);
        GetArrays[bgem.y, bgem.x].OnInit(bonuses);
        GetArrays.gems[bgem.y, bgem.x] = bonuses.GetGem;
        bonuses.GetGem.bonus = 1;
        bonuses.isBonus = true;
        if (type == "swirl") { bonuses.type = type; bonuses.isSwirl = true;bonuses.isBonus = false; }
    }

}
