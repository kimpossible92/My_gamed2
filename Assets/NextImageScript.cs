using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextImageScript : MonoBehaviour {
    public static NextImageScript THIS;
    public GameObject starPrefab1;
    public GameObject starPrefab2;
    public GameObject starPrefab3;
    List<playerseed> playerseeds;
    bool stop = false;
    [SerializeField] GameObject ScrollView;
    [SerializeField] GameObject Content;
    [SerializeField] RectTransform StartPostion;
    [SerializeField] Text GetTextsLB;
    [SerializeField] List<string> plId;
    [SerializeField]List<Text> listPlayers;
    [SerializeField] Image GetImage;
    public void LoadPlayerPicture()
    {
        foreach(var hurl in GameObject.FindObjectOfType<PortalNetwork>().urlReturn())
        {
            string[] vs12 = hurl.Split(new string[] { "$" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach(var iurl in plId)
            {
                if (vs12[0] == iurl)
                {
                    StartCoroutine(loadPicture(vs12[0],vs12[1]));
                }
            }
        }
    }
    private void Awake()
    {
        THIS = this;
    }
    // Use this for initialization
    void Start()
    {

    }
    IEnumerator loadPicture(string id,string url)
    {
        WWW www = new WWW(url);
        yield return www;

        var texture = www.texture;

        var sprite = Sprite.Create(texture, new Rect(0, 0, 128, 128), new Vector2(0, 0), 1f);
        playerseed plseed = new playerseed();
        plseed.idplayer = id;
        plseed.spritepl = sprite;
        playerseeds.Add(plseed);
    }
    // Update is called once per frame
    void Update()
    {
        //LoadLeaderBoard();
    }
    public void GetStartOnAnimation()
    {

    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {
    }
    public void kl0()
    {
        GameObject.FindObjectOfType<PortalNetwork>().isClear();
        GameObject.FindObjectOfType<PortalNetwork>().urlClear(); //
        foreach(var lp in listPlayers)
        {
          if(lp!=null) Destroy(lp.gameObject);
        }
        //listPlayers.Clear();
        k = 0;
    }
    int k = 0;
    public void LoadLeaderBoard()
    {
        if (GameObject.FindObjectOfType<PortalNetwork>().DataManagerList().Count!=0&&k < GameObject.FindObjectOfType<PortalNetwork>().DataManagerList().Count)
        {
            foreach(var item in GameObject.FindObjectOfType<PortalNetwork>().DataManagerList())//
            {
                string[] vsSplit = item.Split(new string[] { "$" }, System.StringSplitOptions.RemoveEmptyEntries);
                GameObject p = (GameObject)Instantiate(GetTextsLB.gameObject);
                plId.Add(vsSplit[0]);
                p.GetComponent<Text>().text = vsSplit[1];
                p.transform.SetParent(Content.transform);//
                p.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(StartPostion.anchoredPosition.x + (145 * k), StartPostion.anchoredPosition.y, 0);
                listPlayers.Add(p.GetComponent<Text>());
                if (k == GameObject.FindObjectOfType<PortalNetwork>().DataManagerList().Count - 1)
                {
                    //PortalNetwork.THIS.LoadPicture();
                }
                k = k + 1;
            }
        }
    }
}
public class playerseed
{
    public string idplayer;
    public Sprite spritepl;
}