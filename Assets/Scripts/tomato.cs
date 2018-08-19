using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomato : MonoBehaviour {
    public GameObject splatObject;
    public float lifetime;
    float lerpTime = 5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter(Collision collision)
	{
        splatObject = (GameObject)Instantiate(splatObject, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
        Debug.Log("splat");
        Destroy(gameObject);
        Destroy(splatObject, lifetime);
	}


}
