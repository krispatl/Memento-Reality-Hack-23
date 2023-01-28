using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    // Start is called before the first frame update
    public float plusZ = 1f;
    public float minusZ = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Forward ()
    {
        var pos = transform.position;
        transform.position += new Vector3(pos.x, pos.y, plusZ);
    }

    public void Backward ()
    {
        var pos = transform.position;
        transform.position += new Vector3(pos.x, pos.y, minusZ);
    }

}
