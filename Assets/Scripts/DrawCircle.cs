using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour {

    public float radius;

	// Use this for initialization
	void Start () {
        LineRenderer lrend = this.GetComponent<LineRenderer>();

        for (int i = 0; i < lrend.positionCount; i++)
        {
            float xpos = radius * Mathf.Cos(Mathf.Deg2Rad * i);
            float zpos = radius * Mathf.Sin(Mathf.Deg2Rad * i);

            lrend.SetPosition(i, new Vector3(xpos, 0, zpos));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
