using UnityEngine;
using System.Collections;
using Colorful;

public class FancyPantsScript : MonoBehaviour {

    [SerializeField]
    public GameObject m_theDoor;
    public GameObject[] m_keys;
    public int m_activeKey = 2;
    GameObject m_camera;
    Grayscale m_grayScale;
    bool m_keysAvailable = true;
    float distanceToKey;

    float m_offset = 0.1f;

    public GameObject m_music1;
    public GameObject m_music2;


    // Use this for initialization
    void Start () {
        m_camera = GameObject.FindWithTag("MainCamera");
        m_grayScale = m_camera.GetComponent<Grayscale>();
	}
	
	// Update is called once per frame
	void Update () {
        if (m_keysAvailable)
        {
            float distanceToKey1 = ( Vector2.Distance(GameObject.FindWithTag("Player").transform.position, m_keys[0].transform.position) / 15 );
            float distanceToKey2 = (Vector2.Distance(GameObject.FindWithTag("Player").transform.position, m_keys[1].transform.position) / 15);

            float distanceToDoor = ( Vector2.Distance(GameObject.FindWithTag("Player").transform.position, m_theDoor.transform.position) / 15 );

            if (distanceToKey1 > distanceToKey2)
            {
                distanceToKey = distanceToKey2;
            }
            else
            {
                distanceToKey = distanceToKey1;
            }


            if (distanceToKey > 1)
            {
                distanceToKey = 1;
            }

            if (distanceToKey < 0)
            {
                distanceToKey = 0;
            }

            //do the same for the door
            if (distanceToDoor > 1)
            {
                distanceToDoor = 1;
            }

            if (distanceToDoor < 0)
            {
                distanceToDoor = 0;
            }

            //we set the colour to reappear regardless of the presence of a key, if the player is near the door
            if (distanceToDoor > distanceToKey)
                m_grayScale.Amount = Mathf.Sqrt(distanceToKey) - ( m_offset * m_activeKey );
            else
                m_grayScale.Amount = Mathf.Sqrt(distanceToDoor) - ( m_offset * m_activeKey);
        }
        else
        {
            float distanceToDoor = (Vector2.Distance(GameObject.FindWithTag("Player").transform.position, m_theDoor.transform.position) / 5);

            if (distanceToDoor > 1)
            {
                distanceToDoor = 1;
            }

            if (distanceToDoor < 0)
            {
                distanceToDoor = 0;
            }

            m_grayScale.Amount = Mathf.Sqrt(distanceToDoor) - ( m_offset * m_activeKey );
        }
    }

    public void UpdateKey()
    {
        m_activeKey++;
        if (m_activeKey > 1)
            m_keysAvailable = false;
        if (m_activeKey == 1)
        {
            m_music1.SetActive(true);
        }
        if (m_activeKey == 2)
        {
            m_music1.SetActive(false);
            m_music2.SetActive(true);
        }
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
