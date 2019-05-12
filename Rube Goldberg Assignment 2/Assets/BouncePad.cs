using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour{

    public int Speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            collision.gameObject.GetComponent<Rigidbody>
                ().AddForce(Vector3.up * Speed);
        }
    }

}
