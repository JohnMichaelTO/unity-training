using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject footLeft;
    public GameObject footRight;
    public float movementSpeed = 50;
    public float rotationAngle = 5;
    public string title = "Target";
    public Transform target;

    private Color defaultColor = Color.black;
    public Transform bullet;

    bool inCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        this.SetColor(defaultColor);
    }

    public void SetTarget(Transform targetObject)
    {
        this.target = targetObject;
    }
    public void SetColor(Color color)
    {
        head.GetComponent<Renderer>().material.SetColor("_Color", color);
        body.GetComponent<Renderer>().material.SetColor("_Color", color);
        footLeft.GetComponent<Renderer>().material.SetColor("_Color", color);
        footRight.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    void Update()
    {
        if (!inCoroutine)
            StartCoroutine(RandomMove());
    }

    IEnumerator RandomMove()
    {
        inCoroutine = true;
        int move = Random.Range(1, 6);
        switch (move)
        {
            case 1:
                transform.position += transform.forward * (movementSpeed * Time.deltaTime);
                break;
            case 2:
                transform.position -= transform.forward * (movementSpeed * Time.deltaTime);
                break;
            case 3:
                transform.Rotate(0, rotationAngle, 0);
                break;
            case 4:
                transform.Rotate(0, -rotationAngle, 0);
                break;
            case 5:
                transform.LookAt(target);
                this.Shoot();
                break;
        }
        yield return new WaitForSeconds(1.5f);
        inCoroutine = false;
    }

    void Shoot()
    {
        Debug.Log("Enemy shooting");
        Transform bulletTransform = Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        bulletTransform.GetComponent<Bullet>().Setup(transform.forward, 2f, "player");
    }

    public void Die()
    {
        Destroy(gameObject);
        PlayerManager.nbEnemies--;
    }
}
