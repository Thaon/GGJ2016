using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public GameObject m_flowChart;

	// Use this for initialization
	void OnMouseDown()
    {
        m_flowChart.SetActive(true);
    }
}
