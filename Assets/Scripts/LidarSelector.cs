using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class LidarSelector : MonoBehaviour, IInputClickHandler, IFocusable {

    public GameObject targetLidar;
    public Transform lidarParent;
    public GameObject turnOffBed;
    public GameObject turnOffSurface;

    Color boxColor;

    public void OnFocusEnter()
    {
        this.GetComponent<Renderer>().material.SetColor("_HoverColorOverride",Color.red);
    }

    public void OnFocusExit()
    {
        this.GetComponent<Renderer>().material.SetColor("_HoverColorOverride",boxColor);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (!GameObject.FindGameObjectWithTag("lidar"))
        {
            GameObject newObj = Instantiate(targetLidar, lidarParent);
            newObj.GetComponent<GoToLiDAR>().selected = true;
        }
    }

    // Use this for initialization
    void Start () {
        boxColor = this.GetComponent<Renderer>().material.GetColor("_HoverColorOverride");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
