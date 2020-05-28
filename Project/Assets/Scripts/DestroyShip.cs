using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider impactObject)
    {
        if(impactObject.tag != "ChaseSensor" && impactObject.tag != "EnemyAI")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
