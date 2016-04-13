using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public GameObject balle;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// On place la caméra
		this.transform.position = balle.transform.position + new Vector3(0, 20, -30);
		this.transform.LookAt(balle.transform);
	}
}
