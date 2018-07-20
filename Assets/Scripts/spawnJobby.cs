using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnJobby : MonoBehaviour {

    public GameObject jobby;
	
    // Use this for initialization
	void Start () {
        if(jobby.active = false) {
            jobby.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
