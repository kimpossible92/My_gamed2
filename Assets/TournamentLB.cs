using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class TournamentLB : MonoBehaviour
{
    //public static TournamentLB THIS;
    [SerializeField] public GameObject LoginFB;
    [SerializeField] public List<FriendData> playersData;
    [SerializeField] RectTransform StartPostion;
    [SerializeField] RectTransform StartPosition2;
    [SerializeField] Text GetTextPlayer;
    [SerializeField] public List<Sprite> PlayerPhoto;
    [SerializeField] public List<string> playerUrls;
    [SerializeField] public List<string> playerNames;
    [SerializeField] public static List<LeadboardPlayerData> leadboardPlayerDatas;
    [SerializeField] public static string IdIsYou;
    [HideInInspector] public static bool INActive = false;
    [SerializeField] Image GetImagePhoto;
    [SerializeField] public List<GameSparks.Api.Responses._LeaderboardEntry_Tour1> _LeaderboardEntry_Tour1;
    [HideInInspector] public bool INActive2 = false;
    [SerializeField] public Transform Content;
    [SerializeField] public IDictionary<string, Sprite> dicBoosts;
    [SerializeField] public GameObject Voznagrazhdenie;
    [SerializeField] public List<int> ListScores;
    [SerializeField]
    Text FailedName;
    GameObject MyScore;
    public List<GameObject> plist;
    public bool callme = false;
    int falseScore;
    public static int bots = 0;
    // Use this for initialization
    public void changefalseScore(int score)
    {
        falseScore = score;//
    }
    public bool playerCount()
    {
        if (playerNames.Count <= 0) return true;
        else return false;
    }
    public void Cleared()
    {
        if (GameObject.FindObjectOfType<TournamentLB>().playerNames != null)
        {
            playerNames.Clear();
        }
    }
    private void OnEnable()
    {
        if (playerNames.Count > 1 || ListScores.Count > 1)
        {
            DestoyList();
        }
        Content.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
//#if FACEBOOK
        if(Facebook.Unity.FB.IsLoggedIn)
        StartCoroutine(WaitForLeadboard());
        StartCoroutine(OnLoad());

//#endif
    }
    internal void AddName(string v)
    {
        throw new NotImplementedException();
    }

    void Start()
    {

    }
    public int Randize()
    {
        //return Random.Range(300, 500);
        return falseScore;
    }
    IEnumerator OnLoad()
    {
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => playerNames.Count > 0);
        int k2 = 1;
        for (int plurl = 0; plurl < PortalNetwork.leadboardPlayerDatas.Count; plurl++)
        {
            GameObject p1 = (GameObject)Instantiate(GetImagePhoto.gameObject);
            p1.transform.SetParent(Content.transform);
            if (TournamentLB.bots == 1) p1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(StartPosition2.anchoredPosition.x, 288f - 60 * k2, 0);
            else p1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(StartPosition2.anchoredPosition.x, StartPosition2.anchoredPosition.y - 60 * k2, 0);
            //print(NetworkManager.leadboardPlayerDatas[plurl].Name);
            //Sprite sprite1 = null;
            k2 += 1;
            if (PortalNetwork.leadboardPlayerDatas[plurl].Name == playerUrls[plurl])
            {
                StartCoroutine(loadImageTournir(PortalNetwork.leadboardPlayerDatas[plurl].Name, p1.GetComponent<playerImage>(), PortalNetwork.leadboardPlayerDatas[plurl]));
                if (PortalNetwork.leadboardPlayerDatas[plurl].picture == null)
                {
                    PortalNetwork.leadboardPlayerDatas[plurl].picture = p1.GetComponent<playerImage>().GetSprite;
                }
                else
                {
                    p1.GetComponent<playerImage>().GetSprite = PortalNetwork.leadboardPlayerDatas[plurl].picture;
                }
            }
            else
            {
                PortalNetwork.leadboardPlayerDatas[plurl].Name = playerUrls[plurl];
                StartCoroutine(loadImageTournir(PortalNetwork.leadboardPlayerDatas[plurl].Name, p1.GetComponent<playerImage>(), PortalNetwork.leadboardPlayerDatas[plurl]));
                p1.GetComponent<playerImage>().GetSprite = PortalNetwork.leadboardPlayerDatas[plurl].picture;
            }
            //p1.GetComponent<playerImage>().GetSprite = sprite1;

            plist.Add(p1);
        }
        //yield return new WaitUntil(() => Tournament.tournament.Rank!=null);
        if (name == "TournamentWindow")
        {
            if (System.DateTime.Now.DayOfWeek.ToString() == "Sunday")
            {
                //Debug.Log(DateTime.Now.DayOfWeek.ToString());
            }
            else
            {
                Voznagrazhdenie.SetActive(false);
            }
        }
    }

    internal void OnSwitch()
    {
        if (Facebook.Unity.FB.IsLoggedIn)
        StartCoroutine(WaitForLeadboard());
        StartCoroutine(OnLoad());
    }

    internal void TourEndMethod()
    {
        throw new NotImplementedException();
    }

    IEnumerator loadImageTournir(string url, playerImage image, LeadboardPlayerData l1)
    {
        WWW www = new WWW(url);
        yield return www;

        var texture = www.texture;

        var sprite = Sprite.Create(texture, new Rect(0, 0, 128, 128), new Vector2(0, 0), 1f);
        //PlayerPhoto.Add(sprite);
        image.GetSprite = sprite;
        l1.picture = sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator WaitForLeadboard()
    {
        plist.Clear();
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => playerNames.Count > 0);
        int k = 1;
        int k4 = 1;

        foreach (var pk in ListScores)
        {
            GameObject k2 = (GameObject)Instantiate(GetTextPlayer.gameObject);
            if (name == "TournamentWindow") k2.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentWindow").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            else k2.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentTasks").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            k2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(230, StartPostion.anchoredPosition.y - 60 * k4, 0);
            k2.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            /*if (name == "TournamentTasks" && pk.ToString() == "0")
            {
                k2.GetComponent<Text>().text = "";
            }
            else*/
            k2.GetComponent<Text>().text = pk.ToString();
            k2.transform.SetParent(Content);
            plist.Add(k2);
            k4 += 1;
        }
        foreach (var pln in playerNames)
        {
            string[] readId = pln.Split(new string[] { "$" }, System.StringSplitOptions.RemoveEmptyEntries);
            GameObject p = (GameObject)Instantiate(GetTextPlayer.gameObject);
            GameObject tt = (GameObject)Instantiate(GetTextPlayer.gameObject);
            if (name == "TournamentWindow") p.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentWindow").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            else p.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentTasks").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            p.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(StartPostion.anchoredPosition.x, StartPostion.anchoredPosition.y - 60 * k, 0);
            p.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            /*if(name== "TournamentTasks" && pln == playerNames.Count+":YOU")
            {
                p.GetComponent<Text>().text = "";
            }
            else*/
            p.GetComponent<Text>().text = readId[0];
            tt.transform.SetParent(Content); tt.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-188, StartPostion.anchoredPosition.y - 60 * k, 0);//
            tt.GetComponent<Text>().text = "" + k;//
            tt.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            p.transform.SetParent(Content);
            //p.transform.Find("slot").gameObject.SetActive(true);
            plist.Add(p);
            k += 1;
        }
        if (GameObject.FindObjectOfType<TournamentLB>().callme == true)
        {
            GameObject plocal = (GameObject)Instantiate(GetTextPlayer.gameObject);
            if (name == "TournamentWindow") plocal.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentWindow").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            else plocal.transform.SetParent(GameObject.Find("CanvasGlobal").transform.Find("TournamentTasks").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport"));
            plocal.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(StartPostion.anchoredPosition.x, StartPostion.anchoredPosition.y - 60 * (playerNames.Count + 1), 0);
            plocal.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            plocal.GetComponent<Text>().text = "You" + ":" + PlayerPrefs.GetInt("TourQual");
            plocal.transform.SetParent(Content);
            //plocal.transform.Find("slot").gameObject.SetActive(true);
            GameObject tt = (GameObject)Instantiate(GetTextPlayer.gameObject);
            tt.transform.SetParent(Content); tt.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-188, StartPostion.anchoredPosition.y - 60 * (k + 0), 0);//
            tt.GetComponent<Text>().text = "" + (k + 0);//
            tt.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            plist.Add(plocal.gameObject);//
        }
    }

    public void DestoyList()
    {
        if (plist != null)
        {
            playerNames.Clear();
            playerUrls.Clear();
            ListScores.Clear();
            //NetworkManager.leadboardPlayerDatas.Clear();
        }
        foreach (var item in plist)//
        {
            //if (item != null)
            Destroy(item);
        }
        //StartCoroutine(WaitDelete());
        //Destroy(GameObject.Find("CanvasGlobal").transform.Find("TournamentWindow").transform.Find("Image").transform.Find("Scroll View").transform.Find("Viewport").transform.Find(GetTextPlayer.gameObject.name+"(Clone)"));
    }
}

public class FriendData
{
}
public class LeadboardPlayerData
{
    public string Name;
    public string userID;
    public int position;
    public int score;
    public Sprite picture;
    public FriendData friendData;
    // 1.3.3
}
