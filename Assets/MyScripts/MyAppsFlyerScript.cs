using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using AppsFlyerSDK;
using System;
using UnityEngine.SceneManagement;


public class MyAppsFlyerScript : MonoBehaviour, IAppsFlyerConversionData
{
    public GameObject af;
    public string devKey = "4ux8wjmC9qP6qc3UWZ5Ldh";
    public string appId = "1534996322";
    public string userInviteOneLinkId;
    public string cuid;
    public bool useUDL = false;
    public bool useATT = false;
    public bool disableSKAd = false;
    public int attDuration = 60;
    public Text gcd;
    public Text deeplink;  
    public string apiSceneName;
    public int DelaySdkStartTime = 0;
    public int DelaySdkInitTime = 0;


    void Start()
    {
        InitAppsFlyerSDK();

    }

private void onSDKStarted(){
     AppsFlyer.OnRequestResponse += (sender, args) =>
    {
        var af_args = args as AppsFlyerRequestEventArgs;
        if(af_args.statusCode == 200){
        Dictionary<string, string> eventValues = new Dictionary<string, string>();
        eventValues.Add("af_id", "12345");
        AppsFlyer.sendEvent("first_open", eventValues);
    }

};
}

 void  InitAppsFlyerSDK(){

 	
#if UNITY_IOS && !UNITY_EDITOR
    if(useATT)
        AppsFlyeriOS.waitForATTUserAuthorizationWithTimeoutInterval(attDuration);
    if(disableSKAd)
        AppsFlyeriOS.disableSKAdNetwork(true);

#endif

    	// These fields are set from the editor so do not modify!
        //******************************//
        AppsFlyer.setIsDebug(true);
        AppsFlyer.initSDK(devKey, appId, this);
        //******************************//
        if(useUDL)
        	AppsFlyer.OnDeepLinkReceived += OnDeepLink;

        if(!String.IsNullOrEmpty(userInviteOneLinkId))
            AppsFlyer.setAppInviteOneLinkID(userInviteOneLinkId);

        if(!String.IsNullOrEmpty(cuid))
            AppsFlyer.setCustomerUserId(cuid);

         onSDKStarted();

         


	if(DelaySdkStartTime > 0)
		StartCoroutine(DelaySdkStartUp());
	else
    	AppsFlyer.startSDK();
}


IEnumerator DelaySdkStartUp()  //  <-  its a standalone method
{
	string msg = "SDK start id delayed in " + DelaySdkStartTime + " sec" ;
    Toast( msg);
    yield  return new WaitForSeconds(DelaySdkStartTime);
    AppsFlyer.startSDK();

}


    private void Toast(string msg){
        SSTools.ShowMessage(msg, SSTools.Position.bottom, SSTools.Time.twoSecond);

    }


 void OnDeepLink(object sender, EventArgs args)
    {
        var deepLinkEventArgs = args as DeepLinkEventsArgs;

        switch (deepLinkEventArgs.status)
        {
            case DeepLinkStatus.FOUND:

                if (deepLinkEventArgs.isDeferred())
                {
                    AppsFlyer.AFLog("OnDeepLink", "This is a deferred deep linkn\n" +DeepLinkEventsArgsToString(deepLinkEventArgs));
                    Toast("OnDeepLink (UDL): This is a deferred deep link" );
                     deeplink.text = "OnDeepLink (UDL): This is a deferred deep link\n" + DeepLinkEventsArgsToString(deepLinkEventArgs);

                }
                else
                {
                    AppsFlyer.AFLog("OnDeepLink", "This is a direct deep linkn\n" + DeepLinkEventsArgsToString(deepLinkEventArgs));
                    Toast("OnDeepLink (UDL): This is a direct deep link" );
                     deeplink.text = "OnDeepLink (UDL): This is a direct deep link\n" + DeepLinkEventsArgsToString(deepLinkEventArgs);

                }

                break;
            case DeepLinkStatus.NOT_FOUND:
                AppsFlyer.AFLog("OnDeepLink", "Deep link not found");
                Toast("OnDeepLink (UDL): eep link not found" );
                 deeplink.text = "OnDeepLink (UDL): eep link not found";

                break;
            default:
                AppsFlyer.AFLog("OnDeepLink", "Deep link error");
                Toast("OnDeepLink (UDL): Deep link error" );
                 deeplink.text = "OnDeepLink (UDL): Deep link error";
                break;
        }
    }


    // Mark AppsFlyer CallBacks
    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("didReceiveConversionData", conversionData);
        Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
        gcd.text = conversionData;
        // add deferred deeplink logic here
    }

    public void onConversionDataFail(string error)
    {
        AppsFlyer.AFLog("didReceiveConversionDataWithError", error);
                gcd.text = error;

    }

    public void onAppOpenAttribution(string attributionData)
    {
        Toast("onAppOpenAttribution: " + attributionData);
         printDebugLog("onAppOpenAttribution: " + attributionData);
        AppsFlyer.AFLog("[Paz] onAppOpenAttribution", attributionData);
        Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
        deeplink.text = attributionData;
        // add direct deeplink logic here
    }

    public void onAppOpenAttributionFailure(string error)
    {
        Toast("onAppOpenAttributionFailure: " + error);
        printDebugLog("onAppOpenAttributionFailure: " + error);
        AppsFlyer.AFLog("[PAZ] onAppOpenAttributionFailure", error);
        deeplink.text = error;

    }


    public void logEvent(){
        Dictionary<string, string> eventValues = new Dictionary<string, string>();
        eventValues.Add(AFInAppEvents.CURRENCY, "USD");
        eventValues.Add(AFInAppEvents.REVENUE, "0.99");
        eventValues.Add("af_quantity", "1");
        AppsFlyer.sendEvent(AFInAppEvents.PURCHASE, eventValues);
    }


    private void printDebugLog(string msg){
         Debug.Log("[DEBUG] AppsFlyer [PAZ] [Unity]: " + msg);
    }


    public void showApiScene(){
         SceneManager.LoadScene(apiSceneName);
    }

    public string DeepLinkEventsArgsToString(DeepLinkEventsArgs dp){
        return "{" + "match_type = "+  dp.getMatchType()+ ", " + "deep_link_value = "+  dp.getDeepLinkValue()
        + ", " + "media_source = "+  dp.getMediaSource() 
        + ", " + "campaign = "+  dp.getCampaign()+  "}";

    }
}
