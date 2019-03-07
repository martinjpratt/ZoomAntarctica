using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePickLine : MonoBehaviour {

    public TextAsset pickData;

	// Use this for initialization
	void Start () {
        LineRenderer lrend = this.gameObject.GetComponent<LineRenderer>();

        string[] pickText = pickData.text.Split("\n"[0]);
        lrend.positionCount = pickText.Length;
        //int ct = 0;
        for (int i = 0; i < pickText.Length; i++)
        {
            string[] lineData = pickText[i].Split(","[0]);
            Vector2 polarCoords = ll2ps(float.Parse(lineData[0]), float.Parse(lineData[1]));
            //GameObject newObj = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            //newObj.transform.parent = this.transform;
            //newObj.transform.localPosition = new Vector3(polarCoords.x, float.Parse(lineData[2]), polarCoords.y);
            lrend.SetPosition(i, new Vector3(polarCoords.x, -float.Parse(lineData[2]), polarCoords.y));
            //ct++;
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
