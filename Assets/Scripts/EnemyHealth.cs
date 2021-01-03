using UnityEngine;
public class EnemyHealth : MonoBehaviour
{

    //update current health
    public void TakeDamage(int damageAmount)
    {
        Die();
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