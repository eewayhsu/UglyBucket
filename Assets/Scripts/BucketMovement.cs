using UnityEngine;
using System.Collections;

public class BucketMovement : MonoBehaviour {
	
	public int speed;

	private float xLocation; 
	
	// Use this for initialization
	void Start () {

		Screen.orientation = ScreenOrientation.LandscapeLeft;
		xLocation = gameObject.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		xLocation += Input.acceleration.x * speed * Time.deltaTime;
		xLocation += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;


//TODO: Fix the locations (do not hardcode!) 

		//Debug.Log(Screen.width);
		//Debug.Log("Xlocation:" + xLocation);

		if (xLocation < -8.5f)
			xLocation = -8.5f; 

		if (xLocation > 8.5f)
			xLocation = 8.5f;


		gameObject.transform.position = new Vector3(xLocation, transform.position.y, transform.position.z);


	

		
	}
}
