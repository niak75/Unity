using UnityEngine;
using System.Collections;

public class MouvementBoule : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody> ().AddForce (Vector3.right * 40);
	}
}
