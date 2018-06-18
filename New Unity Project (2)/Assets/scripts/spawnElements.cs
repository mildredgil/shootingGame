using System.Collections;
using UnityEngine;

public class spawnElements : MonoBehaviour {
  public GameObject element;
  public Sprite[] elementSprites;
  private int[] points = {4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,-1,-2,-3,-4,-1,-2,-3,-4,-1,-2,-3,-4,-1,-2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,2,3,4,-1,-2,-3,-4,1,2,3,4,-1,-2,-3,-4,1,2,3,4,-1,-2,-3,-4,1,2,3,4,-1,-2,-3,-4,0,0,0,0,0};
  

  public void MakeRandomElement() {
    Debug.Log(points.Length);
    int idx = Random.Range(0, elementSprites.Length);
    Sprite elementSprite = elementSprites[idx];
    string elementName = elementSprite.name;

    GameObject newElement = Instantiate(element);

    newElement.name = elementName;
    newElement.tag = "element";
    newElement.GetComponent<element>().elementName = elementName;
    newElement.GetComponent<element>().oxidationNumber = points[idx];
    newElement.GetComponent<SpriteRenderer>().sprite = elementSprite;    
  }
	// Use this for initialization
	void Start () {
		InvokeRepeating("MakeRandomElement", 2.0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
    
	}
}
