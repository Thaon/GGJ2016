using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    //game data relies lightly on the singleton pattern, it can only be instantiated during runtime

    int m_storyTime = 0;
    public GameObject[] m_storyPresets;

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
        
	}
}
