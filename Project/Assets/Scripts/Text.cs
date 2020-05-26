using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    //Add reference to UI Text here via the inspector
    public Text textToAppear;  

    private float timeToAppear = 2f;
    private float timeWhenDisappear;

    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        textToAppear.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (textToAppear.enabled && (Time.time >= timeWhenDisappear))
        {
            textToAppear.enabled = false;
        }
    }
}
