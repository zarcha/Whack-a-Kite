using UnityEngine;
using System.Collections;

public class popHit : MonoBehaviour {

	int level = 0;
	public GameObject top;
	public float disTime = 0.0f;
	bool paused;
	public AudioClip punch;
	void Awake()
	{
		disTime = 0;
		level = top.GetComponent<RandomPoper>().level;
		
	}

	void Update()
	{
		paused = top.GetComponent<RandomPoper>().pause;
		if(!paused){
			disTime += Time.deltaTime*level;
			if(disTime >= 2)
			{
				gameObject.SetActive(false);
				disTime = 0;
			}
			if(!gameObject.activeInHierarchy)
			{
				disTime = 0;
			}
		}
	}

	void OnMouseDown()
	{
		top.GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
		top.GetComponent<RandomPoper>().score += 1;
	}
}
