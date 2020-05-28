using UnityEngine;
public class EnemyHealth : MonoBehaviour
{

    //update current health
    public void TakeDamage(int damageAmount)
    {
        Die();
        ScoreManager.score += 1;
    }

    //destroy when hit
    private void Die()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}