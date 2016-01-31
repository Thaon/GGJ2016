using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    //game data relies lightly on the singleton pattern, it can only be instantiated during runtime

    int m_storyTime = 0;
    public GameObject[] m_storyPresets;
    public bool m_hasPlant = false;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	public void NextDay () {
        m_storyTime++;
        Transform children = m_storyPresets[0].GetComponentInChildren<Transform>();
        //Debug.Log(children);
        foreach (Transform go in children)
        {
            //Debug.Log(go);
            go.gameObject.SetActive(true);
        }
        //Debug.Log(m_storyTime);
        if (m_storyTime == 3)
        {
            //Debug.Log(children);
            foreach (Transform go in m_storyPresets[1].GetComponentInChildren<Transform>())
            {
                //Debug.Log(go);
                if (go.gameObject.activeInHierarchy)
                    go.gameObject.SetActive(false);
                else
                    go.gameObject.SetActive(true);
            }
        }
	}

    public void GetPlant()
    {
        m_hasPlant = true;
    }
}
