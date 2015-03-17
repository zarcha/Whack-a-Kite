using UnityEngine;
using System.Collections;

public class Miss : MonoBehaviour {

	void OnMouseDown()
	{
		GetComponent<AudioSource>().Play();
	}
}
