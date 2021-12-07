using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int maxEnemy = 2;
    public Transform targetObject;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        for (int i = 0; i < maxEnemy; i++)
        { 
            int xPos = Random.Range(-25, 25);
            int zPos = Random.Range(-25, 25);
            float yAngle = Random.Range(0, 360);

            GameObject enemy = Instantiate(theEnemy, new Vector3(xPos, 1.76f, zPos), Quaternion.Euler(0, yAngle, 0));
            enemy.GetComponent<Enemy>().SetTarget(targetObject);
            PlayerManager.nbEnemies++;

            yield return new WaitForSeconds(0.1f);
        }
    }
}
