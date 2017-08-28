using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;
    public GameObject myPrefab2;


    // Use this for initialization
    void Start() { 
    
        int totalCubes = 30;
        float totalDistance = 2.9f;
             
        //sin distro
        for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;
            float sin = Mathf.Sin(perc * Mathf.PI/2);

            float x = 1.8f + sin * totalDistance;
            float y = 5.0f;
            float z = 0.0f;
            if (i % 2 == 0)
            {
                var newObject = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                newObject.GetComponent<CubeScript>().SetSize(.45f * (1.0f - perc));
                newObject.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f;
                newObject.GetComponent<CubeScript>().cubeNumber = i + 2;
            }
            else
            {
                var newObject = (GameObject)Instantiate(myPrefab2, new Vector3(x, y, z), Quaternion.identity);
                newObject.GetComponent<SphereScript>().SetSize(.45f * (1.0f - perc));
                newObject.GetComponent<SphereScript>().rotateSpeed = .2f + perc * 4.0f;
                newObject.GetComponent<SphereScript>().SphereNumber = i + 2;
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
