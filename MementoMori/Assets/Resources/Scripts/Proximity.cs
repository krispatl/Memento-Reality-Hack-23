using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proximity : MonoBehaviour
{
    //public Transform explosionPrefab;
    public GameObject messages;


    void OnCollisionEnter(Collision collision)
    {

/*        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);*/

        //FindObjectOfType<AudioInput>().Play("boom");

        if (collision.gameObject.CompareTag("Wave"))

            Instantiate(messages);


        // Destroy(gameObject);
    }
}
