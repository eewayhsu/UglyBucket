using UnityEngine;
using System.Collections;

public class RainMovement : MonoBehaviour { 

	float speed; 
	float yLocation; 

	// Use this for initialization
	void Start () {

		speed = Random.Range (.05f, .2f); 
	}
	
	// Update is called once per frame
	void Update () {

		yLocation = transform.position.y - speed;

		if (yLocation < -6f)
			Destroy (gameObject);

		gameObject.transform.position = new Vector3(transform.position.x, yLocation, transform.position.z);
	

	}
}
