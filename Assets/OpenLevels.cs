using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class OpenLevels : MonoBehaviour {
    [HideInInspector]public int modeLvl=0;
    public Image TargetBlockImage;
    [SerializeField] Image NextImage;
    [HideInInspector]
    public int TargetScore;
    public int TargetScore1;
    public int TargetScore2;
    bool UnlockMyCheats=false;
    [SerializeField] Button NazadButton;
    //Sprite getSprite;
    string LockedLevelTag="locked";
    [HideInInspector] public int printScores=0;
    [SerializeField] OpLvl GetLevels2;
    [SerializeField] Arrays GetArrays;
    [SerializeField] MoveLayer GetMoveLayer;
    public int[] ingrCountTarget = new int[2];
    public int star1;
    public int star2;
    public int star3;
    public int[] ingTarget = new int[2];
    public int[] collectItems = new int[2];
    public int currentLevel = 1;
    public float squareWidth=0.8f;
    public float squareHeight=0.8f;
    public int maxCols=9;
    public int maxRows=5;
    [SerializeField] GameObject blockObject;
    [SerializeField] GameObject ingrObject;
    [SerializeField] GameObject squarePrefab;
    public Vector2 firstSquarePosition;
    [SerializeField] GameObject GameField;
    public SquareBlocks[] levelSquareFile = new SquareBlocks[81];
    public Block[] squaresArray;
    public int TargetBlocks;
    public bool levelLoaded;
    public int target;
    public int limitType;
    public int Limit = 30;
    public int colorLimit;
    [SerializeField] private GameObject wireBlockPrefab;
    [SerializeField] private GameObject solidBlockPrefab;
    [SerializeField] private GameObject undesroyableBlockPrefab;
    [SerializeField] private GameObject thrivingBlockPrefab;
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private Sprite doubleBlock;
    [SerializeField] Text GetText;
    public Sprite squareSprite1;
    [SerializeField] Text GetText2;
    public Sprite GetSpriteMode1;
    int ingredient1Count;
    int ingredient2Count;
    [HideInInspector]public int blockscount=0;
    [SerializeField] GameObject IngredientsCountImage;
    [SerializeField]
    GameObject IngredientsCountImage2;
    [SerializeField] Text IngredientsCountUIText;
    [SerializeField]
    Text IngredientsCountUIText2;
    public Sprite[] GetSpritesFromItem;
    [SerializeField] Text GetTextTimer;
    // Use this for initialization
    public void LoadLevel()
    {
        LoadDataFromLocal(currentLevel);   
    }

    void Start () {
        GetMoveLayer.gameObject.active = false;
	}
    /// <summary>
    /// начало уровня
    /// </summary>
    public void OnStartMatch()
    {
        NazadButton.gameObject.active = false;
        GetMoveLayer.gameObject.active = true;
        LoadLevel();
        //GetMoveLayer.restarting();
        GetLevels2.gameObject.SetActive(false);
        //getSprite = squaresArray[maxCols / 2 * maxRows / 2].GetComponent<SpriteRenderer>().sprite;
        NextImage.gameObject.active = false;
        if (modeLvl == 3)
        {
            TargetBlockImage.gameObject.SetActive(true);
            IngredientsCountImage.SetActive(false);
        }
        else if(modeLvl==2)
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(true);
            IngredientsCountImage2.SetActive(true);
            GetMoveLayer.IngredientPosition(ingrCountTarget[0], ingrCountTarget[1]);
            GetText2.gameObject.SetActive(false);
        }
        else if(modeLvl==1)
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(true);
            IngredientsCountImage2.SetActive(true);
            GetText2.gameObject.SetActive(false);
            IngredientsCountImage.GetComponent<Image>().sprite = GetSpritesFromItem[(int)collectItems[0]];
            IngredientsCountImage2.GetComponent<Image>().sprite = GetSpritesFromItem[(int)collectItems[1]];
            if ((uint)limitType == 1 && GetMoveLayer.state == 0)
            {
                StopCoroutine(GetEnumerator());
                StartCoroutine(GetEnumerator());
            }
        }
        else
        {
            TargetBlockImage.gameObject.SetActive(false);
            IngredientsCountImage.SetActive(false);
        }
        
    }
    public void GetPause()
    {
        if ((uint)limitType == 1 && GetMoveLayer.state == 0)
        {
            StopCoroutine(GetEnumerator());
            StartCoroutine(GetEnumerator());
        }
        else
        {
            StopCoroutine(GetEnumerator());
        }
    }
    public bool IsNull(int row,int col)
    {
        if (row == 0 && col == 0 || row == maxRows - 1 && col == maxCols - 1 || row == 0 && col == maxCols - 1 || row == maxRows - 1 && col == 0)
        {
            return true;
        }
        return false;
    }
    void PrepareToGame()
    {
        TargetBlocks = 0;
        for (int row = 0;row<maxRows;row++)
        {
            for(int col=0;col<maxCols;col++)
            {
                
            }
        }
    }
    
    List<Block> GetSquare2s = new List<Block>();
	// Update is called once per frame
	void Update () {
        if (UnlockMyCheats == true) { UnlockCheats(); }
        if(Input.GetKeyDown(KeyCode.LeftShift)) { UnlockMyCheats = true; }
        if (Input.GetKeyDown(KeyCode.RightShift)) { UnlockMyCheats = false; }
        if (Input.GetKeyDown(KeyCode.Escape)) { Nazad(); }
        
    }
    IEnumerator GetEnumerator()
    {
        while(Limit>0)
        {
            if ((uint)limitType == 1)
            {
                Limit--;
            }
            if (GetMoveLayer.state != 0) yield break;
            yield return new WaitForSeconds(1);
        }
    }
    /// <summary>
    /// читерство
    /// </summary>
    void UnlockCheats()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            for (int i = 0; i < 101; i++)
            {
                PlayerPrefs.SetInt(string.Format("{0}", i), 0);
                PlayerPrefs.SetString(string.Format("lvl:{0}", i), "");
                GetLevels2.UpdateLevels();
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            for (int i = 0; i < 101; i++)
            {
                PlayerPrefs.SetInt(string.Format("{0}", i), 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            printScores = TargetScore;
            GetMoveLayer.movecount = 0;
        }
    }
    void InitTargets()
    {
        blockObject.SetActive(false);
        ingrObject.SetActive(false);
    }
    public void LoadDataFromLocal(int currentLevel)
    {
        levelLoaded = false;
        TextAsset mapText = Resources.Load(""+currentLevel) as TextAsset;
        TextAsset mapText2 = Resources.Load("Levels/" + currentLevel) as TextAsset;       
        if (mapText==null)
        {
            mapText = Resources.Load(""+currentLevel) as TextAsset;
        }
        if (mapText2 == null)
        {
            mapText2 = Resources.Load("Levels/" + currentLevel) as TextAsset;
        }
        ProcessGameDataFromString(mapText.text);
        loadruleLevel(mapText2.text);
    }
    /// <summary>
    /// длина,ширина мод, цели и т.д.
    /// </summary>
    /// <param name="mapText"></param>
    public void ProcessGameDataFromString(string mapText)
    {
        string[] vs=null;
        string[] lines = mapText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        int mapline = 0;
        foreach(string line in lines)
        {
            if (line.StartsWith("MODE"))
            {
                string modeSting = line.Replace("MODE", string.Empty).Trim();
                target = int.Parse(modeSting);
                modeLvl = int.Parse(modeSting);
            }
            else if (line.StartsWith("SIZE"))
            {
                string blockString = line.Replace("SIZE", string.Empty).Trim();
                string[] sizes = blockString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                maxCols = int.Parse(sizes[0]);//9
                maxRows = int.Parse(sizes[1]);//5
                GetArrays.SizeX = int.Parse(sizes[0]);
                GetArrays.SizeY = int.Parse(sizes[1]);
                squaresArray = new Block[maxCols * maxRows];
                levelSquareFile = new SquareBlocks[maxRows * maxCols];
                for (int i = 0; i < levelSquareFile.Length; i++)
                {
                    SquareBlocks sqBlocks = new SquareBlocks();
                    //sqBlocks = 1;//
                    //sqBlocks.obstacle = SquareTypes.NONE;
                    levelSquareFile[i] = sqBlocks;
                }
            }
            else if (line.StartsWith("LIMIT"))
            {
                string blockString = line.Replace("LIMIT", string.Empty).Trim();
                string[] sizes = blockString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                limitType = int.Parse(sizes[0]);
                Limit = int.Parse(sizes[1]);
            }
            else if (line.StartsWith("COLOR LIMIT "))
            {
                string blockString = line.Replace("COLOR LIMIT", string.Empty).Trim();
                colorLimit = int.Parse(blockString);
            }
            else if(line.StartsWith("STARS"))
            {
                string blockString = line.Replace("STARS", string.Empty).Trim();
                string[] blocksNumbers = blockString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                star1 = int.Parse(blocksNumbers[0]);
                star2 = int.Parse(blocksNumbers[1]);
                star3 = int.Parse(blocksNumbers[2]);
                //if (ProgressBarScript.Instance != null) ProgressBarScript.Instance.InitBar();
            }
            else if(line.StartsWith("COLLECT COUNT"))
            {
                string blocksString = line.Replace("COLLECT COUNT", string.Empty).Trim();
                string[] blocksNumbers = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                for(int i =0;i<blocksNumbers.Length; i++)
                {
                    ingrCountTarget[i] = int.Parse(blocksNumbers[i]);
                }
            }
            else if(line.StartsWith("COLLECT ITEMS"))
            {
                string blocksString = line.Replace("COLLECT ITEMS", string.Empty).Trim();
                string[] blocksNumbers = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < blocksNumbers.Length; i++)
                {
                    if (target == 0) { ingTarget[i] = int.Parse(blocksNumbers[i]); }
                    else if (target == 1) collectItems[i] = int.Parse(blocksNumbers[i]);
                }
            }
            else
            {
                /*string[] st = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < st.Length; i++)
                {
                    //levelSquareFile[mapline * maxCols + i].block = (SquareTypes)int.Parse(st[i][0].ToString());
                    //levelSquareFile[mapline * maxCols + i].obstacle = (SquareTypes)int.Parse(st[i][1].ToString());
                }*/
                mapline++;
            }            
        }
        
        levelLoaded = true;
    }
    public void loadruleLevel(string mapText)
    {
        string[] vs = null;
        string[] lines = mapText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        int mapline = 0;
        foreach (string line in lines)
        {
            string[] st = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < st.Length; i++)
            {
                levelSquareFile[mapline * maxCols + i].blck = int.Parse(st[i][0].ToString());
                levelSquareFile[mapline * maxCols + i].obstacle = int.Parse(st[i][1].ToString());//
            }
            mapline++;
        }
    }
    public void Nazad()
    {
        GetMoveLayer.GetDestroyAlls();
        printScores = 0;
        if (modeLvl == 3) blockscount = 0;
        else if (modeLvl == 2)
        {

        }
        GetLevels2.gameObject.active = true;
        GetLevels2.UpdateLevels();
        GetMoveLayer.gameObject.active = false;
        NextImage.gameObject.active = false;

    }
    /// <summary>
    /// UI system
    /// </summary>
    void OnGUI()
    {
        bool onmode3block = false;
        if (modeLvl ==0)
        {
            GetText2.text = string.Format("{0}", TargetScore);
            GetText.text = string.Format("{0}", printScores);
            onmode3block = true;
        }
        else if(modeLvl==3)
        {
            GetText2.text = string.Format("{0}", blockscount);
            GetText.text = string.Format("{0}", printScores);
            if(blockscount==0)
            {
                onmode3block = true;
            }
        }
        else if(modeLvl==2)
        {
            IngredientsCountUIText.text = string.Format("{0}", ingrCountTarget[0]);
            IngredientsCountUIText2.text = string.Format("{0}", ingrCountTarget[1]);
            GetText.text = string.Format("{0}", printScores);
            onmode3block = true;
        }
        else if(modeLvl==1)
        {
            IngredientsCountUIText.text = string.Format("{0}", ingrCountTarget[0]);
            IngredientsCountUIText2.text = string.Format("{0}", ingrCountTarget[1]);
            GetText.text = string.Format("{0}", printScores);
            if((int)limitType==0) onmode3block = true;
        }
        if((uint)limitType==1)
        {
            GetTextTimer.gameObject.SetActive(true);
            GetTextTimer.text = string.Format("{0}", Limit);
            GetTextTimer.GetComponent<TimerCount>().limitTypers = 1;
            if (modeLvl == 1&&Limit==0) { onmode3block = true; GetMoveLayer.movecount = GetMoveLayer.limitMove; }
        }
        else
        {
            GetTextTimer.gameObject.SetActive(false);
        }
        if (onmode3block==true&&printScores!=0&&printScores >= TargetScore&&GetMoveLayer.movecount==GetMoveLayer.limitMove&&GetMoveLayer.state==0)
        {
            GetText.text = string.Format("{0}", printScores);
            PlayerPrefs.SetInt(string.Format("{0}", currentLevel+1), 1);
            NazadButton.gameObject.active = true;
            NextImage.gameObject.active = true;
            NextImage.GetComponent<Animation>().Play();
            if (printScores >= TargetScore)
            {
                NextImage.GetComponent<NextImageScript>().starPrefab1.active = true;
                PlayerPrefs.SetString(string.Format("lvl:{0}", currentLevel), "star1");
                if (printScores >= TargetScore1)
                {
                    NextImage.GetComponent<NextImageScript>().starPrefab2.active = true;
                    PlayerPrefs.SetString(string.Format("lvl:{0}", currentLevel), "star2");
                    if (printScores >= TargetScore2)
                    {
                        NextImage.GetComponent<NextImageScript>().starPrefab3.active = true;
                        PlayerPrefs.SetString(string.Format("lvl:{0}", currentLevel), "star3");
                    }
                    else
                    {
                        NextImage.GetComponent<NextImageScript>().starPrefab3.active = false;
                    }
                }
                else
                {
                    NextImage.GetComponent<NextImageScript>().starPrefab2.active = false;
                    NextImage.GetComponent<NextImageScript>().starPrefab3.active = false;
                }
            }
            else
            {
                NextImage.GetComponent<NextImageScript>().starPrefab1.active = false;
                NextImage.GetComponent<NextImageScript>().starPrefab2.active = false;
                NextImage.GetComponent<NextImageScript>().starPrefab3.active = false;
            }
        }
        
    }
}