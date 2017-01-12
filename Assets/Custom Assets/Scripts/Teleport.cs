using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Bullet") {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = transform.position;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
