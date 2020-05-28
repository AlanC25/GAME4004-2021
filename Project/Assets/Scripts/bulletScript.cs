using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
