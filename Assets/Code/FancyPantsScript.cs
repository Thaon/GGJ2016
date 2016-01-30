﻿using UnityEngine;
using System.Collections;
using Colorful;

public class FancyPantsScript : MonoBehaviour {

    [SerializeField]
    public GameObject[] m_keys;
    public int m_activeKey = 0;
    GameObject m_camera;
    Grayscale m_grayScale;
    bool m_keysAvailable = true;


    // Use this for initialization
    void Start () {
        m_camera = GameObject.FindWithTag("MainCamera");
        m_grayScale = m_camera.GetComponent<Grayscale>();
	}
	
	// Update is called once per frame
	void Update () {
        if (m_keysAvailable)
        {
            float distanceToKey = ( Vector2.Distance(transform.position, m_keys[m_activeKey].transform.position) / 15 );

            if (distanceToKey > 1)
            {
                distanceToKey = 1;
                //m_grayScale.Amount = distanceToKey;
            }

            if (distanceToKey < 0)
            {
                distanceToKey = 0;
                //m_grayScale.Amount = distanceToKey;
            }

            m_grayScale.Amount = Mathf.Sqrt(distanceToKey);
        }
        else
        {
            m_grayScale.Amount = 1;
        }
    }

    public void UpdateKey()
    {
        m_activeKey++;
        if (m_activeKey > 2)
            m_keysAvailable = false;
    }
}
