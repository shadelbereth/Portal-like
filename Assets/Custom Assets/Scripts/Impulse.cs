using UnityEngine;
using System.Collections;

public class Impulse : MonoBehaviour {

    public float force;

	// Use this for initialization
	void Start () {
	   GetComponent<Rigidbody>().AddForce(transform.forward * force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
