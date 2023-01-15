using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectY : MonoBehaviour
{
    // This will make it move 90 degrees per second
    [SerializeField] private float speed = 90;
    float yRotation = 0;
    private void Update()
    {
        yRotation += Time.deltaTime * speed;
        this.transform.rotation = Quaternion.Euler(-90, yRotation, 90);
    }
}

