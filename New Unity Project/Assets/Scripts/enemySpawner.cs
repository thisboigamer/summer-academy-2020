using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float xPos;
    [SerializeField] private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount >= 0)
            {
                //randomize the x-position
                xPos = Random.Range(-4.1f, 4.1f);
                //create a new enemy
                Instantiate(enemy, new Vector3(xPos, 0.6882371f, 18), Quaternion.identity);
                //wait for 1 second before running again
                yield return new WaitForSeconds(1);
                //add 1 to enemyCount
                enemyCount += 1;
            }


    }
}
