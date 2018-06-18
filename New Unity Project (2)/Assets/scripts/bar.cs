using System.Collections;
using System.Collections;
using UnityEngine;

public class bar : MonoBehaviour {
  public float moveSpeed;
  public GameObject bullet;
  public GameObject Player;
	// Use this for initialization
	void Start () {
		moveSpeed = 8f;
	}
	
	// Update is called once per frame
	void Update () {
		  transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,0f);

      if(Input.GetKeyDown("space")) {
        GameObject bulletpos = (GameObject)Instantiate (Player);
        bulletpos.transform.position = bullet.transform.position;
      }
	}
}
  