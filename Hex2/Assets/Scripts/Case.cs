using UnityEngine;
using System.Collections;

public class Case : MonoBehaviour {

	public AudioClip son_passage;
	public AudioClip son_clic;
	public int etat = 0;

	void OnMouseEnter()
	{
		transform.localScale += new Vector3(0.1f,0.1f,0.1f);
		GetComponent<AudioSource>().PlayOneShot(son_passage);
	}

	void OnMouseExit()
	{
		transform.localScale -= new Vector3(0.1f,0.1f,0.1f);
	}

	void OnMouseUp()
	{
		if(etat == 0)
		{
			GetComponent<AudioSource>().PlayOneShot(son_clic);
			etat = GameManager.tourJoueur;
			if(GameManager.tourJoueur == 1)
			{
				GetComponent<Renderer>().material.SetColor("_TintColor", Color.red);
				GameManager.tourJoueur = 2;
			}
			else
			{
				GetComponent<Renderer>().material.SetColor("_TintColor", Color.green);
				GameManager.tourJoueur = 1;
			}

		}
	}
}
