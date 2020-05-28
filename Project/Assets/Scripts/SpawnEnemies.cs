using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public float xPos;
    public float yPos;
    public float zPos;
    public static int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 20)
        {
            xPos = Random.Range(-100, 12);
            yPos = Random.Range(10, 15);
            zPos = Random.Range(-100, 0);

            Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);

            yield return new WaitForSeconds(4);
            enemyCount += 1;
        }
    }

    private void Update()
    {

    }
}
