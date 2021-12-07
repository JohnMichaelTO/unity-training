using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionPanel : MonoBehaviour
{
    public GameObject targetObject;
    public Text x;
    public Text y;
    public Text z;

    private void FixedUpdate()
    {
        x.text = Math.Round(targetObject.transform.position.x, 2).ToString();
        y.text = Math.Round(targetObject.transform.position.y, 2).ToString();
        z.text = Math.Round(targetObject.transform.position.z, 2).ToString();
    }
}
