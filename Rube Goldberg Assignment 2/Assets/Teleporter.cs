using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Transform teleportTarget;
    public GameObject theBall;

    private void OnTriggerEnter(Collider other)
    {
        theBall.transform.position = teleportTarget.transform.position;
    }


}


