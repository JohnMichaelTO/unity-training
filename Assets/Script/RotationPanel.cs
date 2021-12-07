using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationPanel : MonoBehaviour
{
    public GameObject targetObject;
    public Text x;
    public Text y;
    public Text z;

    private void FixedUpdate()
    {
        x.text = Math.Round(targetObject.transform.rotation.x, 2).ToString();
        y.text = Math.Round(targetObject.transform.rotation.y, 2).ToString();
        z.text = Math.Round(targetObject.transform.rotation.z, 2).ToString();
    }
}
