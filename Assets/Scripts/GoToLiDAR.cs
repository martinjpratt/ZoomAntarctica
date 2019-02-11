using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLiDAR : MonoBehaviour {

    Vector3 targetStartPosition;
    Vector3 targetStartScale;
    public bool selected = false;
    bool underway = false;

    public float posSpeed = 0.1f;
    public float scaleSpeed = 0.1f;
    private float startTime;
    private float journeyLength;
    private float scaleLength;

    Vector3 endPosition = new Vector3(0, 0, 0);
    Vector3 endScale = new Vector3(1000, 1000, 1000);

    // Use this for initialization
    void Start () {
        targetStartPosition = this.transform.localPosition;
        endPosition = new Vector3(targetStartPosition.x, targetStartPosition.y + 0.3f, targetStartPosition.z);
        targetStartScale = this.transform.localScale;
        journeyLength = Vector3.Distance(targetStartPosition, endPosition);
        scaleLength = Vector3.Distance(targetStartScale, endScale);
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        if (selected)
        {   
            // Distance moved = time * speed.
            float distCovered = (Time.time - startTime) * posSpeed;
            float scaleCovered = (Time.time - startTime) * scaleSpeed;

            // Fraction of journey completed = current distance divided by total distance.
            float fracJourney = distCovered / journeyLength;
            float fracScale = scaleCovered / scaleLength;

            // Set our position as a fraction of the distance between the markers.
            this.transform.localPosition = Vector3.Lerp(targetStartPosition, endPosition, fracJourney);
            this.transform.localScale = Vector3.Lerp(targetStartScale, endScale, fracScale);
            
            if (fracScale >= 1)
            {
                selected = false;
            }

        }
    }
}
