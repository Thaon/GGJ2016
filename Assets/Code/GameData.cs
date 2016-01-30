using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    //game data relies lightly on the singleton pattern, it can only be instantiated during runtime

    int m_itemsFound = 0;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
