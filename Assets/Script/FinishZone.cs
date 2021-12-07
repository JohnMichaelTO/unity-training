using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    void OnTriggerEnter()
    {
        PlayerManager.hasWon = true;
    }
}
