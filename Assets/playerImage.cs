using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerImage : MonoBehaviour {
    public string GetUrl;
    public Sprite GetSprite;
    public UnityEngine.UI.Image GetImage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Image>().sprite = GetSprite;
	}
}
