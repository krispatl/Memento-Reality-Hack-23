using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectX : MonoBehaviour
{
    // This will make it move 90 degrees per second
    [SerializeField] private float speed = 90;
    float xRotation = 0;
    private void Update()
    {
        xRotation += Time.deltaTime * speed;
        this.transform.rotation = Quaternion.Euler(xRotation, 90, 90);
    }
}

