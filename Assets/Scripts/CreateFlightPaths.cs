using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFlightPaths : MonoBehaviour {

    public GameObject flightPath;
    public TextAsset flightPathData;
    float scaleFactor = 0.00001f;

	// Use this for initialization
	void Start () {
        string[] lineData = flightPathData.text.Split("\n"[0]);

        for (int i = 0; i < lineData.Length - 1; i+=2)
        {
            string[] startData = lineData[i].Split(","[0]);
            string[] endData = lineData[i + 1].Split(","[0]);

            GameObject newPathObject = Instantiate(flightPath, this.transform);
            newPathObject.name = startData[3];
            newPathObject.GetComponent<LineRenderer>().SetPosition(0, new Vector3(float.Parse(startData[5]) * scaleFactor, 0, float.Parse(startData[6]) * scaleFactor));
            newPathObject.GetComponent<LineRenderer>().SetPosition(1, new Vector3(float.Parse(endData[5]) * scaleFactor, 0, float.Parse(endData[6]) * scaleFactor));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
