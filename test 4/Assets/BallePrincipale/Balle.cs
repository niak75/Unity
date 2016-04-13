using UnityEngine;
using System.Collections;

public class Balle : MonoBehaviour {

	private bool touche = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.touche) {
			if (Input.GetKey (KeyCode.Z)) {
				this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 50);
			}  if (Input.GetKey (KeyCode.S)) {    
				this.GetComponent<Rigidbody> ().AddForce (Vector3.back * 50);
			}  if (Input.GetKey (KeyCode.Q)) {    
				this.GetComponent<Rigidbody> ().AddForce (Vector3.left * 50);
			}  if (Input.GetKey (KeyCode.D)) {    
				this.GetComponent<Rigidbody> ().AddForce (Vector3.right * 50);
			} 
		}
	}

	void OnCollisionStay(Collision collision) {
		this.touche = true;
	}

	void OnCollisionExit(Collision collision) {
		this.touche = false;
	}
}


