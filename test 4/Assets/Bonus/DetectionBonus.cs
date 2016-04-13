using UnityEngine;
using System.Collections;

public class DetectionBonus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "UneBalle") {

			float newRayon = collision.gameObject.transform.localScale.x * 1.3f;
			collision.gameObject.transform.localScale=new Vector3(newRayon,newRayon,newRayon);

			// Son du contact :
			this.GetComponent<AudioSource> ().Play ();

			// Détruis le bonus :
			Destroy (gameObject);
		}

	}


}
