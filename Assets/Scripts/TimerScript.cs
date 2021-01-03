using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public string LoadGameOver;
    [SerializeField]
    private float maximumTime = 120;
    private float timeRemaining;

    public SimpleHealthBar healthBar;
    private void OnEnable()
    {
        timeRemaining = maximumTime;
    }

    //update current health
    public void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            healthBar.UpdateBar(timeRemaining, maximumTime);
        }
        else if (timeRemaining <= 0)
        {
            SceneManager.LoadScene(LoadGameOver);
        }
    }
}
