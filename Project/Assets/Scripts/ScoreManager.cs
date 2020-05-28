using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public string Success;
    public static int score;

    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        if (score >= 20)
        {
            SceneManager.LoadScene(Success);
        }
    }
}
