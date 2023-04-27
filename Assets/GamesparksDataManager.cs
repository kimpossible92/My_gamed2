using UnityEngine;
using System.Collections;
using GameSparks.Api.Requests;
using GameSparks.Core;
using System.Collections.Generic;
using GameSparks.Api.Responses;
using System;

public class GamesparksDataManager : IDataManager
{
    private string userID;

    public void LoadLeaderBoardData()
    {
        new LeaderboardDataRequest().SetLeaderboardShortCode("Level.Level." + GameObject.FindObjectOfType<OpenAppLevel>().currentLevel()).SetDontErrorOnNotSocial(true).SetEntryCount(10).Send((response) =>
        {
            if (!response.HasErrors)
            {
                foreach (GameSparks.Api.Responses.LeaderboardDataResponse._LeaderboardData entry in response.Data)
                {
                    GameObject.FindObjectOfType<PortalNetwork>().addPData(entry.UserId+"$"+entry.UserName + " :" + entry.JSONData["Score"].ToString());
                }
            }
            else
            {
                Debug.Log("Error Retrieving friends Data...");
            }
        });
    }
    public void GetCallPhotoTour4(Action<List<LeadboardPlayerData>> Callback)
    {
        string dayStripe = "Fields.division." + GameObject.FindObjectOfType<Tournament>().division;
        //new LeaderboardDataRequest_Stripe1().
        new LeaderboardDataRequest().SetLeaderboardShortCode(dayStripe).SetEntryCount(1000).Send((resp1) => {
            if (!resp1.HasErrors)
            {
                List<LeadboardPlayerData> friendDatas = new List<LeadboardPlayerData>();
                foreach (var item1 in resp1.Data)
                {
                    LeadboardPlayerData playerData = new LeadboardPlayerData();
                    playerData.userID = item1.UserId;
                    playerData.Name = Tournament.urlpredicate + item1.JSONData["TRACK"].ToString();
                    //Debug.Log(Tournament.urlpredicate + item1.TRACK);
                    //TounamentLB.THIS.playerNames.Add(item1.Rank + ":" + item1.UserName + "- " + item1.Stripe);
                    friendDatas.Add(playerData);

                    /*if (item1.UserId == "5be8b796fc37de04ee99c3ca")
                    {
                        Tournament.tournament.TimeToString = item1.When.ToString();
                        Tournament.tournament.NotLimitTimer();
                        Tournament.tournament.TimeParse(item1.When.ToString());
                    }
                    */
                }
                Callback(friendDatas);
            }
        });
    }

    public void SetTournament(Dictionary<string, string> dic, string UserIDFriend, string entryTime)
    {
        new GameSparks.Api.Requests.LogEventRequest()
        .SetEventKey("LoadTurnir")
        .SetEventAttribute("NameTurnir", Tournament.title)
        .SetEventAttribute("EnterTime", entryTime)
        .SetEventAttribute("Name", PlayerPrefs.GetString("playerNameSave"))
        .SetEventAttribute("GHOST_DATA", GSJson.To(dic))
        .SetEventAttribute("Score2", 0).SetEventAttribute("EnterQuit", "1").Send((response) =>
        {
            if (!response.HasErrors)
            {
                Debug.Log("Score Saved To GameSparks...");
            }
            else
            {
                Debug.LogError("Error Saving Score Data...");
            }
        });
    }//
    public void GetCallPhotoTour5()
    {
        NewsTournir();
        CallNews();
        bool callme = false;
        int loadint2 = 0;
        string dayStripe = "Fields.division." + GameObject.FindObjectOfType<Tournament>().division;
        //new LeaderboardDataRequest_Stripe1().SetIncludeLast(10).SetEntryCount(1000).Send((resp1) =>        
        new LeaderboardDataRequest().SetLeaderboardShortCode(dayStripe).SetEntryCount(1000).Send((resp1) =>
        {
            if (!resp1.HasErrors)
            {
                foreach (var item1 in resp1.Data)
                {
                    GameObject.FindObjectOfType<TournamentLB>().playerUrls.Add(Tournament.urlpredicate + item1.JSONData["TRACK"].ToString());
                    //TounamentLB.THIS.playerNames.Add(item1.Rank + ":" + item1.UserName + "$" + item1.UserId);
                    GameObject.FindObjectOfType<TournamentLB>().playerNames.Add(item1.UserName+":"+ item1.JSONData["score"].ToString() + "$");Debug.Log(item1.UserName);
                    GameObject.FindObjectOfType<TournamentLB>().ListScores.Add(int.Parse(item1.JSONData["score"].ToString()));
                    if (GameObject.FindObjectOfType<PortalNetwork>().IsYou(item1.UserId))
                    {
                        callme = true;
                        GameObject.FindObjectOfType<Tournament>().Rank = item1.Rank;
                        Tournament.TourScore = int.Parse(item1.JSONData["score"].ToString());
                    }
                }
                if (!callme && PlayerPrefs.GetInt("TourQual") > 0 && Facebook.Unity.FB.IsLoggedIn)
                {
                    //TounamentLB.THIS.playerNames.Add((TounamentLB.THIS.playerNames.Count+1) + ":" + "YOU$");
                    //TounamentLB.THIS.AddName((TounamentLB.THIS.playerNames.Count + 1) + ":" + "YOU$");
                    GameObject.FindObjectOfType<TournamentLB>().callme = true;
                    //TounamentLB.THIS.ListScores.Add(PlayerPrefs.GetInt("TourQual"));
                }
                else GameObject.FindObjectOfType<TournamentLB>().callme = false;
            }
            else
            {
                //TounamentLB.THIS.playerNames.Add((TounamentLB.THIS.playerNames.Count + 1) + ":" + "Bot");
                //TounamentLB.THIS.ListScores.Add(100);
            }
        });
    }
    public void NewsTournir()
    {
        new LeaderboardDataRequest_News1().SetEntryCount(10).Send((resp2) =>
        {
            foreach (var k in resp2.Data_News1)
            {
                if (GameObject.FindObjectOfType<Tournament>().changeID == "" && k.Rank == 1)//k.UserId == "5be8b796fc37de04ee99c3ca")
                {
                    //Tournament.tournament.division = k.Division;
                    GameObject.FindObjectOfType<Tournament>().league = k.league;
                    //Debug.Log(k.league +":"+ Tournament.tournament.division);
                    GameObject.FindObjectOfType<Tournament>().TimeToString = k.When.ToString();
                    GameObject.FindObjectOfType<Tournament>().NotLimitTimer();
                    //Tournament.tournament.TimeParse(k.When.ToString());
                }
                if (GameObject.FindObjectOfType<Tournament>().changeID == "5c73f1c92a42c805098a5349" && k.UserId == "5c73f1c92a42c805098a5349" && GameObject.FindObjectOfType<PortalNetwork>().IsYou(k.UserId))
                {
                    //Tournament.tournament.division = k.Division;
                    GameObject.FindObjectOfType<Tournament>().league = k.league;
                    Debug.Log(k.league + ":" + GameObject.FindObjectOfType<Tournament>().division);
                    GameObject.FindObjectOfType<Tournament>().TimeToString = k.When.ToString();
                    GameObject.FindObjectOfType<Tournament>().NotLimitTimer();
                    //Tournament.tournament.TimeParse(k.When.ToString());
                }
            }
        });
        new LogEventRequest_TryTimer2()
            .Send((respose1) =>
            {
                //Debug.Log(respose1.ScriptData.ToString());
                var cursor = respose1.ScriptData.BaseData;
                foreach (var i in cursor)
                {
                    //Tournament.tournament.Timer1 = i.Value.ToString();
                    GameObject.FindObjectOfType<Tournament>().TimeParseAll(i.Value.ToString(), i.Key.ToString());
                    //Debug.Log(i.Value.ToString());
                }

            });
    }
    public void CallNews()
    {
        new LogEventRequest()
            .SetEventKey("AttributesNews")
            .SetEventAttribute("TRACK", Tournament.title)
            .Send((respmessage) =>
            {
                string valueplus = "";
                var cursor = respmessage.ScriptData.BaseData;
                foreach (var i in cursor)
                {
                    foreach (var p in respmessage.ScriptData.GetGSData(i.Key).BaseData)
                    {
                        valueplus += p.Key + ":" + p.Value + "; ";
                    }
                }
                //Debug.Log(valueplus);
            });
    }
    public void GetTournament()
    {
        new GameSparks.Api.Requests.LogEventRequest()
            .SetEventKey("TourTime")
            .SetEventAttribute("TRACK", Tournament.title)
            .SetEventAttribute("TIME", 0)//
            .Send((response) =>
            {
                if (!response.HasErrors)
                {
                    GettingTournamentData(response);
                }
                else
                {

                }
            });
        new GameSparks.Api.Requests.LogEventRequest()
            .SetEventKey("GetLoadTour")
            .SetEventAttribute("TRACK", "PackageLeaderTour")
            //.SetEventAttribute("TIME", 0)
            .Send((response) =>
            {
                if (!response.HasErrors)
                {
                    GettingTournamentData2(response);
                }
                else
                {

                }
            });
    }
    public void GettingTournamentData2(LogEventResponse response)
    {
        var res1 = new GSData();
        var res2 = new GSData();
        Dictionary<string, string> dicBoost = new Dictionary<string, string>();
        var cursor = response.ScriptData.BaseData;
        res1 = null;
        res2 = null;
        foreach (var c in cursor)
        {
            res1 = response.ScriptData.GetGSData(c.Key);
            foreach (var k in res1.BaseData)
            {
                if (k.Key == "trackName")
                {

                }
                if (k.Key == "timeTaken")
                {
                }
                if (k.Key == "ghostData")
                {
                    res2 = (GSData)k.Value;
                    foreach (var tt in res2.BaseData)
                    {
                        if (tt.Key == "Tour")
                        {
                            GameObject.FindObjectOfType<Tournament>().TypeTourString[0] = tt.Value.ToString();
                        }
                        if (tt.Key == "TypeTour")
                        {
                            GameObject.FindObjectOfType<Tournament>().TypeTourString[1] = tt.Value.ToString();
                        }
                    }
                }
            }
        }
    }
    public void GettingTournamentData(LogEventResponse response)
    {
        var res1 = new GSData();
        var res2 = new GSData();
        //Debug.Log("Getting Keys");
        Dictionary<string, string> dicBoost = new Dictionary<string, string>();
        bool SendMail = false;
        bool SpendMail = false;
        var cursor = response.ScriptData.BaseData;
        if (cursor == null)
        {
            Debug.Log("notdata");
            return;
        }
        res1 = null;
        res2 = null;
        foreach (var c in cursor)
        {
            //Debug.Log(c.Key.ToString());
            if (GameObject.FindObjectOfType<PortalNetwork>().IsYou(c.Key.ToString()))
            {//
                if (!GameObject.FindObjectOfType<OpenAppLevel>().onf7) Tournament.joined = true;
                string idtime = "5be8b796fc37de04ee99c3ca";
                //Debug.Log(c.Key.ToString());
                //Debug.Log(c.Key.ToString());
                res1 = response.ScriptData.GetGSData(idtime);//

                foreach (var k in res1.BaseData)
                {
                    if (k.Key == "trackName")
                    {

                    }
                    if (k.Key == "timeTaken")
                    {
                        //Debug.Log(k.Value.ToString());
                        //TimeParse(k.Value.ToString());//
                    }
                    if (k.Key == "timeEnd")
                    {
                        //TimeParse3(k.Value.ToString());
                    }
                    if (k.Key == "ghostData")
                    {
                        string outTime = k.Value.ToString();//
                    }
                    if (k.Key == "Name")
                    {
                        //TounamentLB.THIS.playerNames.Add(k.Value.ToString());
                        //Debug.Log(k.Value.ToString());
                    }
                }
            }
            else { }
        }
    }
    public void LoadPicture()
    {
        new LeaderboardDataRequest_urlsLast()
            .SetEntryCount(10).Send((response) => {
            if (!response.HasErrors)
            {
                    foreach (var entry in response.Data_urlsLast)
                    {
                        GameObject.FindObjectOfType<PortalNetwork>().urlAdd(entry.userid+"$"+"https://platform-lookaside.fbsbx.com/platform/profilepic/?" + entry.url);
                    }
                    NextImageScript.THIS.LoadPlayerPicture();
            }
            else
            {
            }
        });
    }
    public bool IsYou(string id)
    {
        bool meorNot = false;
        if (id == GameObject.FindObjectOfType<PortalNetwork>().UserID)
            return true;
        else if (meorNot) { return true; }
        return false;
    }
    public void Addpicture(string dic, string UserIDFriend)
    {
        new LogEventRequest().SetEventKey("urlscore")
            .SetEventAttribute("userid", UserIDFriend)
            .SetEventAttribute("url", dic).Send((response) => {
                if (!response.HasErrors)
                {
                }
                else
                {
                }
            });
    }
    public void SetPlayerScore(int level, int score)
    {
        new GameSparks.Api.Requests.LogEventRequest()
            .SetEventKey("Level")
            .SetEventAttribute("Level", level).SetEventAttribute("Score", score).Send((response) =>
            {
                if (!response.HasErrors)
                {
                    Debug.Log("Score Saved To GameSparks...");
                }
                else
                {
                    Debug.Log("Error Saving Score Data...");
                }
            });
    }
    public void LoginWithFriends(Dictionary<string, string> dic, string UserIDFriend, int levelpl)
    {
        //addurlplayer
        string url1 = GameObject.FindObjectOfType<MoveLayer>().urlOnTournament.Replace("https://platform-lookaside.fbsbx.com/platform/profilepic/?", string.Empty);
        new LogEventRequest()
            .SetEventKey("addurlplayer")
            .SetEventAttribute("url", url1)
            .Send((request_data) => { if (request_data.HasErrors) { Debug.Log("error"); } });
        new LogEventRequest()
            .SetEventKey("allplayers")
            .SetEventAttribute("GHOST_DATA", GSJson.To(dic))
            .SetEventAttribute("TRACK", UserIDFriend)
            .SetEventAttribute("TIME", levelpl)//
            .Send((request_data) =>
            {
                if (request_data.HasErrors)
                {
                    Debug.Log("error");
                }
                else
                {
                    //Debug.Log(GSJson.To(dic) + ":" + UserIDFriend);
                    PlayerPrefs.SetInt("myurlsave", 1);
                }
            });
    }
    public void SaveControl()
    {
        string url1 = GameObject.FindObjectOfType<OpenAppLevel>().urlOnTournament.Replace(Tournament.urlpredicate, string.Empty);
        new LogEventRequest_InputScore()
            .Set_TRACK(url1)
            .Set_score(GameObject.FindObjectOfType<OpenAppLevel>().StripeGameCount)
            .Set_league(GameObject.FindObjectOfType<Tournament>().league)
            .Set_division((long)GameObject.FindObjectOfType<Tournament>().division)
            .Set_date(DateTime.Now.ToString()).Send((resp12) =>
            {

            });
        if (PlayerPrefs.GetInt("sum1") == 0)
        {
            new LogEventRequest_InputScore()
                .Set_TRACK(url1)
                .Set_score(0)
                .Set_league(GameObject.FindObjectOfType<Tournament>().league)
                .Set_division((long)GameObject.FindObjectOfType<Tournament>().division)
                .Set_date(DateTime.Now.ToString()).Send((resp12) =>
                {
                    PlayerPrefs.SetInt("sum1", 1);
                });
        }
    }
}
