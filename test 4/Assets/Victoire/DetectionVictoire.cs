using UnityEngine;
using System.Collections;

public class DetectionVictoire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Application.LoadLevel ("Scene2");
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "UneBalle") {

			// Son du contact
			this.GetComponent<AudioSource> ().Play ();

			print ("Scene sup");
		}

	}


}
