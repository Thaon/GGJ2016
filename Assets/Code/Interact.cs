using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

    public GameObject m_flowchart;
    public GameObject m_UICanvas;
    public string m_prompt;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_UICanvas.SetActive(true);
            m_UICanvas.GetComponentInChildren<Text>().text = m_prompt;
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
        if (m_flowchart != null)
        {
            m_flowchart.SetActive(true);
        }
    }
}