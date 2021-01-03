using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public float timeUntilDestruction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestruct", timeUntilDestruction);
    }

    // Update is called once per frame
    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
