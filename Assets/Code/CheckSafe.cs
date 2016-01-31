using UnityEngine;
using System.Collections;

public class CheckSafe : MonoBehaviour {

    public GameObject m_safeCheckerScript;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void OnMouseDown()
    {
        m_safeCheckerScript.GetComponent<SafeCheck>().Check();
    }
}
