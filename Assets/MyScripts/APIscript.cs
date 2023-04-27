using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
using UnityEngine.UI;


public class APIscript : MonoBehaviour
{
    public bool shouldAnonymizeUser = false;
    public Button anonymizeUserBTN;
    public Button stopBTN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void logEvent(){
        Dictionary<string, string> eventValues = new Dictionary<string, string>();
        eventValues.Add(AFInAppEvents.CURRENCY, "USD");
        eventValues.Add(AFInAppEvents.REVENUE, "0.99");
        eventValues.Add("af_quantity", "1");
        AppsFlyer.sendEvent(AFInAppEvents.PURCHASE, eventValues);
    }


    public void stopSDK(){
        AppsFlyer.stopSDK(!AppsFlyer.isSDKStopped());
        stopBTN.GetComponentInChildren<Text>().text = !AppsFlyer.isSDKStopped() ? "Stop SDK" : "Start SDK";

    }

    public void anonymizeUser(){
        shouldAnonymizeUser = !shouldAnonymizeUser;
        AppsFlyer.anonymizeUser(shouldAnonymizeUser);
        anonymizeUserBTN.GetComponentInChildren<Text>().text = !shouldAnonymizeUser ? "Anonymize User" : "Deanonymize User";

    }

    public void crossPromo(){
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        parameters.Add("af_sub1", "val");
        parameters.Add("custom_param", "val2");
        AppsFlyer.recordCrossPromoteImpression("com.paz.segment_demo", "campaign", parameters);
    }

    public void openStore(){
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        parameters.Add("af_sub1", "val");
        parameters.Add("custom_param", "val2");
        AppsFlyer.attributeAndOpenStore("123456789", "test campaign", parameters, this);
    }

}
