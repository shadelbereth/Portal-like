using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneOnShoot : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Bullet") {
            SceneManager.LoadScene("Level2");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
