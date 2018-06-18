using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag=="element"){
			Destroy(col.gameObject);
		}
  }
}
