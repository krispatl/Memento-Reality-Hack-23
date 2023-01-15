using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
public float speed = 1;
public float amplitude = 1f;

private Vector3 originalScale;
private float timeElapsed;

private void Start()
{
    originalScale = transform.localScale;
}

private void Update()
{
    timeElapsed += Time.deltaTime * speed;
    //transform.localScale = originalScale * (1 + Mathf.PingPong(timeElapsed, amplitude - 1));
    //ease-in and ease-out
    transform.localScale = originalScale * (1 + (amplitude - 1) * Mathf.SmoothStep(0, 1, Mathf.PingPong(timeElapsed, 1)));
}
}
