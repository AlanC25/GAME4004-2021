using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBuildings : MonoBehaviour
{
    public GameObject[] buildings;
    //inner wall width is 20
    int cityWidth = 15;
    int cityHeight = 10;
    int buildingFootprint = 4;

    // Start is called before the first frame update
    void Start()
    {
        for (int h = -cityHeight; h < cityHeight; h++)
        {
            for (int w = (-cityWidth + buildingFootprint); w < (cityWidth - buildingFootprint); w++)
            {
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
