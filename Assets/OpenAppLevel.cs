using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAppLevel : MonoBehaviour
{
    //public static OpenAppLevel THIS;
    [SerializeField] GameObject GetButton;
    public int[] ingTarget = new int[2];
    public int[] collectItems = new int[2];
    private int score1;
    private int score2;
    private int score3;
    public int MaxX;
    public int MaxY;
    public static int Scores;
    public int ltype;
    public int t;
    private int currentlvl;
    public int[] ingCtar;
    [SerializeField] Image NextImage;
    public Block[] blocksp;
    [SerializeField] public SquareBlocks[] Blocksf = new SquareBlocks[81];
    public int colorLimit;
    public int currentLevel() { return currentlvl; }//
    public void lvl(int l) { currentlvl = l; }
    [HideInInspector] public int modeLvl = 0;
    [HideInInspector] public int Limit;
    [SerializeField] MoveLayer GetMoveLayer;
    [SerializeField] Button NazadButton;
    [SerializeField] GameObject getBlock;
    [SerializeField] GameObject blockpref;
    public Vector2 vector2position;
    public int printScores;
    [SerializeField] private Sprite doubleBlock;
    [SerializeField] GameObject PrefabBlock4;
    [SerializeField] GameObject PrefabBlock5;
    [SerializeField] GameObject PrefabBlock6;
    [SerializeField] GameObject PrefabBlock7;
    [SerializeField] GameObject PrefabBlock8;
    [SerializeField] GameObject LevelParent;
    [SerializeField] GameObject TargetBlockImage;
    [SerializeField] GameObject IngredientsCountImage;
    [SerializeField] GameObject IngredientsCountImage2;
    [SerializeField] Text GetText;
    [SerializeField] Text GetText2;
    [SerializeField] Sprite[] GetSpritesFromItem;
    [HideInInspector] public int blockscount = 0;
    [HideInInspector]
    public int TargetScore;
    public int TargetScore1;
    public int TargetScore2;
    [SerializeField] Text IngredientsCountUIText;
    [SerializeField]
    Text IngredientsCountUIText2;
    [SerializeField] Text GetTextTimer;
    [SerializeField] OpLvl GetLevels2;[SerializeField] bool pause = false;
    [SerializeField] Text Play;
    public float blckWH() { return 0.6f; }//
    private void Awake()
    {
        //THIS = this;
    }
    public void selectscores(int s1,int s2,int s3)
    {
        score1 = s1;
        score2 = s2;
        score3 = s3;
    }
    public void SaveBombStripePackage()
    {
        if (FindObjectOfType<OpenAppLevel>().currentlvl > 20 && Facebook.Unity.FB.IsLoggedIn || Facebook.Unity.FB.IsLoggedIn)
        {
            if (PlayerPrefs.GetInt("TourQual") < 11) PlayerPrefs.SetInt("TourQual", PlayerPrefs.GetInt("TourQual") + StripeGameCount);
        }
        //if (LevelManager.THIS.currentLevel > 20 || LevelManager.THIS.currentLevel == 21)
        //{
            string url1 = FindObjectOfType<OpenAppLevel>().urlOnTournament.Replace(Tournament.urlpredicate, string.Empty);
            SaveControl();
           // Debug.Log("currentLevel:" + currentlvl);
        //}
    }
    public void SaveControl()
    {
        if (Facebook.Unity.FB.IsLoggedIn) GameObject.FindObjectOfType<PortalNetwork>().SaveControl();
    }
    public void OnappMatch()
    {
        NazadButton.gameObject.SetActive(false);//
        GetMoveLayer.gameObject.SetActive(true);
        GetMoveLayer.loadMove(false);
        TextAsset text = (TextAsset)Resources.Load("" + currentlvl);
        if (text == null) text = Resources.Load("" + currentlvl) as TextAsset;
        openLeveltxt(text.text);
        blocksp = new Block[MaxX * MaxY];//
        for (int row = 0; row < MaxY; row++)
        {
            for (int col = 0; col < MaxX; col++)
            {
                Createblock(col, row);
            }
        }
        GetMoveLayer.restarting();
        GameObject.FindObjectOfType<OpLvl>().gameObject.SetActive(false);
        NextImage.gameObject.SetActive(false);
        if (modeLvl == 3)
        {
            TargetBlockImage.gameObject.SetActive(true);
            IngredientsCountImage.SetActive(false);
        }
        else if (modeLvl == 2)
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(true);
            IngredientsCountImage2.SetActive(true);
            GetMoveLayer.IngredientPosition(ingCtar[0], ingCtar[1]);
            GetText2.gameObject.SetActive(false);
        }
        else if (modeLvl == 1)
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(true);
            IngredientsCountImage2.SetActive(true);
            GetText2.gameObject.SetActive(false);
            IngredientsCountImage.GetComponent<Image>().sprite = GetSpritesFromItem[(int)collectItems[0]];
            IngredientsCountImage2.GetComponent<Image>().sprite = GetSpritesFromItem[(int)collectItems[1]];
            
            if ((uint)ltype == 1 && GetMoveLayer.state == 0)
            {
                ISNULL = false;
                if (invoker==false) InvokeRepeating("RunTimer", 1, 1);                
            }
        }
        else
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(false);
        }
        if ((uint)ltype == 1) { GetTextTimer.text = "" + 60; GetMoveLayer.limitMove = 1; }
        print(modeLvl);
    }
    bool invoker = false;
    public void GetPause()
    {
        if ((uint)ltype == 1 && GetMoveLayer.state == 0)
        {
            StopCoroutine(GetEnumerator());
            StartCoroutine(GetEnumerator());
        }
        else
        {
            StopCoroutine(GetEnumerator());
        }
    }
    public void OnEmptySquare()
    {
        for (int row = 0; row < MaxY; row++)
        {
            for (int col = 0; col < MaxX; col++)
            {
                Destroy(blocksp[row * MaxX + col].gameObject);
            }
        }
    }
    public void NotColorSquare(int col, int row, Sprite sprite1)
    {
        if (blocksp[row * MaxX + col].modelvlsquare == 3)
        {
            blocksp[row * MaxX + col].block[0].GetComponent<SpriteRenderer>().sprite = sprite1;//

            blocksp[row * MaxX + col].modelvlsquare = 0;//
        }

        //printScores += 10;
    }
    public void nazad2()
    {
        GetMoveLayer.GetDestroyAlls();
        OnEmptySquare();
        //printScores = 0;
        if (modeLvl == 3)
        {
            blockscount = 0;
        }
        else if (modeLvl == 2)
        {

        }
        GetLevels2.gameObject.SetActive(true);
        GetLevels2.UpdateLevels();
        GetMoveLayer.gameObject.SetActive(false);
        NextImage.gameObject.SetActive(false);
    }
    public void Nazad()
    {
        if (GetMoveLayer.End() == 2)
        {
            GetMoveLayer.GetDestroyAlls();
            OnEmptySquare();
            //printScores = 0;
            if (modeLvl == 3)
            {
                blockscount = 0;
            }
            else if (modeLvl == 2)
            {

            }
            GetLevels2.gameObject.SetActive(true);
            GetLevels2.UpdateLevels();
            GetMoveLayer.gameObject.SetActive(false);
            NextImage.gameObject.SetActive(false);
            GetMoveLayer.ender();
        }
        else
        {
            OnappMatch();
            NextImage.gameObject.SetActive(false);
            GetButton.SetActive(false);
            GetMoveLayer.ender();
        }
    }
    IEnumerator GetEnumerator()
    {
        while (Limit > 0)
        {
            if ((uint)ltype == 1)
            {
                Limit--;
            }
            if (GetMoveLayer.state != 0) yield break;
            yield return new WaitForSeconds(1);
        }
    }
    public void openLeveltxt(string mapText)
    {
        string[] vs = null;
        string[] lines = mapText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        int mapline = 0;
        foreach (string line in lines)
        {
            if (line.StartsWith("MODE"))
            {
                string modeSting = line.Replace("MODE", string.Empty).Trim();
                t = int.Parse(modeSting);
                modeLvl = int.Parse(modeSting);
            }
            else if (line.StartsWith("SIZE"))
            {
                string blockString = line.Replace("SIZE", string.Empty).Trim();
                string[] sizes = blockString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                MaxX = int.Parse(sizes[0]);
                MaxY = int.Parse(sizes[1]);
                //GetMoveLayer.loadSize(MaxX, MaxY);//
                Arrays.THIS.SizeX = int.Parse(sizes[0]);
                Arrays.THIS.SizeY = int.Parse(sizes[1]);
                Blocksf = new SquareBlocks[MaxY * MaxX];
                for (int i = 0; i < Blocksf.Length; i++)
                {
                    SquareBlocks sqBlocks = new SquareBlocks();
                    sqBlocks.Changeblck(1);//
                    sqBlocks.obstacle = 0;
                    Blocksf[i] = sqBlocks;
                }
            }
            else if (line.StartsWith("LIMIT"))
            {
                string blockString = line.Replace("LIMIT", string.Empty).Trim();
                string[] sizes = blockString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                ltype = int.Parse(sizes[0]);
                Limit = int.Parse(sizes[1]);
            }
            else if (line.StartsWith("COLOR LIMIT "))
            {
                string blockString = line.Replace("COLOR LIMIT", string.Empty).Trim();
                colorLimit = int.Parse(blockString);
            }
            else if (line.StartsWith("STARS"))
            {
                string starsline = line.Replace("STARS", string.Empty).Trim();
                string[] starsNumbers = starsline.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                score1 = int.Parse(starsNumbers[0]);
                score2 = int.Parse(starsNumbers[1]);
                score3 = int.Parse(starsNumbers[2]);
                //if (ProgressBarScript.Instance != null) ProgressBarScript.Instance.InitBar();
            }
            else if (line.StartsWith("COLLECT COUNT"))
            {
                string blocksString = line.Replace("COLLECT COUNT", string.Empty).Trim();
                string[] blocksNumbers = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < blocksNumbers.Length; i++)
                {
                    ingCtar[i] = int.Parse(blocksNumbers[i]);
                }
            }
            else if (line.StartsWith("COLLECT ITEMS"))
            {
                string blocksString = line.Replace("COLLECT ITEMS", string.Empty).Trim();
                string[] blocksNumbers = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < blocksNumbers.Length; i++)
                {
                    if (t == 2) { ingTarget[i] = int.Parse(blocksNumbers[i]); }
                    else if (t == 1) collectItems[i] = int.Parse(blocksNumbers[i]);//
                }//
            }
            else
            {
                string[] st = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < st.Length; i++)
                {
                    Blocksf[(mapline * MaxX) + i].blck=int.Parse(st[i][0].ToString());//
                    Blocksf[(mapline * MaxX) + i].obstacle = int.Parse(st[i][1].ToString());//
                }
                mapline++;
            }
        }
    }
    public void Createblock(int i,int j)//
    {
        GameObject vblck = ((GameObject)Instantiate(blockpref, vector2position + new Vector2(i * blckWH(), j * blckWH()), Quaternion.identity));
        vblck.transform.SetParent(LevelParent.transform);
        blocksp[j * MaxX + i] = vblck.GetComponent<Block>();
        vblck.GetComponent<Block>().row = j;
        vblck.GetComponent<Block>().col = i;
        vblck.GetComponent<Block>().types = 1;
        if (Blocksf[j * MaxX + i].block() == 1)
        {
            Createblck(i, j, vblck,0);
        }
        else if (Blocksf[j * MaxX + i].block() == 0)
        {
            vblck.GetComponent<SpriteRenderer>().enabled = false;
            vblck.GetComponent<Block>().types = 0;
        }
        else if (Blocksf[j * MaxX + i].block() == 2)
        {
            GameObject block = Instantiate(getBlock, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block.transform.SetParent(vblck.transform);
            block.transform.localPosition = new Vector3(0, 0, -0.01f);
            vblck.GetComponent<Block>().block.Add(block);//
            vblck.GetComponent<Block>().types = 2;
            vblck.GetComponent<Block>().modelvlsquare = 3;
            blockscount += 1;
            Createblck(i, j, vblck,2);
        }
        else if (Blocksf[j * MaxX + i].block() == 5)
        {
            GameObject block = Instantiate(getBlock, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block.transform.SetParent(vblck.transform);
            block.transform.localPosition = new Vector3(0, 0, -0.01f);
            vblck.GetComponent<Block>().block.Add(block);
            vblck.GetComponent<Block>().types = 2;
            block = Instantiate(blockpref, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block.transform.SetParent(vblck.transform);
            block.transform.localPosition = new Vector3(0, 0, -0.01f);
            vblck.GetComponent<Block>().block.Add(block);
            vblck.GetComponent<Block>().types = 2;
            block.GetComponent<SpriteRenderer>().sprite = doubleBlock;
            block.GetComponent<SpriteRenderer>().sortingOrder = 1;
            Createblck(i, j, vblck, 0);
        }
    }
    public void Createblck(int i,int j,GameObject vblck,int tp)
    {
        if ((Blocksf[j * MaxX + i].obstacle == 3 && tp == 0) || tp == 3)
        {
            GameObject block1 = Instantiate(PrefabBlock4, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block1.transform.SetParent(vblck.transform);
            block1.transform.localPosition = new Vector3(0, 0, -0.5f);
            vblck.GetComponent<Block>().block.Add(block1);
            vblck.GetComponent<Block>().types = 3;
            block1.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
        else if ((Blocksf[j * MaxX + i].obstacle == 4 && tp == 0) || tp == 4)
        {
            GameObject block1 = Instantiate(PrefabBlock5, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block1.transform.SetParent(vblck.transform);
            block1.transform.localPosition = new Vector3(0, 0, -0.5f);
            vblck.GetComponent<Block>().block.Add(block1);
            block1.GetComponent<SpriteRenderer>().sortingOrder = 3;
            vblck.GetComponent<Block>().types = 4;
            //  TargetBlocks++;
        }
        else if ((Blocksf[j * MaxX + i].obstacle == 6 && tp == 0) || tp == 6)
        {
            GameObject block1 = Instantiate(PrefabBlock7, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block1.transform.SetParent(vblck.transform);
            block1.transform.localPosition = new Vector3(0, 0, -0.5f);
            vblck.GetComponent<Block>().block.Add(block1);
            vblck.GetComponent<Block>().types = 6;
        }
        else if ((Blocksf[j * MaxX + i].obstacle == 7 && tp == 0) || tp == 7)
        {
            GameObject block1 = Instantiate(PrefabBlock8, vector2position + new Vector2(i * blckWH(), -j * blckWH()), Quaternion.identity) as GameObject;
            block1.transform.SetParent(vblck.transform);
            block1.transform.localPosition = new Vector3(0, 0, -0.5f);
            block1.GetComponent<SpriteRenderer>().sortingOrder = 3;
            if (block1.GetComponent<Block>().candy != null)
                Destroy(block1.GetComponent<Block>().candy.gameObject);
            block1.GetComponent<Block>().block.Add(block1);
            block1.GetComponent<Block>().types = 7;
        }
    }
    public void loadLB()
    {
       // NextImage.GetComponent<NextImageScript>().LoadLeaderBoard();
    }
    private void OnGUI()
    {
        bool onmode3block = false;
        if (modeLvl == 0)
        {
            GetText2.gameObject.SetActive(true);
            GetText.gameObject.SetActive(true);
            GetText2.text = string.Format("{0}", TargetScore);
            GetText.text = string.Format("{0}", printScores);
            onmode3block = true;
        }
        else if (modeLvl == 3)
        {
            GetText2.gameObject.SetActive(true);
            GetText.gameObject.SetActive(true);
            GetText2.text = string.Format("{0}", blockscount);
            GetText.text = string.Format("{0}", printScores);
            if (blockscount == 0)
            {
                onmode3block = true;
            }
        }
        else if (modeLvl == 2)
        {
            GetText2.gameObject.SetActive(false);
            GetText.gameObject.SetActive(true);
            IngredientsCountUIText.text = string.Format("{0}", ingCtar[0]);
            IngredientsCountUIText2.text = string.Format("{0}", ingCtar[1]);
            GetText.text = string.Format("{0}", printScores);
            onmode3block = true;
        }
        else if (modeLvl == 1)
        {
            GetText2.gameObject.SetActive(false);
            GetText.gameObject.SetActive(true);
            IngredientsCountUIText.text = string.Format("{0}", ingCtar[0]);
            IngredientsCountUIText2.text = string.Format("{0}", ingCtar[1]);
            GetText.text = string.Format("{0}", printScores);
            if ((int)ltype == 0) onmode3block = true;
        }
        else {
            GetText2.gameObject.SetActive(false);
            GetText.gameObject.SetActive(true);
        }
        if ((uint)ltype == 1)
        {
            GetTextTimer.gameObject.SetActive(true);
            //GetTextTimer.text = string.Format("{0}", Limit);
            GetTextTimer.GetComponent<TimerCount>().limitTypers = 1;
            if (modeLvl == 1 && (Limit == 0|| GetTextTimer.text == "1")) {
                onmode3block = true;
                
            }
        }
        else
        {
            GetTextTimer.gameObject.SetActive(false);
        }
        if (onmode3block == true && printScores != 0 && printScores >= TargetScore && GetMoveLayer.movecount == GetMoveLayer.limitMove && GetMoveLayer.state == 0)
        {
            GetText.text = string.Format("{0}", printScores);
            PlayerPrefs.SetInt(string.Format("{0}", currentlvl + 1), 1);
            NazadButton.gameObject.SetActive(true);
            NextImage.gameObject.SetActive(true);
            NextImage.GetComponent<Animation>().Play();
            SaveBombStripePackage();
            if (printScores >= TargetScore)
            {
                NextImage.GetComponent<NextImageScript>().starPrefab1.SetActive(true);
                //loadLB();
                //GetMoveLayer.ender();
                PlayerPrefs.SetString(string.Format("lvl:{0}", currentlvl), "star1");
                if (printScores >= TargetScore1)
                {
                    NextImage.GetComponent<NextImageScript>().starPrefab2.SetActive(true);
                    PlayerPrefs.SetString(string.Format("lvl:{0}", currentlvl), "star2");
                    if (printScores >= TargetScore2)
                    {
                        NextImage.GetComponent<NextImageScript>().starPrefab3.SetActive(true);
                        PlayerPrefs.SetString(string.Format("lvl:{0}", currentlvl), "star3");
                    }
                    else
                    {
                        NextImage.GetComponent<NextImageScript>().starPrefab3.SetActive(false);
                    }
                }
                else
                {
                    NextImage.GetComponent<NextImageScript>().starPrefab2.SetActive(false);
                    NextImage.GetComponent<NextImageScript>().starPrefab3.SetActive(false);
                }
            }
            else
            {
                NextImage.GetComponent<NextImageScript>().starPrefab1.SetActive(false);
                NextImage.GetComponent<NextImageScript>().starPrefab2.SetActive(false);
                NextImage.GetComponent<NextImageScript>().starPrefab3.SetActive(false);
            }
        }
    }
    bool load12p=false;
    public void LoadLB()
    {
        //PortalNetwork.THIS.SendScoreLevel(currentlvl, printScores);
        //PortalNetwork.THIS.LeaderBoard(currentlvl);
    }
    public void StopAndExit()
    {
        if (Time.timeScale == 1) { Play.text = "Play";
            Time.timeScale = 0; } else { Play.text = "Pause";
            Time.timeScale = 1; }
        if (!pause) { pause = true; } else { pause = false; }
    }
    // Start is called before the first frame update
    void Start()
    {
        GetTextTimer.text = "";
    }
    void RunTimer()
    {
        if (GetTextTimer.text != "" && pause == false && int.Parse(GetTextTimer.text)>0) GetTextTimer.text = (int.Parse(GetTextTimer.text) - 1).ToString();//
        invoker = true;
    }
    bool ISNULL=false;
    internal bool onf7;
    public string urlOnTournament;

    public int StripeGameCount;

    // Update is called once per frame
    void Update()
    {
        if(GetTextTimer.text == "1"&&ISNULL==false)
        {
            nazad2();
            ISNULL = true;
            //GetMoveLayer.movecount = GetMoveLayer.limitMove;
        }
    }
    /*private static IStoreController m_StoreController;
    private bool IsInitialized()
    {
        // Only say we are initialized if both the Purchasing references are set.
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }
    public void BuyProductID(string productId)
    {
        // If the stores throw an unexpected exception, use try..catch to protect my logic here.
        try
        {
            // If Purchasing has been initialized ...
            if (IsInitialized())
            {
                // ... look up the Product reference with the general product identifier and the Purchasing system's products collection.
                Product product = m_StoreController.products.WithID(productId);

                // If the look up found a product for this device's store and that product is ready to be sold ... 
                if (product != null && product.availableToPurchase)
                {
                    Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));// ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed asynchronously.
                    m_StoreController.InitiatePurchase(product);
                }
                // Otherwise ...
                else
                {
                    // ... report the product look-up failure situation  
                    Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
                }
            }
            // Otherwise ...
            else
            {
                // ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or retrying initiailization.
                Debug.Log("BuyProductID FAIL. Not initialized.");
            }
        }
        // Complete the unexpected exception handling ...
        catch (Exception e)
        {
            // ... by reporting any unexpected exception for later diagnosis.
            Debug.Log("BuyProductID: FAIL. Exception during purchase. " + e);
        }
    }*/
}
