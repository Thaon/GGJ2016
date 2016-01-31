using UnityEngine;
using System.Collections;

public class SafeCheck : MonoBehaviour {

    public GameObject[] m_pillars;
    public int[] m_combination;

    void Start()
    {
        m_combination = new int[] { 2,3,0,1};
    }

	public void Check()
    {
        for (int i = 0; i < 4; i++)
        {
            if (m_pillars[i].GetComponent<PillarScript>().m_activePillar != m_combination[i])
            {
                Debug.Log("not right");
                return;
            }
        }
        Debug.Log("bafta");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check();
        }
    }
}
