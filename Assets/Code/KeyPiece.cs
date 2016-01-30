using UnityEngine;
using System.Collections;

public class KeyPiece : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindWithTag("MainCamera").GetComponent<FancyPantsScript>().UpdateKey();
            Destroy(this.gameObject);
        }
    }
}
