using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	float vitesseX=0;
	float vitesseZ=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Z)) {
			vitesseX += 0.02f;
		} 
		else if (Input.GetKey (KeyCode.S)) {
			vitesseX -= 0.02f;
		} else {
			vitesseX -= 0.01f*vitesseX;
		}
		this.transform.Rotate (vitesseX, 0, 0, Space.World);
	}
}
