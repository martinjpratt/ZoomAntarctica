using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class HideIfCursorHovering : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.parent.GetComponent<InteractiveMeshCursor>().mHasHover)
        {
            this.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            this.GetComponent<Renderer>().enabled = true;
        }
	}
}
