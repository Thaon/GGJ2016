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
	void NextDay () {
        m_storyTime++;
	}
}
