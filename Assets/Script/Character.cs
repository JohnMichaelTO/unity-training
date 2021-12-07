using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject footLeft;
    public GameObject footRight;
    public float movementSpeed = 250;
    public float rotationAngle = 10;
    public string title = "White";
    public float range = 100f;
    private Color defaultColor = Color.white;

    public Transform bullet;

    // Start is called before the first frame update
    void Start()
    {
        this.SetColor(defaultColor);
    }

    public void SetColor(Color color)
    {
        head.GetComponent<Renderer>().material.SetColor("_Color", color);
        body.GetComponent<Renderer>().material.SetColor("_Color", color);
        footLeft.GetComponent<Renderer>().material.SetColor("_Color", color);
        footRight.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    public void Reset()
    {
        this.SetColor(defaultColor);
        transform.position = new Vector3(0, 1.76f, 0);
        transform.rotation = new Quaternion(0, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += transform.forward * (movementSpeed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position -= transform.forward * (movementSpeed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Rotate(0, rotationAngle, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.Rotate(0, -rotationAngle, 0);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Shooting");
        Transform bulletTransform = Instantiate(bullet, transform.position + transform.forward, transform.rotation);
        bulletTransform.GetComponent<Bullet>().Setup(transform.forward, 3f, "enemy");
    }

    public void Die()
    {
        Debug.Log("Game over!");
        // Can destroy gameObject but need to manage destruction of all other objects correctly
        // Destroy(gameObject);
    }
}
