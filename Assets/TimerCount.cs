using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCount : MonoBehaviour {
    public int limitTypers;
    private float lastTime;
    
	void Update ()
    {
		if(limitTypers==1)//LIMIT.TIME)
        {
            if (lastTime + 30f < Time.time)
            {
                lastTime = Time.time;
            }
	    }
    }
}