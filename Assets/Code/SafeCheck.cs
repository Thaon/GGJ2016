using UnityEngine;
using System.Collections;

public class SafeCheck : MonoBehaviour {

    public GameObject[] m_pillars;
    public int[] m_combination;
    public GameObject m_closeSafeFC;

    public AudioClip m_wrongOne;
    public AudioClip m_rightOne;

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
                //Debug.Log("not right");
                //GetComponent<AudioSource>().clip = m_wrongOne;
                GetComponent<AudioSource>().PlayOneShot(m_wrongOne);
                return;
            }
        }
        //Debug.Log("bafta");
        GetComponent<AudioSource>().PlayOneShot(m_rightOne);
        m_closeSafeFC.SetActive(true);
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Check();
    //    }
    //}
}
