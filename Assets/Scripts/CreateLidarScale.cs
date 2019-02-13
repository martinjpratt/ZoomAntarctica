using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLidarScale : MonoBehaviour {

    public GameObject lineObject;

	// Use this for initialization
	void Start () {
        Bounds bound = this.GetComponent<MeshFilter>().mesh.bounds;
        print(bound.min);
        print(bound.max);
        print(bound.center);
        print(bound.extents * 2f);

        GameObject lineObject1 = Instantiate(lineObject, this.transform);
        lineObject1.GetComponent<LineRenderer>().positionCount = 5;
        lineObject1.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.min.x, bound.min.y, bound.max.z));
        lineObject1.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.max.x, bound.min.y, bound.max.z));
        lineObject1.GetComponent<LineRenderer>().SetPosition(2, new Vector3(bound.max.x, bound.max.y, bound.max.z));
        lineObject1.GetComponent<LineRenderer>().SetPosition(3, new Vector3(bound.min.x, bound.max.y, bound.max.z));
        lineObject1.GetComponent<LineRenderer>().SetPosition(4, new Vector3(bound.min.x, bound.min.y, bound.max.z));

        GameObject lineObject2 = Instantiate(lineObject, this.transform);
        lineObject2.GetComponent<LineRenderer>().positionCount = 5;
        lineObject2.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.min.x, bound.min.y, bound.min.z));
        lineObject2.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.max.x, bound.min.y, bound.min.z));
        lineObject2.GetComponent<LineRenderer>().SetPosition(2, new Vector3(bound.max.x, bound.max.y, bound.min.z));
        lineObject2.GetComponent<LineRenderer>().SetPosition(3, new Vector3(bound.min.x, bound.max.y, bound.min.z));
        lineObject2.GetComponent<LineRenderer>().SetPosition(4, new Vector3(bound.min.x, bound.min.y, bound.min.z));

        GameObject lineObject3 = Instantiate(lineObject, this.transform);
        lineObject3.GetComponent<LineRenderer>().positionCount = 2;
        lineObject3.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.min.x, bound.min.y, bound.min.z));
        lineObject3.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.min.x, bound.min.y, bound.max.z));

        GameObject lineObject4 = Instantiate(lineObject, this.transform);
        lineObject4.GetComponent<LineRenderer>().positionCount = 2;
        lineObject4.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.max.x, bound.min.y, bound.min.z));
        lineObject4.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.max.x, bound.min.y, bound.max.z));

        GameObject lineObject5 = Instantiate(lineObject, this.transform);
        lineObject5.GetComponent<LineRenderer>().positionCount = 2;
        lineObject5.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.max.x, bound.max.y, bound.min.z));
        lineObject5.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.max.x, bound.max.y, bound.max.z));

        GameObject lineObject6 = Instantiate(lineObject, this.transform);
        lineObject6.GetComponent<LineRenderer>().positionCount = 2;
        lineObject6.GetComponent<LineRenderer>().SetPosition(0, new Vector3(bound.min.x, bound.max.y, bound.min.z));
        lineObject6.GetComponent<LineRenderer>().SetPosition(1, new Vector3(bound.min.x, bound.max.y, bound.max.z));
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
