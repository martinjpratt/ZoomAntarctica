using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwitcher : MonoBehaviour {

    public GameObject AntarcticaBed;
    public GameObject AntarcticaSurface;
    public GameObject RISBed;
    public GameObject RISSurface;
    Renderer outBedRend;
    Renderer outSurfRend;
    Renderer inBedRend;
    Renderer inSurfRend;
    bool animationStarted = false;
    float fadeTime = 2.0f;
    float startTime;


    public void switchToRIS()
    {
        outBedRend = AntarcticaBed.GetComponent<Renderer>();
        outSurfRend = AntarcticaSurface.GetComponent<Renderer>();
        inBedRend = RISBed.GetComponent<Renderer>();
        inSurfRend = RISSurface.GetComponent<Renderer>();
        startTime = Time.time;
        animationStarted = true;

    }

    public void switchToAnt()
    {
        inBedRend = AntarcticaBed.GetComponent<Renderer>();
        inSurfRend = AntarcticaSurface.GetComponent<Renderer>();
        outBedRend = RISBed.GetComponent<Renderer>();
        outSurfRend = RISSurface.GetComponent<Renderer>();
        startTime = Time.time;
        animationStarted = true;
    }
    
	// Update is called once per frame
	void Update () {
        if (animationStarted)
        {
            float fadeIncrement = Mathf.Lerp(0, 1, (Time.time - startTime) / fadeTime);

            if (fadeIncrement == 1)
            {
                animationStarted = false;
            }
        }
	}
}
