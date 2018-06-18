using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {
  public Text txt;
	public Text msg;
	public static int crash;
	public static string mensaje;

	// Use this for initialization
	void Start () {
		txt.text = "Points: ";
		crash = 0;
		msg.text = "";
		mensaje = "";
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Points: " + crash;
		msg.text = mensaje;
    Debug.Log(txt.text);
    Debug.Log(msg.text);

    if(crash >= 30) {      
      change.ChangeScene("WINNER");
    } else if( crash < -5) {
      change.ChangeScene("LOOSER");
    } 
	} 
}

