using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSparks.Api.Responses;
using GameSparks.Api.Requests;
using System;

public class PortalNetwork : MonoBehaviour
{
    //public static PortalNetwork THIS;
    public string UserID;
    [SerializeField] //public 
        List<string> playerData;
    //[HideInInspector]
    [SerializeField]List<string> plId;
    public List<string> IdManager() { return plId; }
    //public
    [SerializeField]List<string> urlsu;
    public void urlAdd(string url) { urlsu.Add(url); }
    public void urlClear() { urlsu.Clear(); }
    public List<string> urlReturn() { return urlsu; }
    [SerializeField] public static List<LeadboardPlayerData> leadboardPlayerDatas;
    public void addId(string id)
    {
        plId.Add(id);
    }
    private GamesparksDataManager dataManager;
    [SerializeField] NextImageScript GetNextImageScript;
    public void addPData(string playerdata)
    {
        //plId.Add(id);
        playerData.Add(playerdata);
    }
    public List<string> DataManagerList() { return playerData; }
    public void isClear()
    {
        playerData.Clear();
    }
    public bool IsYou(string playFabId)
    {
        return dataManager.IsYou(playFabId);
    }
    public void GetTournamer()
    {
        dataManager.GetTournament();
    }
    private void Awake()
    {
        //THIS = this;
        dataManager = new GamesparksDataManager();
    }
    public void SendScoreLevel(int lvl,int score)
    {
        dataManager.SetPlayerScore(lvl, score);
    }
    public void Addpicture(string dic, string UserIDFriend)
    {
        dataManager.Addpicture(dic, UserIDFriend);//
    }
    public void FriendAddUrl(string url, string UserID)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            { UserID, url }
        };
        dataManager.LoginWithFriends(dic, "getavatars", PlayerPrefs.GetInt("reachedLevelNow"));//
    }
    public void LeaderBoard(int lvl)
    {
        dataManager.LoadLeaderBoardData();
    }
    public void LoadPicture()
    {
        dataManager.LoadPicture();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    internal void GetPlayersTournament()
    {
        //Tournament.tournament.NamesImage.GetComponent<UnityEngine.UI.Image>().sprite = Tournament.tournament.TypeTourSprite[Tournament.tournament.ChooseTournir];
        dataManager.GetCallPhotoTour5();
        GameObject.FindObjectOfType<OpenAppLevel>().StartCoroutine(GetEnumeratorPhoto2());
    }
    IEnumerator GetEnumeratorPhoto2()
    {
        yield return new WaitForSeconds(0.5f);
        //yield return new WaitUntil(() =>  NetworkManager.THIS.IsLoggedIn);
        dataManager.GetCallPhotoTour4((resp4) =>
        {
            if (PortalNetwork.leadboardPlayerDatas.Count > 0)
            {
                for (int k = 0; k < resp4.Count; k++)
                {
                    if (PortalNetwork.leadboardPlayerDatas[k].userID != resp4[k].userID)
                    {
                        PortalNetwork.leadboardPlayerDatas[k].userID = resp4[k].userID;
                        PortalNetwork.leadboardPlayerDatas[k].Name = resp4[k].Name;
                    }
                    for (int l1 = 0; l1 < PortalNetwork.leadboardPlayerDatas.Count; l1++)
                    {
                        if (resp4.Count != PortalNetwork.leadboardPlayerDatas.Count)
                        {
                            if (resp4.Count > PortalNetwork.leadboardPlayerDatas.Count && k > l1)
                            {
                                PortalNetwork.leadboardPlayerDatas.Add(resp4[k]);
                            }
                            else if (resp4.Count < PortalNetwork.leadboardPlayerDatas.Count && k < l1)
                            {
                                PortalNetwork.leadboardPlayerDatas.Remove(PortalNetwork.leadboardPlayerDatas[l1]);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var rk in resp4)
                {
                    PortalNetwork.leadboardPlayerDatas.Add(rk);
                }
            }
        });
    }
    internal void SaveControl()
    {
        dataManager.SaveControl();
    }

    internal void SetTournament()
    {
        string UserIDFriend = PlayerPrefs.GetString("playerIdSave");
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            { "TIMEENTER" , PlayerPrefs.GetString("StartTimer") }//
        };
        dataManager.SetTournament(dic, UserIDFriend, PlayerPrefs.GetString("StartTimer"));
    }
}