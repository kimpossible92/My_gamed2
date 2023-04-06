using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine;

public class UIPlayfab : MonoBehaviour
{
    [SerializeField] GameObject signUpTab, logInTab, startPanel, HUD;
    public Text username, userEmail, userPassword, userEmailLogIn, userPasswordLogIn, errorSignUp, errorLogIn;
    string encryptedPassword;
    bool IsAuthenticated = false;
    [SerializeField] int Blocks = 0;
    [SerializeField] string _DisplayName = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SignUpTab()
    {
        signUpTab.SetActive(true);
        logInTab.SetActive(false);
        errorSignUp.text = "";
        errorLogIn.text = "";
    }
    public void LogInTab()
    {
        signUpTab.SetActive(false);
        logInTab.SetActive(true);
        errorSignUp.text = "";
        errorLogIn.text = "";
    }
    string Encrypt(string pass)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
        bs = x.ComputeHash(bs);
        System.Text.StringBuilder s = new System.Text.StringBuilder();
        foreach(var b in bs)
        {
            s.Append(b.ToString("x2").ToLower());
        }
        return s.ToString();
    }
    public void SignUp()
    {
        RegisterPlayFabUserRequest registerRequest = new RegisterPlayFabUserRequest();
        registerRequest.Email = userEmail.text;
        registerRequest.Password = Encrypt(userPassword.text);
        registerRequest.Username = username.text;
        PlayFabClientAPI.RegisterPlayFabUser(registerRequest,RegisterSuccess,RegisterFailer);
    }
    public void LogIn()
    {
        LoginWithEmailAddressRequest registerRequest = new LoginWithEmailAddressRequest();
        registerRequest.Email = userEmailLogIn.text;
        registerRequest.Password = Encrypt(userPasswordLogIn.text);
        //registerRequest.Username = username.text;
        PlayFabClientAPI.LoginWithEmailAddress(registerRequest, result=> 
        {
            errorSignUp.text = "";
            errorLogIn.text = "";
            IsAuthenticated = true;
            Blocks = result.InfoResultPayload.UserVirtualCurrency["BL"];
            _DisplayName = registerRequest.InfoRequestParameters.GetUserAccountInfo.ToString();
        }, LogInFailer);
    }
    public void LogInSuccess(LoginResult result)
    {
        errorSignUp.text = "";
        errorLogIn.text = "";
        StartGame();
    }
   
    public void BuyItem(string ItemID)
    {
        PurchaseItemRequest itemRequest = new PurchaseItemRequest();
        itemRequest.CatalogVersion = "PlayerAbilitys";
        itemRequest.ItemId = ItemID;
        itemRequest.VirtualCurrency = "BL";
        itemRequest.Price = 100;
        GetUserInventoryRequest ir = new GetUserInventoryRequest();
        PlayFabClientAPI.GetUserInventory(ir, result =>
         {
             List<ItemInstance> itemsInstance = result.Inventory;
             foreach(var i in itemsInstance)
             {
                 if(i.ItemId == ItemID)
                 {
                     Debug.Log("user owners: "+ i.DisplayName);
                 }
                 else
                 {
                     PlayFabClientAPI.PurchaseItem(itemRequest, result2 =>
                     {
                         Blocks -= 10;
                         Debug.Log("Item Purchased: " + result2.Items[0].DisplayName);
                     }, err => 
                     {
                     
                     });
                 }
             }
         },error=> { });
    }
    public void LogInFailer(PlayFabError error)
    {
        errorLogIn.text = error.GenerateErrorReport(); IsAuthenticated = false;
    }

    public void RegisterSuccess(RegisterPlayFabUserResult result)
    {
        errorSignUp.text = "";
        errorLogIn.text = "";
        StartGame();
    }
    public void RegisterFailer(PlayFabError error)
    {
        errorSignUp.text = error.GenerateErrorReport();
    }
    public void LogInError(PlayFabError error)
    {
        errorLogIn.text = error.GenerateErrorReport();
        StartGame();
    }
    void StartGame()
    {
        startPanel.SetActive(false);
        HUD.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
