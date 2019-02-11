using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteLidar : MonoBehaviour {


    public void userDeleteLidar()
    {
        Destroy(GameObject.FindGameObjectWithTag("lidar"));
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
