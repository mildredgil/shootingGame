using System.Collections;
using System.Collections;
using UnityEngine;

public class bar : MonoBehaviour {
  public float moveSpeed;
  public GameObject bullet;
  public GameObject Player;

  double min;
  double max;
	// Use this for initialization
	void Start () {
		moveSpeed = 8f;
    Vector2 maxVal= Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1 ));
    Vector2 minVal = Camera.main.ViewportToWorldPoint(new Vector2 (0 , 0 ));
    min = minVal.x;
    max = maxVal.x;
	}
	
	// Update is called once per frame
	void Update () {    
    if(transform.position.x <= min)
	    transform.Translate(moveSpeed*(Input.GetAxis("Horizontal") + 1)*Time.deltaTime,0f,0f);
    else if(transform.position.x >= max)
      transform.Translate(moveSpeed*(Input.GetAxis("Horizontal") - 1)*Time.deltaTime,0f,0f);
    else
      transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,0f);
        
    if(Input.GetKeyDown("space")) {
      GameObject bulletpos = (GameObject)Instantiate (Player);
      bulletpos.transform.position = bullet.transform.position;
    }
	}
}
  