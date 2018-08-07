using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnJobby : MonoBehaviour {

    public GameObject jobbyFront;
	public GameObject jobbyMid;
	public GameObject jobbyBack;

	
    // Use this for initialization
	void Start () {
		spawn ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawn() {
		float randomTime = Random.Range (3, 10);
		Object.Instantiate (jobbyBack, transform.position = Random.insideUnitSphere, transform.rotation);
		Invoke ("spawn", randomTime);


	}
	void targetMove() {
		
	}
		
}
