using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine.UI;

public class Tournament : MonoBehaviour
{
    public static Tournament tournament;
    [SerializeField] public string TimeToString;
    [SerializeField] public List<LeadboardPlayerData> GetData;
    [SerializeField] public string[] TypeTourString;
    [SerializeField] public Sprite[] TypeTourSprite;
    [SerializeField] public int ChooseTournir;
    [SerializeField] public GameObject NamesImage;
    [SerializeField] public static string urlpredicate = "https://platform-lookaside.fbsbx.com/platform/profilepic/?";
    [Header("Время начала турнира")]
    [SerializeField] public static string ServerEndTime;
    [SerializeField] public int year = 2019, month, day, hour, min, sec;
    //[Header("Название турнира")]
    [SerializeField] public static string title = "Изумрудный город";        //название турнира
    [SerializeField] DateTime PlayerPrefsNextBonusGameTime = new DateTime(); //время начала турнира
    [SerializeField] DateTime NewStateTime;
    [SerializeField] DateTime EndTournamentTime = new DateTime();            //время конца  турнира
    [SerializeField] DateTime rezervedTime = new DateTime();
    public static int TourScore = 0;                        //турнирные очки
    string days;
    public static bool tournamentActivated;                 //если true - турнир активируется. а true/false зависит от таймера
    [SerializeField] public static bool joined;                              //уже вступил в турнир - активируются Турнирные очки в наградах за пройденный уровень

    [SerializeField]
    public GameObject JoinButton;                           //кнопка вступить в турнир
    [SerializeField]
    public GameObject JoinButtonOff;                        //имитация кнопки, которая не работает, заменяется кнопкой JoinButton, когда турнир начался

    public Text myScore;                                    //Tournament score
    public Text tournamentTitle;                            //Название турнира
    public Text TimerTxt;                                   //показывает время начала/конца турнира
    public Text StartEndTimeTxt;                            //текст "закончится через"/"начнется через"

    TextMeshProUGUI Join;
    TextMeshProUGUI Joined;
    [SerializeField] public GameObject TourametWindow;
    [SerializeField] public GameObject TournamentTask;
    [SerializeField] public long? Rank;
    [SerializeField] Text GetTextRank;
    [SerializeField]
    Text TimerTxt2;
    [SerializeField]
    Text TimerTxt3;
    [SerializeField]
    Text TimerTxt4;
    [SerializeField]
    Text TimerTxtQual;
    [SerializeField] public static string shortCodeData = "Stripe1.SNAPSHOT.2019-03-10";
    [SerializeField] public long? division;
    [SerializeField] public string league;
    [SerializeField] public GameObject TournamentQualification;
    [SerializeField] public GameObject CheckQualification;
    [SerializeField] public string changeID = "";//
    [SerializeField] public bool loadChangeName = false;
    [SerializeField] public bool loadCloudOne = false;
    [SerializeField] public string Timer1;

    private void OnEnable()
    {

    }
    public void TimeParseAll(string timeParse1, string timeParse2)
    {
        string[] time34 = timeParse2.Split(new string[] { "-", "T", "Z", ":" }, StringSplitOptions.RemoveEmptyEntries);
        if (DateTime.UtcNow.DayOfWeek.ToString() == "Monday")
        {
            TournamentLB.THIS.TourEndMethod();
            //print(DateTime.UtcNow.DayOfWeek.ToString());
        }
        if (time34.Length > 0)
        {
            int realYear = int.Parse(time34[0]);
            int realmonth = int.Parse(time34[1]);
            int realday = int.Parse(time34[2]);
            string[] time12 = timeParse1.Split(new string[] { "^" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var t12 in time12)
            {
                //print(t12);
            }
            bool save1 = false;
            if (time12.Length > 0)
            {
                if (!save1 && realday == 28 || realday == 29 || realday == 30 || realday == 31)//
                {
                    Tournament.tournament.division = int.Parse("" + realYear + realmonth + 1); print("division" + Tournament.tournament.division);
                    if (realmonth == 12)
                    {
                        year = realYear + 1;
                        month = 1;
                    }
                    else { month = realmonth + 1; year = realYear; }
                    day = int.Parse(time12[0]);//1
                    hour = 0;
                    min = 0;
                    sec = 0;
                    EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
                    save1 = true;
                    TournamentLB.THIS.changefalseScore(300);
                    return;
                }
                else if (!save1 && realday == 1 || realday == 2 || realday == 3 || realday == 4 || realday == 5 || realday == 6 || realday == 7)
                {
                    Tournament.tournament.division = int.Parse("" + realYear + realmonth + 2); print("division" + Tournament.tournament.division);
                    year = realYear;
                    month = realmonth;
                    day = int.Parse(time12[1]);//8
                    hour = 0;
                    min = 0;
                    sec = 0;
                    EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
                    save1 = true; TournamentLB.THIS.changefalseScore(366);
                    return;
                }
                else if (!save1 && realday == 8 || realday == 9 || realday == 10 || realday == 11 || realday == 12 || realday == 13 || realday == 14)
                {
                    Tournament.tournament.division = int.Parse("" + realYear + realmonth + 3); print("division" + Tournament.tournament.division);
                    year = realYear;
                    month = realmonth;
                    day = int.Parse(time12[2]);//15
                    hour = 0;
                    min = 0;
                    sec = 0;
                    EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
                    save1 = true; TournamentLB.THIS.changefalseScore(312);
                    return;
                }
                else if (!save1 && realday == 15 || realday == 16 || realday == 17 || realday == 18 || realday == 19 || realday == 20 || realday == 21)
                {
                    Tournament.tournament.division = int.Parse("" + realYear + realmonth + 4); print("division" + Tournament.tournament.division);
                    year = realYear;
                    month = realmonth;
                    day = int.Parse(time12[3]);//22
                    hour = 0;
                    min = 0;
                    sec = 0;
                    EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
                    save1 = true; TournamentLB.THIS.changefalseScore(456);
                    return;
                }
                else if (!save1 && realday == 22 || realday == 23 || realday == 24 || realday == 25 || realday == 26 || realday == 27)
                {
                    Tournament.tournament.division = int.Parse("" + realYear + realmonth + 5); print("division" + Tournament.tournament.division);
                    year = realYear;
                    month = realmonth;
                    day = int.Parse(time12[4]);//28
                    hour = 0;
                    min = 0;
                    sec = 0;
                    EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
                    save1 = true; TournamentLB.THIS.changefalseScore(580);
                    return;
                }
            }
        }
    }
    public void TimeParse(string timeParse)
    {
        string[] time12 = timeParse.Split(new string[] { "-", "T", "Z", ":" }, StringSplitOptions.RemoveEmptyEntries);
        if (time12.Length > 0)
        {
            year = int.Parse(time12[0]);
            month = int.Parse(time12[1]);
            day = int.Parse(time12[2]) + 8;
            hour = int.Parse(time12[3]);
            min = int.Parse(time12[4]);
        }
        EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
    }
    void Start()
    {
        Join = JoinButtonOff.GetComponentInChildren<TextMeshProUGUI>();
        Joined = JoinButtonOff.GetComponentInChildren<TextMeshProUGUI>();
        title = "Изумрудный город";
        tournament = this;
        PlayerPrefsNextBonusGameTime = new DateTime(year, month, day, hour, min, sec);            //пока что вводится в испекторе, время начала турнира(не через какое время)
        EndTournamentTime = new DateTime(2019, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59); //тестовое время завершения турнира, сегодея в 23:59:59
        joined = false;                                                                           //тут надо поменять на ссылку joined = Server.joined; потом сохранить на сервер = true; и при входе проверить и синхронизировать этот bool
        rezervedTime = new DateTime(2019, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        //tournamentActivated = true;                                                             //TEMP потом надо убрать это поле, имитирует как будто Турнир уже начался
        TimerTxt = TimerTxt.GetComponent<Text>();
        TournamentLB.THIS = Tournament.tournament.TournamentTask.GetComponent<TournamentLB>();
    }
    public void nextTour()
    {
        if (ChooseTournir == 0)
        {
            ChooseTournir = 2;
            title = "город алмазов";
            //LevelManager.THIS.SaveBombStripePackage();
            MenuTounamentClick();
        }/*
        else if(ChooseTournir == 2)
        {
            ChooseTournir = 1;
            title = "Изумрудный город";
        }/* */
        else if (ChooseTournir == 2)
        {
            ChooseTournir = 0;
            title = "Изумрудный город";
            //LevelManager.THIS.SaveBombStripePackage();
            MenuTounamentClick();
        }
        PlayerPrefs.SetString("savetitle", title);
        PlayerPrefs.SetInt("savechoose", ChooseTournir);
    }
    public void NextTournamentStart()
    {
        string[] time12 = Timer1.Split(new string[] { "-", "T", "Z", ":", "." }, StringSplitOptions.RemoveEmptyEntries);
        if (time12.Length > 0)
        {
            DateTime timeServer = new DateTime(int.Parse(time12[0]), int.Parse(time12[1]), int.Parse(time12[2]), int.Parse(time12[3]), int.Parse(time12[4]), 0);
            if (EndTournamentTime <= timeServer)
            {
                print("hjkashdkjahsdkjahskd");
            }
            if (TimeLeftToEnd.Days * (-1) < 0 || TimeLeftToEnd.Hours * (-1) < 0 || TimeLeftToEnd.Minutes * (-1) < 0 || TimeLeftToEnd.Seconds * (-1) < 0)
            {
                if (EndTournamentTime <= timeServer)
                {
                    //TounamentLB.THIS.TourEndMethod();
                    /*day += 8;
                    division += 1;
                    new GameSparks.Api.Requests.LogEventRequest_TournamentNews()
                        .Set_NameTurnir(title)
                        .Set_league("bronze")
                        .Set_Division((long)division)
                        .Send((request) => { });*/
                }
            }
        }
    }
    public void MenuTounamentClick()
    {
        TournamentLB.THIS.DestoyList();
        //Tournament.joined = false;
        //if (Facebook.Unity.FB.IsLoggedIn)//&&(PlayerPrefs.GetInt("Gems")>15||Tournament.joined))
        //{
        PortalNetwork.THIS.GetTournamer();//
        PortalNetwork.THIS.GetPlayersTournament();//
        //}
        Tournament.tournament.kubokButton();
        //TourametWindow.GetComponent<TounamentLB>().OnSwitch();
        //TounamentLB.THIS.OnSwitch();
        //TounamentLB.THIS.OnSwitch();
    }
    bool load = false;
    void Update()
    {
        if (TimeLeftToEnd.Days * (-1) == 0 && TimeLeftToEnd.Hours * (-1) == 0 && TimeLeftToEnd.Minutes * (-1) == 0 && TimeLeftToEnd.Seconds * (-1) == 0)
        {
            tournamentTitle.text = "Турнир изумрудного города окончен";
        }
        else tournamentTitle.text = title;       //название турнира вводится с инспектора (потом с сервера будет вводиться)

        BonusGame();                        //смотрит истёк ли таймер
        myScore.text = string.Format("Ваши турнирные очки: {0}", TourScore);
        TimerTxt4.text = "" + PlayerPrefs.GetInt("TourQual") + "/" + 10;
        if (tournamentActivated && !joined) //если еще не нажал Join
        {
            JoinButton.SetActive(true);
            JoinButtonOff.SetActive(false);
        }
        else
        {
            JoinButton.SetActive(false);
            JoinButtonOff.SetActive(true);
        }
        if (joined)
        {
            //JoinButtonOff.GetComponentInChildren<Text>().text = "J O I N E D";
            Joined.text = "В турнире";
        }
        else Join.text = "Войти";
        //joined = (bool) 1 ;
        /*if (PlayerPrefs.GetInt(title) == 0)
        {
            joined = false;
        }
        else joined = true;*/
        //JoinButtonOff.GetComponentInChildren<Text>().text = "J O I N";
        GetTextRank.text = Rank.ToString();
        if (!load && Facebook.Unity.FB.IsLoggedIn)
        {
            //NetworkManager.friendsManager.LoadLigin();
            load = true;//
        }
        if (!Facebook.Unity.FB.IsLoggedIn)
        {
            TimerTxt2.text = "";
        }
        if (PlayerPrefs.GetInt("TourQual") >= 10)
        {
            CheckQualification.GetComponent<Image>().enabled = false;
        }
    }
    public void NotLimitTimer()
    {
        //DateTime time1 = DateTime.Now;
        //PlayerPrefsNextBonusGameTime = time1.AddDays(-0.1f);
        //EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
    }
    /// <summary>
    /// 
    /// </summary>
    public void kubokButton()
    {
        //NetworkManager.THIS.LoginLoadTimer1();
        EndTournamentTime = new DateTime(year, month, day, hour, min, sec);
        PlayerPrefs.SetString("savetitle", title);
        PlayerPrefs.SetInt("savechoose", ChooseTournir);
        if (Facebook.Unity.FB.IsLoggedIn && Tournament.joined) NextTournamentStart();

    }
    /// <summary>
    /// 
    /// </summary>
    public void JoinTournament() //вызывается кнопкой Join
    {
        joined = true;
        PortalNetwork.THIS.SetTournament();
        PlayerPrefsNextBonusGameTime.ToString();
        PlayerPrefs.SetInt(title, 1);
    }

    public void BonusGame()
    {
        if (DateTime.Now > PlayerPrefsNextBonusGameTime) //если таймер истёк и турнир начался
        {
            tournamentActivated = true;
            StartEndTimeTxt.text = "Закончится через";
            ShowTimerEnd();
            //PlayerPrefsNextBonusGameTime = DateTime.Now.AddHours(4);
            //NewStateTime = new DateTime().
        }
        else
        {
            StartEndTimeTxt.text = "Начнется через";
            ShowTimer();
        }
    }
    public TimeSpan TimeLeftToBonusGame
    {
        get
        {
            return DateTime.Now - PlayerPrefsNextBonusGameTime;
        }
    }
    TimeSpan TimeLeftToEnd
    {
        get
        {
            return DateTime.UtcNow - EndTournamentTime;
        }
    }
    TimeSpan reservMyTimer => DateTime.Now - rezervedTime;

    public Text TimerTxt31
    {
        get
        {
            return TimerTxt3;
        }

        set
        {
            TimerTxt3 = value;
        }
    }

    public void TournamentEndTime(int month, int days)
    {
        EndTournamentTime = new DateTime(2019, month, days, 23, 59, 59);
    }

    public void ShowTimer() //выводит время до начала турнира
    {
        TimerTxt.text = string.Format("{0:00} days {1:00}:{2:00}:{3:00}", TimeLeftToBonusGame.Days * (-1), TimeLeftToBonusGame.Hours * (-1), TimeLeftToBonusGame.Minutes * (-1), TimeLeftToBonusGame.Seconds * (-1));
    }
    private void ShowTimerEnd() //выводит время до конца турнира
    {
        if (TimeLeftToEnd.Days * (-1) > 0)
        {
            if (TimeLeftToEnd.Days * (-1) == 1)
            {
                days = "день";
            }
            else if (TimeLeftToEnd.Days * (-1) >= 2 && TimeLeftToEnd.Days * (-1) <= 4)
            {
                days = "дня";
            }
            else if (TimeLeftToEnd.Days * (-1) > 4)
            {
                days = "дней";
            }
            else days = "дней";

            TimerTxt.text = string.Format("{0:00} " + days + " {1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
            if (!Facebook.Unity.FB.IsLoggedIn)
            {
                TimerTxt2.text = "";
            }
            else
            {
                TimerTxt2.text = string.Format("{0:00} " + days + " {1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
            }
            TimerTxt3.text = ""; //string.Format("{0:00} " + days + " {1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
            TimerTxtQual.text = string.Format("{0:00} " + days + " {1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
        }
        else
        {
            TimerTxt.text = string.Format("{1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
            if (!Facebook.Unity.FB.IsLoggedIn)
            {
                TimerTxt2.text = "";
            }
            else
            {
                TimerTxt2.text = string.Format("{1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));

            }
            TimerTxt3.text = "";//string.Format("{1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
            TimerTxtQual.text = string.Format("{1:00}:{2:00}:{3:00}", TimeLeftToEnd.Days * (-1), TimeLeftToEnd.Hours * (-1), TimeLeftToEnd.Minutes * (-1), TimeLeftToEnd.Seconds * (-1));
        }
        if (TimeLeftToEnd.Days * (-1) < 0 || TimeLeftToEnd.Hours * (-1) < 0 || TimeLeftToEnd.Minutes * (-1) < 0 || TimeLeftToEnd.Seconds * (-1) < 0)
        {
            rezervedTime = new DateTime(2019, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            TimerTxt.text = string.Format("{1:00}:{2:00}:{3:00}", reservMyTimer.Days * (-1), reservMyTimer.Hours * (-1), reservMyTimer.Minutes * (-1), reservMyTimer.Seconds * (-1));
            TimerTxt2.text = string.Format("{1:00}:{2:00}:{3:00}", reservMyTimer.Days * (-1), reservMyTimer.Hours * (-1), reservMyTimer.Minutes * (-1), reservMyTimer.Seconds * (-1));
            TimerTxt3.text = string.Format("{1:00}:{2:00}:{3:00}", reservMyTimer.Days * (-1), reservMyTimer.Hours * (-1), reservMyTimer.Minutes * (-1), reservMyTimer.Seconds * (-1));
            TimerTxtQual.text = string.Format("{1:00}:{2:00}:{3:00}", reservMyTimer.Days * (-1), reservMyTimer.Hours * (-1), reservMyTimer.Minutes * (-1), reservMyTimer.Seconds * (-1));
        }
    }
}
