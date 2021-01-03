using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public string mainMenuLevel;

    [SerializeField]
    private int maxHealth = 20;
    private int currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    //update current health
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    //destroy when health hits 0
    private void Die()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(mainMenuLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
