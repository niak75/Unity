using UnityEngine;
using System.Collections;
using System;

public class Plateau : MonoBehaviour {

	public int m_taille = 11;
	public GameObject m_case;

	void Start()
	{
		for(int i = 1; i < m_taille+1; i++) // Haut vers bas
		{
			for(int j = 1; j < m_taille+1; j++) //Gauche vers droite
			{
				// Création des cases
				GameObject go = (GameObject)Instantiate(m_case, new Vector3(i,0,j), Quaternion.Euler(new Vector3(90,0,0)));
				// On donne un nom à nos cases
				go.name = i+"-"+j; 
				// On positionne chaque case
				go.transform.position = new Vector3(go.transform.position.x + 0.5f * j,go.transform.position.y + 0.2f*(float)Math.Cos(36.0*i/m_taille), go.transform.position.z - 0.2f * j);
			}
		}
		// On place la caméra
		this.transform.position = new Vector3(9,12,5);
		Quaternion rotation = Quaternion.Euler(new Vector3(90, 301, 0));
		this.transform.rotation = rotation;
	}


}
