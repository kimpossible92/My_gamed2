using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Facebook.Unity;

public class OpLvl : MonoBehaviour {
    //public static OpLvl THIS;
    public MoveLayer GetMoveLayer;
    public static OpLvl _instance;
    [SerializeField]MapLevel2[] GetLevels;
    public EventHandler<LevelProp> LevelSelect;
    public EventHandler<LevelProp> LevelReach;
    public MapLevel2 currentLevel;
    [SerializeField] OpenAppLevel GetManager;
    [SerializeField] GameObject NextImage;
    [SerializeField] GameObject buttonImage;
    public bool IsEnabled;
    // Use this for initialization
    void Start()
    {
        GetLevels = FindObjectsOfType<MapLevel2>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLevels();
        if (Input.GetMouseButtonDown(0))
        {
            var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);
            if (hit.collider != null)
            {
                currentLevel = hit.collider.gameObject.GetComponent<MapLevel2>();
                if (currentLevel.islock == false) {
                    GetManager.lvl(currentLevel.Number);
                    //PortalNetwork.THIS.LeaderBoard(currentLevel.Number);
                    //NextImage.gameObject.SetActive(true);
                    //buttonImage.SetActive(true);
                    FindObjectOfType<OpenAppLevel>().StripeGameCount = 0;
                    GetManager.OnappMatch();
                    GetTargetLoad(currentLevel.Number);
                }
            }
        }
    }
    private void Awake()
    {
        //THIS = this;
    }
    public void GetTargetLoad(int current)
    {
        TextAsset textAsset = (TextAsset)Resources.Load("" + current);
        string[] tagslevel = textAsset.text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        foreach(var tag in tagslevel)
        {
            if(tag.StartsWith("STARS"))
            {
                string starsString = tag.Replace("STARS",string.Empty).Trim();
                string[] stars123 = starsString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                GetManager.selectscores(int.Parse(stars123[0]), int.Parse(stars123[1]), int.Parse(stars123[2]));
            }
            if(tag.StartsWith("LIMIT"))
            {
                string limitsString = tag.Replace("LIMIT", string.Empty).Trim();
                string[] limit12 = limitsString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                GetMoveLayer.movecount = int.Parse(limit12[1]);
                GetMoveLayer.limitMove = int.Parse(limit12[0]);
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="maps"></param>
    /// <returns></returns>
    public List<MapLevel2> GetMaps(MapLevel2[] maps)
    {
        List<MapLevel2> mapLevels = new List<MapLevel2>();
        foreach(MapLevel2 map in maps)
        {
            mapLevels.Add(map);
        }
        return mapLevels;
    }
    void OnSelected(int number)
    {
        if(LevelSelect!=null)
        {
            LevelSelect(_instance, new LevelProp(number));//
        }
        //if (_instance.IsConfirmationEnabled) 
        GOToLevel(number);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    private void OnReached(int number)
    {

        MapLevel2 mapLevel = GetLevels[number];
        if(!string.IsNullOrEmpty(mapLevel.SceneName))
        {

        }
    }
    public static void GOToLevel(int number)
    {

    }
    public void CurrentLevelClicked(MapLevel2 mapLevel)
    {
       
    }
    public void UpdateLevels()
    {
        List<MapLevel2> mapLevels = GetMaps(GetLevels);
        foreach (MapLevel2 map in mapLevels)
        {
        }
    }
    void OnMouseDown()
    {
        if (OnMouseOverOitemEventHandler != null)
        {
            OnMouseOverOitemEventHandler(this);
        }
    }
    public delegate void OnMouseOverOitem(OpLvl o);
    public static event OnMouseOverOitem OnMouseOverOitemEventHandler;
}
public class LevelProp : System.EventArgs
{
    public int Lvl { get; private set; }
    public LevelProp(int lvl)
    {
        Lvl=lvl;
    }
}
