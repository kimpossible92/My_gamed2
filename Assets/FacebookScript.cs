using UnityEngine;
using System.Collections;
using Facebook.Unity;
using Facebook.MiniJSON;
using GameSparks.Api.Requests;
using System.Collections.Generic;
using GameSparks.Core;
using System.Linq;
using UnityEngine.UI;

public class FacebookScript : MonoBehaviour
{
    [SerializeField] Button GetButtonFB;
    public static FacebookScript THIS;
    private string lastResponse = string.Empty;
    protected string LastResponse
    {
        get
        {
            return this.lastResponse;
        }

        set
        {
            this.lastResponse = value;
        }
    }

    private string status = "Ready";

    protected string Status
    {
        get
        {
            return this.status;
        }

        set
        {
            this.status = value;
        }
    }
    public void LoginWithFB(string accessToken)
    {
        new FacebookConnectRequest().SetSwitchIfPossible(true).SetAccessToken(accessToken).Send((response) => {
            if (!response.HasErrors)
            {
                MoveLayer.THIS.Name = response.DisplayName.ToString();//
                GetButtonFB.gameObject.SetActive(false);
                PortalNetwork.THIS.UserID = response.UserId;
                GetPicture(AccessToken.CurrentAccessToken.TokenString);Tournament.joined = true;Tournament.tournament.MenuTounamentClick();
            }
            else
            {
                IDictionary<string, object> errors = response.Errors.BaseData;
                Debug.Log("Authentification error:");
                foreach (var item in errors)
                {
                    if (item.Key == "error" && item.Value.ToString() == "timeout")
                    {
                        if (GS.Available)
                        {
                            GS.Reset();
                        }
                    }
                }
            }
        });
    }
    public void CallFBInit()
    {
        FB.Init(OnInitComplete, OnHideUnity);
    }
    private void Awake()
    {
        THIS = this;
    }
    private void OnInitComplete()
    {
        Debug.Log("FB.Init completed: Is user logged in? " + FB.IsLoggedIn);

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetPicture(AccessToken.CurrentAccessToken.TokenString);
        }
    }
    private void OnHideUnity(bool isGameShown)
    {
        Debug.Log("Is game showing? " + isGameShown);
    }
    protected void HandleResult(IResult result)
    {
        if (result == null)
        {
            this.LastResponse = "Null Response\n";
            Debug.Log(this.LastResponse);
            return;
        }
        if (!string.IsNullOrEmpty(result.Error))
        {
            this.Status = "Error - Check log for details";
            this.LastResponse = "Error Response:\n" + result.Error;
            Debug.Log(result.Error);
        }
        else if (result.Cancelled)
        {
            this.Status = "Cancelled - Check log for details";
            this.LastResponse = "Cancelled Response:\n" + result.RawResult;
            Debug.Log(result.RawResult);
        }
        else if (!string.IsNullOrEmpty(result.RawResult))
        {
            this.Status = "Success - Check log for details";
            this.LastResponse = "Success Response:\n" + result.RawResult;
            LoginWithFB(AccessToken.CurrentAccessToken.TokenString);
        }
        else
        {
            this.LastResponse = "Empty Response\n";
            Debug.Log(this.LastResponse);
        }
    }
    public void GetPicture(string id)
    {
        FB.API("/" + id + "/picture?g&width=128&height=128&redirect=false", HttpMethod.GET, this.ProfilePhotoCallback);//2.1.4		
    }
    private void ProfilePhotoCallback(IGraphResult result)
    {
        if (string.IsNullOrEmpty(result.Error))//2.1.4
        {
            var dic = result.ResultDictionary["data"] as Dictionary<string, object>;
            string url = dic.Where(i => i.Key == "url").First().Value as string;
            print(url);
            MoveLayer.THIS.urlOnTournament = url;
            StartCoroutine(loadPicture(url));
        }

    }
    IEnumerator loadPicture(string url)
    {
        WWW www = new WWW(url);
        yield return www;
        var texture = www.texture;
        var sprite = Sprite.Create(texture, new Rect(0, 0, 128, 128), new Vector2(0, 0), 1f);print(url);
        string url1 = url.Replace("https://platform-lookaside.fbsbx.com/platform/profilepic/?", string.Empty);//
        PortalNetwork.THIS.Addpicture(url1, PortalNetwork.THIS.UserID);
        yield return new WaitForSeconds(0.5f);//
        PortalNetwork.THIS.LoadPicture();
    }
    public void fBvoid()//
    {
        FB.LogInWithReadPermissions(new List<string>() { "public_profile", "email", "user_friends" }, this.HandleResult);
    }
    // Use this for initialization
    void Start()
    {
        CallFBInit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
