using UnityEngine;
using System.Collections;

public class Block: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball" && col.gameObject.tag == tag)
        {
            Debug.Log("I've been hit!");
            Messenger.Broadcast("block touched");
            Destroy(gameObject);
        }


    }
}
