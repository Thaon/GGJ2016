using UnityEngine;
using System.Collections;

public class ChangeArea : MonoBehaviour {

    public GameObject m_flowchart;
    public GameObject m_UICanvas;
    public GameObject m_newPos;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_UICanvas.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_UICanvas.SetActive(false);
        }
    }

    public void Use()
    {
        if (m_flowchart != null && m_newPos != null)
        {
            m_flowchart.SetActive(true);
        }
    }
}
