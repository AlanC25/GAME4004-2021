using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{
    public float afterSeconds;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Trigger", afterSeconds);
    }

    // Update is called once per frame
    void Trigger()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
