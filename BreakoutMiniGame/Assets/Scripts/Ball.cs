using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    [SerializeField]
    float velocityY;

    [SerializeField]
    float velocityX;

    [SerializeField]
    Texture2D yellow;

    [SerializeField]
    Texture2D red;

    [SerializeField]
    Texture2D blue;


    int matNum = 0;
	// Use this for initialization
	void Start () 
    {
        Messenger.AddListener("block touched" , AddVelocity);
        Messenger.AddListener<Transform>("barrier touched", Bounce);
        Messenger.AddListener("screen tapped", ChangeMaterial);
        matNum = 1;
        renderer.material.mainTexture = red;
	}
	
	// Update is called once per frame
	void Update () {


	}

    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.name == "Paddle")
       {
            Debug.Log("Hit a paddle");
            AddVelocity(); 
       }

       if (col.gameObject.name == "Up")
       {
           //velocityX = 0;
           rigidbody.AddForce(0, -50, 0);
           //AddVelocity();
       }

       if (col.gameObject.name == "Left")
       {
           velocityX = 5;
           AddVelocity();
       }
       if (col.gameObject.name == "Down")
       {
           Destroy(gameObject);
       }
       if (col.gameObject.name == "Block")
       {
           Debug.Log("Hit a block");          
       }
    }

    void AddVelocity()
    {
        Debug.Log("Adding velocity");
        //TODO define what direction we need to send the ball.
        rigidbody.velocity = new Vector3(Random.Range(-velocityX, velocityX),  velocityY, 0);
    }

    void Bounce(Transform objectPosition)
    {
        rigidbody.AddForce(-15, -15, 0);
    }

    void ChangeMaterial()
    {
        if (matNum == 1)
        {
            renderer.material.mainTexture = yellow;
            tag = "Yellow";
            matNum = 2;
        }
        else if (matNum == 2)
        {
            renderer.material.mainTexture = blue;
            tag = "Blue";
            matNum = 3;
        }
        else if (matNum == 3)
        {
            renderer.material.mainTexture = red;
            tag = "Red";
            matNum = 1;
        }


    }

 

}
