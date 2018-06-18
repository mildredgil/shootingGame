using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class element : MonoBehaviour {

  public string elementName;
  public int oxidationNumber;
  
	// Use this for initialization
	void Start () {
    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1));
    Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2 (0 , 0));
		float x = Random.Range(min.x, max.x);
    Vector2 pos = new Vector2(x, transform.position.y);
    transform.position = pos;

	}
	
	// Update is called once per frame
	void Update () {
		moveDown();

    Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2 (0 , 0));

    if(transform.position.y <= min.y) {
        points.crash -= oxidationNumber;
      Destroy(gameObject);
    }
	}

  void moveDown() {
    transform.Translate(0f, -Time.deltaTime,0f);
  }

  public int getOxidationNumber() {
    return oxidationNumber;
  }

  public string getElementName() {
    return elementName;
  }

  public void setOxidationNumber(int ox) {
    oxidationNumber = ox;
  }

  void OnTriggerEnter2D(Collider2D col){
    Debug.Log(col.gameObject.name);
		if(col.gameObject.name == "ball(Clone)") {
      if(points.crash > 10 && oxidationNumber > 0 )
        points.crash += oxidationNumber*2;
      
      points.crash += oxidationNumber;
      points.mensaje = elementName + ": " + oxidationNumber  + " "; 
		}
  }
}
