using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public GameObject myPaddle;

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
        myPaddle = GameObject.Find("RotPaddle");
        rotationSpeed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rotation = new Vector3(2, 0, 0);
        myPaddle.transform.Rotate(rotation);
	}
}
