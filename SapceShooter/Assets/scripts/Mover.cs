using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody rb;
    private Transform ts;
    public float speed =10;

	// Use this for initialization
	void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        ts = gameObject.GetComponent<Transform>();
        rb.velocity =  speed * ts.forward ;
    }
	
}
