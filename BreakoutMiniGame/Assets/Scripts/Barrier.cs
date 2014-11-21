using UnityEngine;
using System.Collections;

public class Barrier : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            Debug.Log("I've been hit!");
            Messenger.Broadcast<Transform>("barrier touched", transform);
        }


    }
}
