using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour
{
    void Awake()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            ScoreManager.score += 1;
        }
    }
}
