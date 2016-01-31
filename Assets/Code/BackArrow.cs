using UnityEngine;
using System.Collections;

public class BackArrow : MonoBehaviour {

    public GameObject m_BackFC;

	// Use this for initialization
	void OnMouseDown()
    {
        m_BackFC.SetActive(true);
    }
}
