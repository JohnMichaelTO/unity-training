using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool hasWon;
    public static int nbEnemies = 0;
    public GameObject gameOverScreen;
    public GameObject winningScreen;
    public GameObject finishZone;

    private bool finishZoneSet = false;

    void Awake()
    {
        isGameOver = false;
        hasWon = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        } else if (hasWon) {
            winningScreen.SetActive(true);
        } else if(nbEnemies == 0 && !finishZoneSet)
        {
            this.SetFinishZone();
        }
    }

    void SetFinishZone()
    {
        finishZoneSet = true;
        int xPos = Random.Range(25, 50);
        int zPos = Random.Range(25, 50);
        finishZone.transform.position = new Vector3(xPos, 0, zPos);
        finishZone.SetActive(true);
    }
}
