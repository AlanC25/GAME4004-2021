using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Chase : MonoBehaviour
{
    WaypointProgressTracker pTracker;

    // Start is called before the first frame update
    void Start()
    {
        pTracker = transform.parent.parent.GetComponent<WaypointProgressTracker>();
    }

    private void OnTriggerEnter(Collider playerShip)
    {
        Debug.Log("Trigger");

        if (playerShip.tag == "PlayerCollider")
        {
            pTracker.circuit = GameObject.FindWithTag("ChaseCircuit").GetComponent<WaypointCircuit>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
