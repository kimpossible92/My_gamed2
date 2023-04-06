using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharedLibrary;
using Deb1;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var player = await HttpClient.Get<Player>("https://localhost:7066/player/500");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
