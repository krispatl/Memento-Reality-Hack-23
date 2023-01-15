using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class Pogo : MonoBehaviour
  {
    public GameObject item_to_bounce;
    public float speed = 1f;
    public float height = 0.05f;
    public float startY = 1.25f;

    void Update()
    {
        var pos = transform.position;
        var newY = startY + height*Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(pos.x, newY, pos.z);
    }
  }