using UnityEngine;
using System.Collections;


public class SkySpawn : MonoBehaviour {
	
		public float spawnTime = 2f;
		public float spawnDelay = 2f;
		public GameObject[] items;
		
		// Use this for initialization
		void Start()
		{
			InvokeRepeating("Spawn", spawnDelay, spawnTime);
		}
		
		void Spawn()

		{
			/* Instantiate a cow */
			int picker = Random.Range(0, items.Length);

			GameObject item = (GameObject)GameObject.Instantiate (items[picker], new Vector3(Random.Range (-8.5f, 8.5f), 8f, 0), Quaternion.identity);

			}
	}
