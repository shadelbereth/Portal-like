using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

    Vector3 posInit;

	// Use this for initialization
	void Start () {
	   posInit = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	   if (transform.position.y < -10) {
            transform.position = posInit;
       }
	}
}
