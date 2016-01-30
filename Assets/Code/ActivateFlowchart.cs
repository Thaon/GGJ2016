using UnityEngine;
using System.Collections;

public class ActivateFlowchart : MonoBehaviour {

    public GameObject flowchart;
	public GameObject newPos;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            flowchart.SetActive(true);
            gameObject.SetActive(false);
        }
    }
	public void Moveplayer() 
	{
		if (newPos != null)
		{
			GameObject.FindWithTag("Player").transform.position = newPos.transform.position;
		}
	}

}
