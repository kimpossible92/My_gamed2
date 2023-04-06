using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLevel2 : MonoBehaviour {
    public int Number;
    public GameObject Lock;
    public bool islock;
    public string SceneName { get; internal set; }
    string nameLevel;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public string Startype;
    void Start () {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
	}
	public void ActiveStars()
    {
        if (islock == false)
        {
            if (Startype == "star1")
            {
                star1.SetActive(true);
            }
            else if (Startype == "star2")
            {
                star1.SetActive(true);
                star2.SetActive(true);
            }
            else if (Startype == "star3")
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else
            {

            }
        }
        else
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }
	// Update is called once per frame
	void Update () {
        if (Number == 1)
        {
            Lock.SetActive(false);
        }
        else if (PlayerPrefs.GetString(string.Format("lvl:{0}", Number-1)) == "star1"||
            PlayerPrefs.GetString(string.Format("lvl:{0}", Number - 1)) == "star2"||
            PlayerPrefs.GetString(string.Format("lvl:{0}", Number - 1)) == "star3") Lock.SetActive(false);
        else Lock.SetActive(true);
    }
    public void IsLockedLevel()
    {
        Lock.active = islock;
    }
}
