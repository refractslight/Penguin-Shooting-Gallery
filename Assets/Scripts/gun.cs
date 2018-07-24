using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
    public GameObject projectile;
    public float spawnDistance = .05f;
    public float shootForce = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            shoot();
        }
	}

    void shoot() {
        GameObject thisProjectile = GameObject.Instantiate(projectile, transform.position + (transform.forward * spawnDistance), transform.rotation);
        Rigidbody thisrb = thisProjectile.GetComponent<Rigidbody> ();
        thisrb.AddForce(transform.forward * shootForce, ForceMode.VelocityChange);
    }
}
