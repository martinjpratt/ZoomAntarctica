using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceRadarQuad : MonoBehaviour {

    public float startLatitude;
    public float startLongitude;

    public float endLatitude;
    public float endLongitude;

    public float yMax;
    public float yMin;

    public bool tieLine = false;

    // Use this for initialization
    void Start () {
        Vector2 startxy = ll2ps(startLatitude, startLongitude);
        Vector2 endxy = ll2ps(endLatitude, endLongitude);

        float meanX = (startxy.x + endxy.x) / 2f;
        float meanY = (startxy.y + endxy.y) / 2f;

        float posX = meanX * 1e-5f;
        float posZ = meanY * 1e-5f;
        float posY = ((yMax + yMin) / 2) * 1e-5f;

        transform.localPosition = new Vector3(-posX, posY, -posZ);

        float yScale = (yMax - yMin) * 1e-5f;
        float dist = Vector2.Distance(startxy, endxy) * 1e-5f;
        float xDist = Vector2.Distance(new Vector2(startxy.x, 0), new Vector2(endxy.x, 0));
        float yDist = Vector2.Distance(new Vector2(startxy.y, 0), new Vector2(endxy.y, 0));
        transform.localScale = new Vector3(dist, yScale, 1);

        if (tieLine)
        {
            transform.localEulerAngles = new Vector3(0, 90 - (Mathf.Tan(xDist / yDist) * Mathf.Rad2Deg), 0);
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, (Mathf.Tan(yDist / xDist) * Mathf.Rad2Deg), 0);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    Vector2 ll2ps(float lat, float lon)
    {
        float phi_c = -71;   //standard parallel
        float a = 6378137.0f;   //radius of ellipsoid
        float e = 0.08181919f;  //eccentricity WGS84
        float lambda_0 = 0;    //meridian along positive Y axis

        lat = lat * Mathf.Deg2Rad;
        lon = lon * Mathf.Deg2Rad;
        phi_c = phi_c * Mathf.Deg2Rad;
        lambda_0 = lambda_0 * Mathf.Deg2Rad;

        float t = Mathf.Tan(Mathf.PI / 4 + lat / 2) / Mathf.Pow(((1 - e * Mathf.Sin(-lat)) / (1 + e * Mathf.Sin(-lat))), e / 2);
        float t_c = Mathf.Tan(Mathf.PI / 4 + phi_c / 2) / Mathf.Pow(((1 - e * Mathf.Sin(-phi_c)) / (1 + e * Mathf.Sin(-phi_c))), e / 2);
        float m_c = Mathf.Cos(-phi_c) / Mathf.Sqrt(1 - Mathf.Pow(e, 2) * Mathf.Pow(Mathf.Sin(-phi_c), 2));

        float rho = a * m_c * t / t_c;

        Vector2 xy = new Vector2(-rho * Mathf.Sin(-lon + lambda_0), rho * Mathf.Cos(-lon + lambda_0));

        return xy;
    }
}
