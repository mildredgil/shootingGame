using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
  public Rigidbody2D bullet;
  Rigidbody2D clone;
  float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    Debug.Log(transform.position);
		if(Input.GetButtonDown ("Fire1")) {
      clone = Instantiate(bullet, transform.position, transform.rotation);
  		clone.velocity = transform.TransformDirection( new Vector2(0, speed));
  		Destroy (clone.gameObject, 5);
    }
    
	}
}
