using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            Messenger.Broadcast("screen tapped");
        }
	}

    void OnMouseDown()
    {
        Debug.Log("MOUSE DOWN");
       
    }
}
