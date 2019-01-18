using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalExaggerator : MonoBehaviour {

    float sliderValue;
    Vector3 initialScaleValue;
    public Transform targetTransform;

    public void updateVerticalExaggeration()
    {
        sliderValue = this.GetComponent<SliderGestureControl>().SliderValue;
        targetTransform.localScale = new Vector3(initialScaleValue.x, sliderValue * initialScaleValue.y, initialScaleValue.z);
    }


	// Use this for initialization
	void Start () {
        initialScaleValue = targetTransform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
