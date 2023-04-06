using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour
{
    public void MenuTounamentClick()
    {
        if (PlayerPrefs.GetInt("TourQual") >= 10)
        {
            if (GameObject.FindObjectOfType<TournamentLB>() != null)// && TounamentLB.THIS.playerNames != null)
            {
                GameObject.FindObjectOfType<TournamentLB>().Cleared();
            }
            GameObject.FindObjectOfType<PortalNetwork>().GetTournamer();//
            GameObject.FindObjectOfType<PortalNetwork>().GetPlayersTournament();//
            GameObject.Find("CanvasGlobal").transform.Find("TournamentWindow").gameObject.SetActive(true);
            GameObject.FindObjectOfType<Tournament>().kubokButton();
            //TournamentLB.THIS = GameObject.FindObjectOfType<Tournament>().TourametWindow.GetComponent<TournamentLB>();
            GameObject.FindObjectOfType<Tournament>().TourametWindow.GetComponent<TournamentLB>().OnSwitch();
        }
        else
        {
            GameObject.Find("CanvasGlobal").transform.Find("TournamentQualification").gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("TourQual") >= 10)
            {
                GameObject.Find("CanvasGlobal").transform.Find("TournamentQualification").transform.Find("Image").transform.Find("Join").gameObject.SetActive(true);
                GameObject.Find("CanvasGlobal").transform.Find("TournamentQualification").transform.Find("Image").transform.Find("CheckTarget").transform.Find("Check").gameObject.SetActive(true);
            }
            else
            {
                GameObject.Find("CanvasGlobal").transform.Find("TournamentQualification").transform.Find("Image").transform.Find("Join").gameObject.SetActive(false);
                GameObject.Find("CanvasGlobal").transform.Find("TournamentQualification").transform.Find("Image").transform.Find("CheckTarget").transform.Find("Check").gameObject.SetActive(false);
            }
            GameObject.FindObjectOfType<Tournament>().kubokButton();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerPrefs.SetInt("TourQual", (PlayerPrefs.GetInt("TourQual")+10));
        }
    }
}
