using UnityEngine;
using System.Collections;

public class BucketCollect : MonoBehaviour {

	//items[water, fire, fertilizer, disease] 
	public int[] items; 
	public int points = 5; 

	private int i; 
	
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	

	}


	void OnCollisionEnter2D (Collision2D col)
	{
		//TODO: Do some animation for eating the items!  


		if (col.gameObject.name == "rain(Clone)")
			i = 0;

		if(col.gameObject.name == "fireball(Clone)")
			i = 1;

		if (col.gameObject.name == "blob(Clone)")
			i = 2;	

		if (col.gameObject.name == "fertilizer(Clone)")
			i = 3;	

		items[i] += points;

		
		print ("collide" + i);
		Destroy(col.gameObject);

	}

}
