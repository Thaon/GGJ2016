using UnityEngine;
using System.Collections;

public class ClickOnPillar : MonoBehaviour {

    void OnMouseDown()
    {
        Debug.Log("clicked");
        transform.parent.gameObject.GetComponent<PillarScript>().UpdatePillar();
    }
}
