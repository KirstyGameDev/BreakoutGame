using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour {

    [SerializeField]
    public GameObject otherPaddle;

    //The paddle we're holding
    private Vector3 offset;
    private Vector3 screenPoint;

    //The opposite paddle
    private Vector3 otherOffset;
    private Vector3 otherScreenPoint;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
     
        screenPoint= Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, gameObject.transform.position.y, screenPoint.z));

        otherScreenPoint = Camera.main.WorldToScreenPoint(otherPaddle.transform.position);
        otherOffset = otherPaddle.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, otherPaddle.transform.position.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, gameObject.transform.position.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

        Vector3 OthercurScreenPoint = new Vector3(Input.mousePosition.x, otherPaddle.transform.position.y, screenPoint.z);
        Vector3 OthercurPosition = Camera.main.ScreenToWorldPoint(OthercurScreenPoint) + otherOffset;

        otherPaddle.transform.position = OthercurPosition;


    }
}
