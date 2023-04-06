using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portrait : MonoBehaviour {
    
	void Update () {
        Screen.orientation = UnityEngine.ScreenOrientation.Portrait; //в начальном экране менюс с замком всегда портретный вид
    }
}
