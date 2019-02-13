using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAdjustor : MonoBehaviour {

    public bool xAxis;
    public bool yAxis;
    public bool zAxis;
    Vector3 initialScale;
    GameObject sliderExaggerator;

	// Use this for initialization
	void Start () {
        initialScale = this.transform.localScale;
        sliderExaggerator = GameObject.FindGameObjectWithTag("verticalExaggerator");
    }
	
	// Update is called once per frame
	void Update () {
        if (xAxis)
        {
            this.transform.localScale = new Vector3(initialScale.x / sliderExaggerator.GetComponent<SliderGestureControl>().SliderValue, initialScale.y, initialScale.z);
        }
        if (yAxis)
        {
            this.transform.localScale = new Vector3(initialScale.x, initialScale.y / sliderExaggerator.GetComponent<SliderGestureControl>().SliderValue, initialScale.z);
        }
        if (zAxis)
        {
            this.transform.localScale = new Vector3(initialScale.x, initialScale.y, initialScale.z / sliderExaggerator.GetComponent<SliderGestureControl>().SliderValue);
        }
    }
}
