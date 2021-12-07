using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 shootDirection;
    private string targetObject;
    private float bulletSpeed = 25f;

    public void Setup(Vector3 shootDirection, float alive, string targetObject)
    {
        this.shootDirection = shootDirection;
        this.targetObject = targetObject;
        Destroy(gameObject, alive);
    }

    private void Update()
    {
        transform.position += shootDirection * bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        // TODO: use generic method to handle this instead
        Character player = collider.GetComponentInParent<Character>();
        Enemy target = collider.GetComponentInParent<Enemy>();

        if (target != null && targetObject == "enemy")
        {
            target.Die();
            Destroy(gameObject);
        } else if (player != null && targetObject == "player")
        {
            player.Die();
            PlayerManager.isGameOver = true;
            Destroy(gameObject);
        }
    }
}
