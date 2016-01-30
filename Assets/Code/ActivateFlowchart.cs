using UnityEngine;
using System.Collections;

public class ActivateFlowchart : MonoBehaviour {

    public GameObject flowchart;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            flowchart.SetActive(true);
        }
    }
}
