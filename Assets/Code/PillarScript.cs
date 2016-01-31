using UnityEngine;
using System.Collections;

public class PillarScript : MonoBehaviour
{

    public GameObject[] m_pillars;
    public int m_activePillar;

    // Use this for initialization
    void Start()
    {
        m_activePillar = Random.Range(0, 3);
        UpdatePillar();
    }

    public void UpdatePillar()
    {
        m_activePillar++;
        if (m_activePillar > 3)
            m_activePillar = 0;

        for (int i = 0; i < 3; i++)
        {
            m_pillars[i].SetActive(false);
        }
        m_pillars[m_activePillar].SetActive(true);
    }

    void OnMouseDown()
    {
        //Debug.Log("clicked");
        //transform.parent.gameObject.GetComponent<PillarScript>().UpdatePillar();
        UpdatePillar();
    }
}
