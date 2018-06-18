using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

  float speed;
	// Use this for initialization
	void Start () {
		speed = 8f;
	}
	
	// Update is called once per frame
	void Update () {
    Vector2 position = transform.position;
    position = new Vector2(position.x, position.y + speed * Time.deltaTime);
    Debug.Log(position.y);
    transform.position = position;

    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1 ));

    if(transform.position.y > max.y){
      Destroy(gameObject);
    }

		if(Input.GetButtonDown ("Fire1")) {
      
      /*clone = Instantiate(bullet, transform.position, transform.rotation);
  		clone.velocity = transform.TransformDirection( new Vector2(0, speed));
  		Destroy (clone.gameObject, 5);*/
    }
	}
}
